using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    public class KryptonScrollBarTest : Control
    {
        private ScrollBarOrientation _orientation = ScrollBarOrientation.Vertical;
        private Rectangle _thumbRectangle;
        private Rectangle _topArrowRectangle;
        private Rectangle _bottomArrowRectangle;
        private Rectangle _channelRectangle;
        private int _thumbHeight;
        private int _thumbWidth;
        private int _minimum;
        private int _maximum = 100;
        private int _value;
        private int _smallChange = 1;
        private int _largeChange = 10;
        private Timer _repeatTimer;
        private int _repeatDirection = 0;
        private PaletteState _state = PaletteState.Normal;

        public KryptonScrollBarTest()
        {
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            Width = 20; // Default width for vertical scrollbars
            Height = 20; // Default height for horizontal scrollbars

            _repeatTimer = new Timer { Interval = 50 };
            _repeatTimer.Tick += RepeatTimer_Tick;
        }

        public ScrollBarOrientation Orientation
        {
            get => _orientation;
            set
            {
                if (_orientation != value)
                {
                    _orientation = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(0)]
        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                if (_value < _minimum)
                {
                    _value = _minimum;
                }
                Invalidate();
            }
        }

        [DefaultValue(100)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                if (_value > _maximum)
                {
                    _value = _maximum;
                }
                Invalidate();
            }
        }

        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = Math.Max(_minimum, Math.Min(value, _maximum));
                    ValueChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        [DefaultValue(1)]
        public int SmallChange
        {
            get => _smallChange;
            set => _smallChange = value;
        }

        [DefaultValue(10)]
        public int LargeChange
        {
            get => _largeChange;
            set => _largeChange = value;
        }

        public event EventHandler ValueChanged;

        private PaletteBase _palette;
        public PaletteBase Palette
        {
            get => _palette ?? KryptonManager.CurrentGlobalPalette;
            set
            {
                if (_palette != value)
                {
                    _palette = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(BackColor);

            DrawArrowButtons(g);
            DrawThumb(g);
            DrawChannel(g);
        }

        private void DrawArrowButtons(Graphics g)
        {
            _state = Enabled ? PaletteState.Normal : PaletteState.Disabled;
            PaletteBase palette = Palette;
            if (palette != null)
            {
                using (var brush = new SolidBrush(palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, _state)))
                {
                    g.FillRectangle(brush, _topArrowRectangle);
                    g.FillRectangle(brush, _bottomArrowRectangle);
                }
            }
        }

        private void DrawThumb(Graphics g)
        {
            _state = Enabled ? PaletteState.Normal : PaletteState.Disabled;
            PaletteBase palette = Palette;

            if (_orientation == ScrollBarOrientation.Vertical)
            {
                _thumbHeight = Math.Max(10, Height * LargeChange / (Maximum - Minimum + LargeChange));
                int thumbY = (int)((float)(Value - Minimum) / (Maximum - Minimum) * (Height - 2 * Width - _thumbHeight));
                _thumbRectangle = new Rectangle(ClientRectangle.X, ClientRectangle.Y + Width + thumbY, Width, _thumbHeight);
            }
            else
            {
                _thumbWidth = Math.Max(10, Width * LargeChange / (Maximum - Minimum + LargeChange));
                int thumbX = (int)((float)(Value - Minimum) / (Maximum - Minimum) * (Width - 2 * Height - _thumbWidth));
                _thumbRectangle = new Rectangle(ClientRectangle.X + Height + thumbX, ClientRectangle.Y, _thumbWidth, Height);
            }

            if (palette != null)
            {
                using (var brush = new SolidBrush(palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, _state)))
                {
                    g.FillRectangle(brush, _thumbRectangle);
                }
            }
        }

        private void DrawChannel(Graphics g)
        {
            _state = Enabled ? PaletteState.Normal : PaletteState.Disabled;
            PaletteBase palette = Palette;

            if (_orientation == ScrollBarOrientation.Vertical)
            {
                _channelRectangle = new Rectangle(ClientRectangle.X, ClientRectangle.Y + Width, Width, Height - 2 * Width);
            }
            else
            {
                _channelRectangle = new Rectangle(ClientRectangle.X + Height, ClientRectangle.Y, Width - 2 * Height, Height);
            }

            if (palette != null)
            {
                using (var brush = new SolidBrush(palette.GetBackColor1(PaletteBackStyle.PanelClient, _state)))
                {
                    g.FillRectangle(brush, _channelRectangle);
                }
            }
        }

        private void RepeatTimer_Tick(object sender, EventArgs e)
        {
            HandlePageChange(_repeatDirection);
        }

        private void HandlePageChange(int direction)
        {
            if (direction > 0)
            {
                Value += LargeChange;
            }
            else if (direction < 0)
            {
                Value -= LargeChange;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (_topArrowRectangle.Contains(e.Location))
            {
                Value -= SmallChange;
                _repeatDirection = -1;
                _repeatTimer.Start();
            }
            else if (_bottomArrowRectangle.Contains(e.Location))
            {
                Value += SmallChange;
                _repeatDirection = 1;
                _repeatTimer.Start();
            }
            else if (_channelRectangle.Contains(e.Location))
            {
                if (_orientation == ScrollBarOrientation.Vertical)
                {
                    if (e.Y < _thumbRectangle.Y)
                    {
                        Value -= LargeChange;
                    }
                    else if (e.Y > _thumbRectangle.Bottom)
                    {
                        Value += LargeChange;
                    }
                }
                else
                {
                    if (e.X < _thumbRectangle.X)
                    {
                        Value -= LargeChange;
                    }
                    else if (e.X > _thumbRectangle.Right)
                    {
                        Value += LargeChange;
                    }
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _repeatTimer.Stop();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
