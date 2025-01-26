﻿#region BSD License
/*
 *
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac & Ahmed Abdelhameed et al. 2025 - 2025. All rights reserved.
 *
 */
#endregion

using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    /// <summary></summary>
    [ToolboxItem(true)]
    [DefaultEvent(nameof(CheckedChanged))]
    [DefaultProperty(nameof(Checked))]
    [DesignerCategory("code")]
    [Description("A toggle switch control.")]
    public class KryptonToggleSwitch : Control, IContentValues
    {
        #region Instance Fields

        private bool _checked;
        private bool _isTracking;
        private bool _isPressed;
        private bool _isDragging;

        private int _knobSize;
        private int _padding;
        private int _dragStartX;

        private RectangleF _knob;

        private PaletteBase? _palette;

        private readonly PaletteRedirect _paletteRedirect;

        private Timer _animationTimer;

        private float _animationPosition;
        private float _dragOffset;

        private ToggleSwitchValues _toggleSwitchValues;

        #endregion

        #region Events

        /// <summary>Occurs when [checked changed].</summary>
        [Description("Occurs when the value of the Checked property changes.")]
        public event EventHandler CheckedChanged;

        #endregion

        #region Public Properties

        /// <summary>Gets the state common.</summary>
        /// <value>The state common.</value>
        [Category("Visuals")]
        [Description("Defines the common appearance settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect StateCommon { get; }

        private bool ShouldSerializeStateCommon() => !StateCommon.IsDefault;

        //private void ResetStateCommon() => StateCommon.Reset();

        [Category("Visuals")]
        [Description("Defines the disabled appearance settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple StateDisabled { get; }

        private bool ShouldSerializeStateDisabled() => !StateDisabled.IsDefault;

        /// <summary>Gets the state normal.</summary>
        /// <value>The state normal.</value>
        [Category("Visuals")]
        [Description("Defines the normal appearance settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple StateNormal { get; }

        private bool ShouldSerializeStateNormal() => !StateNormal.IsDefault;

        /// <summary>Gets the state pressed.</summary>
        /// <value>The state pressed.</value>
        [Category("Visuals")]
        [Description("Defines the pressed appearance settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple StatePressed { get; }

        private bool ShouldSerializeStatePressed() => !StatePressed.IsDefault;

        /// <summary>Gets the state tracking.</summary>
        /// <value>The state tracking.</value>
        [Category("Visuals")]
        [Description("Defines the tracking appearance settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple StateTracking { get; }

        private bool ShouldSerializeStateTracking() => !StateTracking.IsDefault;

        /// <summary>Gets or sets a value indicating whether this <see cref="KryptonToggleSwitch" /> is checked.</summary>
        /// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
        [Category("Behavior")]
        [Description("Indicates whether the toggle switch is checked.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Checked
        {
            get => _checked;
            set
            {
                if (_checked != value)
                {
                    _checked = value;

                    _animationTimer.Start();

                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                    StartAnimation();
                }
            }
        }

        [Category("Appearance")]
        [Description("Indicates whether the knob should have a gradient effect.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ToggleSwitchValues ToggleSwitchValues
        {
            get => _toggleSwitchValues;
            set
            {
                if (_toggleSwitchValues != value)
                {
                    if (_toggleSwitchValues != null)
                    {
                        _toggleSwitchValues.PropertyChanged -= OnToggleSwitchValuesChanged;
                    }

                    _toggleSwitchValues = value;

                    if (_toggleSwitchValues != null)
                    {
                        _toggleSwitchValues.PropertyChanged += OnToggleSwitchValuesChanged;
                    }

                    Invalidate();
                }
            }
        }

        private bool ShouldSerializeToggleSwitchValues() => !ToggleSwitchValues.IsDefault;

        public void ResetToggleSwitchValues() => ToggleSwitchValues.Reset();

        #endregion

        #region Identity

        /// <summary>Initializes a new instance of the <see cref="KryptonToggleSwitch" /> class.</summary>
        public KryptonToggleSwitch()
        {
            DoubleBuffered = true;

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            BackColor = Color.Transparent;

            Font = new Font("Segoe UI", 9f, FontStyle.Bold);

            _knobSize = 20;
            _padding = 4;
            Size = new Size(90, _knobSize + _padding * 2);

            _animationTimer = new Timer { Interval = 15 };

            _animationTimer.Tick += OnAnimationTimerTick;

            ToggleSwitchValues = new ToggleSwitchValues { OffColor = Color.Red, OnColor = Color.Green };

            KryptonManager.GlobalPaletteChanged += OnGlobalPaletteChanged;

            // Initialize PaletteRedirect with a default context
            PaletteRedirect redirector = new PaletteRedirect(KryptonManager.CurrentGlobalPalette);

            // Default state configuration
            StateCommon = new PaletteTripleRedirect(redirector, PaletteBackStyle.ButtonStandalone, PaletteBorderStyle.ButtonStandalone, PaletteContentStyle.ButtonStandalone);
            StateDisabled = new PaletteTriple(StateCommon, OnNeedPaintHandler);
            StateNormal = new PaletteTriple(StateCommon, OnNeedPaintHandler);
            StatePressed = new PaletteTriple(StateCommon, OnNeedPaintHandler);
            StateTracking = new PaletteTriple(StateCommon, OnNeedPaintHandler);

            ResetToggleSwitchValues();
        }

        #endregion

        #region Protected Overrides

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint">Paint</see> event.</summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs">PaintEventArgs</see> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            IPaletteTriple state = GetCurrentState();

            // Adjust the rectangle for border width
            float borderWidth = state.PaletteBorder!.GetBorderWidth(PaletteState.Normal);
            Rectangle adjustedBounds = AdjustForBorder(ClientRectangle, borderWidth);

            // Emboss effect
            if (ToggleSwitchValues.EnableEmbossEffect)
            {
                Color embossColor = KryptonManager.CurrentGlobalPalette.GetBackColor1(PaletteBackStyle.ButtonStandalone, PaletteState.Disabled);
                using (GraphicsPath embossPath = GetRoundedRectangle(ClientRectangle, ToggleSwitchValues.CornerRadius))
                using (Brush embossBrush = new SolidBrush(Color.FromArgb(50, embossColor)))
                {
                    e.Graphics.TranslateTransform(2, 2); // Offset for emboss effect
                    e.Graphics.FillPath(embossBrush, embossPath);
                    e.Graphics.TranslateTransform(-2, -2); // Reset transform
                }
            }

            // Background with rounded corners
            using (GraphicsPath backgroundPath = GetRoundedRectangle(ClientRectangle, ToggleSwitchValues.CornerRadius))
            using (Brush backgroundBrush = new SolidBrush(state.PaletteBack.GetBackColor1(PaletteState.Normal)))
            {
                e.Graphics.FillPath(backgroundBrush, backgroundPath);
            }

            // Border with rounded corners
            using (GraphicsPath borderPath = GetRoundedRectangle(ClientRectangle, ToggleSwitchValues.CornerRadius))
            using (Pen borderPen = new Pen(state.PaletteBorder.GetBorderColor1(PaletteState.Normal), state.PaletteBorder.GetBorderWidth(PaletteState.Normal)))
            {
                e.Graphics.DrawPath(borderPen, borderPath);
            }

            // Knob
            _knob = GetKnobRectangle();

            if (ToggleSwitchValues.EnableKnobGradient)
            {
                // Fetch colors based on Checked state
                Color startColor = Checked
                    ? AdjustBrightness(state.PaletteBack.GetBackColor1(PaletteState.Checked), ToggleSwitchValues.GradientStartIntensity) // Slightly darker
                    : AdjustBrightness(state.PaletteBack.GetBackColor1(PaletteState.Normal), ToggleSwitchValues.GradientStartIntensity);

                Color endColor = Checked
                    ? AdjustBrightness(state.PaletteBack.GetBackColor2(PaletteState.Checked), ToggleSwitchValues.GradientEndIntensity) // More intense
                    : AdjustBrightness(state.PaletteBack.GetBackColor2(PaletteState.Normal), ToggleSwitchValues.GradientEndIntensity);

                using (LinearGradientBrush knobBrush = new LinearGradientBrush(
                           _knob,
                           startColor,
                           endColor,
                           LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillEllipse(knobBrush, _knob);
                }
            }
            else
            {
                Color knobColor = _isPressed
                    ? state.PaletteBack.GetBackColor1(PaletteState.Pressed)
                    : _isTracking
                        ? state.PaletteBack.GetBackColor1(PaletteState.Tracking)
                        : state.PaletteBack.GetBackColor2(PaletteState.Normal);

                using (SolidBrush knobBrush = new SolidBrush(knobColor))
                {
                    e.Graphics.FillEllipse(knobBrush, _knob);
                }
            }

            // Text
            DrawOnOffText(e.Graphics, GetCurrentState());

            e.Graphics.ResetClip();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter">MouseEnter</see> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs">EventArgs</see> that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isTracking = true;
            Invalidate();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave">MouseLeave</see> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs">EventArgs</see> that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isTracking = false;
            Invalidate();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseDown">MouseDown</see> event.</summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs">MouseEventArgs</see> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                if (_knob.Contains(e.Location))
                {
                    // Start dragging if the click is on the knob
                    _isPressed = true;
                    _isDragging = true;
                    _dragStartX = e.X;
                    _dragOffset = _animationPosition;
                }
                else
                {
                    // Handle non-drag mouse press (existing behavior)
                    _isPressed = true;
                }

                Invalidate();
            }
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseMove">MouseMove</see> event.</summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs">MouseEventArgs</see> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_isDragging)
            {
                // Update knob position based on mouse movement
                float delta = e.X - _dragStartX;
                _animationPosition = Math.Max(_padding, Math.Min(Width - _knobSize - _padding, _dragOffset + delta));

                Invalidate(); // Redraw the control
            }
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseUp">MouseUp</see> event.</summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs">MouseEventArgs</see> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_isDragging)
            {
                // Finish dragging and determine the final toggle state
                _isDragging = false;

                // Determine final state based on knob's position
                float midpoint = (Width - _knobSize) / 2f;
                Checked = _animationPosition >= midpoint;
            }
            else if (_isPressed)
            {
                // Toggle state on simple click
                _isPressed = false;
                Checked = !Checked;
            }

            Invalidate();
        }


        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize">Resize</see> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs">EventArgs</see> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            using (GraphicsPath roundedPath = GetRoundedRectanglePath(ClientRectangle, /*ToggleSwitchValues.CornerRadius*/ 10))
            {
                Region = new Region(roundedPath);
            }

            _knobSize = Math.Min(Height - _padding * 2, Width / 3);

            _padding = Height / 10;

            Invalidate();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged">SizeChanged</see> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs">EventArgs</see> that contains the event data.</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (Width < 50 || Height < 20)
            {
                Width = Math.Max(50, Width);
                Height = Math.Max(20, Height);
            }
        }

        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control">Control</see> and its child controls and optionally releases the managed resources.</summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _animationTimer.Dispose();
                KryptonManager.GlobalPaletteChanged -= OnGlobalPaletteChanged;
            }

            base.Dispose(disposing);
        }

        #endregion

        #region Private Methods

        /// <summary>Starts the animation.</summary>
        private void StartAnimation()
        {
            _animationPosition = Checked ? _padding : Width - _knobSize - _padding;
            _animationTimer.Start();
        }

        /// <summary>Gets the state of the current.</summary>
        private IPaletteTriple GetCurrentState()
        {
            if (!Enabled)
            {
                return StateDisabled;
            }

            if (_isPressed)
            {
                return StatePressed;
            }

            if (_isTracking)
            {
                return StateTracking;
            }

            return StateNormal;
        }

        /// <summary>Gets the knob rectangle.</summary>
        private RectangleF GetKnobRectangle()
        {
            float knobDiameter = _knobSize;
            float x = Checked
                ? Width - knobDiameter - _padding
                : _padding;

            float y = (Height - knobDiameter) / 2f;

            return new RectangleF(x, y, knobDiameter, knobDiameter);
        }

        /// <summary>Gets the rounded rectangle path.</summary>
        /// <param name="bounds">The bounds.</param>
        /// <param name="cornerRadius">The corner radius.</param>
        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            int radius = cornerRadius; // Use corner radius proportional to height
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Top-left
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Top-right
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }

        /// <summary>Gets the rounded rectangle.</summary>
        /// <param name="bounds">The bounds.</param>
        /// <param name="radius">The radius.</param>
        private GraphicsPath GetRoundedRectangle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Top-left arc
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            // Top-right arc
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            // Bottom-right arc
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            // Bottom-left arc
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>Adjusts the brightness.</summary>
        /// <param name="color">The color.</param>
        /// <param name="factor">The factor.</param>
        private Color AdjustBrightness(Color color, float factor)
        {
            int r = (int)(color.R * factor);
            int g = (int)(color.G * factor);
            int b = (int)(color.B * factor);

            return Color.FromArgb(color.A, Math.Min(r, 255), Math.Min(g, 255), Math.Min(b, 255));
        }

        /// <summary>Adjusts for border.</summary>
        /// <param name="bounds">The bounds.</param>
        /// <param name="borderWidth">Width of the border.</param>
        private Rectangle AdjustForBorder(Rectangle bounds, float borderWidth)
        {
            return new Rectangle(
                (int)(bounds.X + borderWidth / 2),
                (int)(bounds.Y + borderWidth / 2),
                (int)(bounds.Width - borderWidth),
                (int)(bounds.Height - borderWidth)
            );
        }

        /// <summary>Draws the on off text.</summary>
        /// <param name="graphics">The graphics.</param>
        /// <param name="state">The state.</param>
        private void DrawOnOffText(Graphics graphics, IPaletteTriple state)
        {
            Color textColor;

            if (ToggleSwitchValues.UseThemeColors && KryptonManager.CurrentGlobalPalette != null)
            {
                textColor = Checked
                    ? KryptonManager.CurrentGlobalPalette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, PaletteState.CheckedNormal)
                    : KryptonManager.CurrentGlobalPalette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, PaletteState.Normal);
            }
            else
            {
                textColor = Checked ? ToggleSwitchValues.OnColor : ToggleSwitchValues.OffColor;
            }

            string text = Checked ? KryptonManager.Strings.CustomStrings.On : KryptonManager.Strings.CustomStrings.Off;
            float fontSize = Height / 3f; // Proportional font size
            using (Font font = new Font(Font.FontFamily, fontSize, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(textColor))
            {
                SizeF textSize = graphics.MeasureString(text, font);
                float x = Checked ? Width - _padding - _knobSize - textSize.Width : _padding + _knobSize;
                float y = (Height - textSize.Height) / 2f;

                // Set text rendering hint for smoother text
                graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                graphics.DrawString(text, font, textBrush, new PointF(x, y));

                // Reset text rendering hint to default
                graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
            }
        }


        /// <summary>Called when [need paint handler].</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="NeedLayoutEventArgs" /> instance containing the event data.</param>
        private void OnNeedPaintHandler(object? sender, NeedLayoutEventArgs e)
        {
            if (e.NeedLayout)
            {
                Invalidate(true);
            }
            else
            {
                Invalidate(e.InvalidRect);
            }
        }

        /// <summary>Called when [global palette changed].</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnGlobalPaletteChanged(object? sender, EventArgs e)
        {
            // Unhook events from old palette
            if (_palette != null)
            {
                _palette.PalettePaint -= OnPalettePaint;
            }

            // Cache the new PaletteBase that is the global palette
            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            // Hook into events for the new palette
            if (_palette != null)
            {
                _palette.PalettePaint += OnPalettePaint;
            }

            // Change of palette means we should repaint to show any changes
            Invalidate();
        }

        /// <summary>Called when [palette paint].</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaletteLayoutEventArgs" /> instance containing the event data.</param>
        private void OnPalettePaint(object? sender, PaletteLayoutEventArgs e) => Invalidate();

        /// <summary>Called when [animation timer tick].</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnAnimationTimerTick(object? sender, EventArgs e)
        {
            float targetPosition = Checked ? Width - _knobSize - _padding : _padding;
            float step = 0.1f; // Adjust this value for smoother or faster animation

            _animationPosition = Lerp(_animationPosition, targetPosition, step);

            if (Math.Abs(_animationPosition - targetPosition) < 0.5f)
            {
                _animationPosition = targetPosition;
                _animationTimer.Stop();
            }

            Invalidate(Rectangle.Ceiling(_knob));
        }

        private float Lerp(float start, float end, float amount) => start + (end - start) * amount;

        private void OnToggleSwitchValuesChanged(object? sender, PropertyChangedEventArgs e) => Invalidate();

        #endregion

        #region Hidden Properties

        /*/// <summary>Gets or sets the background color for the control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get; set; }

        /// <summary>Gets or sets the foreground color of the control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor { get; set; }

        /// <summary>Gets or sets the font of the text displayed by the control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get; set; }

        /// <summary>Gets or sets the background image displayed in the control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage { get; set; }

        /// <summary>Gets or sets the text associated with this control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text { get; set; }*/

        #endregion

        #region IContentValues

        /// <summary>Gets the content image.</summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Image? GetImage(PaletteState state)
        {
            throw new NotImplementedException();
        }

        /// <summary>Gets the image color that should be transparent.</summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Color GetImageTransparentColor(PaletteState state)
        {
            throw new NotImplementedException();
        }

        /// <summary>Gets the content short text.</summary>
        /// <returns>String value.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetShortText()
        {
            throw new NotImplementedException();
        }

        /// <summary>Gets the content long text.</summary>
        /// <returns>String value.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetLongText()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
