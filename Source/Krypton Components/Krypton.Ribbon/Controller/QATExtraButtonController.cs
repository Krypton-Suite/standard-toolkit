﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 *  Modified: Monday 12th April, 2021 @ 18:00 GMT
 *
 */
#endregion

namespace Krypton.Ribbon
{
    /// <summary>
    /// Provide quick access toolbar extra button controller functionality.
    /// </summary>
    internal class QATExtraButtonController : LeftDownButtonController,
                                              ISourceController,
                                              IKeyController,
                                              IRibbonKeyTipTarget

    {
        #region Instance Fields
        private bool _hasFocus;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the QATExtraButtonController class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        /// <param name="target">Target for state changes.</param>
        /// <param name="needPaint">Delegate for notifying changes in display.</param>
        public QATExtraButtonController(KryptonRibbon ribbon,
                                        ViewBase target, 
                                        NeedPaintHandler needPaint)
            : base(ribbon, target, needPaint)
        {
        }
        #endregion

        #region MouseNotifications
        /// <summary>
        /// Mouse button has been pressed in the view.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="pt">Mouse position relative to control.</param>
        /// <param name="button">Mouse button pressed down.</param>
        /// <returns>True if capturing input; otherwise false.</returns>
        public override bool MouseDown(Control c, Point pt, MouseButtons button)
        {
            base.MouseDown(c, pt, button);
            return false;
        }

        /// <summary>
        /// Should the left mouse down be ignored when present on a visual form border area.
        /// </summary>
        public override bool IgnoreVisualFormLeftButtonDown => true;

        #endregion

        #region Focus Notifications
        /// <summary>
        /// Source control has got the focus.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public virtual void GotFocus(Control c)
        {
            _hasFocus = true;

            // Redraw to show the change in visual state
            UpdateTargetState();
            OnNeedPaint(false, Target.ClientRectangle);
        }

        /// <summary>
        /// Source control has lost the focus.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public virtual void LostFocus(Control c)
        {
            _hasFocus = false;

            // Redraw to show the change in visual state
            UpdateTargetState();
            OnNeedPaint(false, Target.ClientRectangle);
        }
        #endregion

        #region Key Notifications
        /// <summary>
        /// Key has been pressed down.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        public void KeyDown(Control c, KeyEventArgs e)
        {
            if (c is VisualPopupQATOverflow overflow)
            {
                KeyDownPopupOverflow(overflow, e);
            }
            else
            {
                KeyDownRibbon(e);
            }
        }

        /// <summary>
        /// Key has been pressed.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyPressEventArgs that contains the event data.</param>
        public void KeyPress(Control c, KeyPressEventArgs e)
        {
        }

        /// <summary>
        /// Key has been released.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        /// <returns>True if capturing input; otherwise false.</returns>
        public bool KeyUp(Control c, KeyEventArgs e) => false;

        #endregion

        #region KeyTipSelect
        /// <summary>
        /// Perform actual selection of the item.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        public void KeyTipSelect(KryptonRibbon ribbon)
        {
            // Change to a fixed pressed appearance
            SetFixed();
            UpdateTargetState();

            // Generate a click event
            OnClick(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

            // We should have a visual popup for showing the qat overflow group
            if (VisualPopupManager.Singleton is { IsTracking: true, CurrentPopup: VisualPopupQATOverflow popupOverflow }
                )
            {
                // Grab the list of key tips from the popup group
                Ribbon.KeyTipMode = KeyTipMode.PopupQATOverflow;
                var keyTipList = new KeyTipInfoList();
                keyTipList.AddRange(popupOverflow.ViewQATContents.GetQATKeyTips(null));

                // Update key tips with those appropriate for this tab
                Ribbon.SetKeyTips(keyTipList, KeyTipMode.PopupQATOverflow);
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Set the correct visual state of the target.
        /// </summary>
        protected override void UpdateTargetState()
        {
            if (_hasFocus && !IsFixed)
            {
                if (Target.ElementState != PaletteState.Tracking)
                {
                    // Update target to reflect new state
                    Target.ElementState = PaletteState.Tracking;

                    // Redraw to show the change in visual state
                    OnNeedPaint(false, Target.ClientRectangle);
                }
            }
            else
            {
                base.UpdateTargetState();
            }
        }
        #endregion

        #region Implementation
        private void KeyDownRibbon(KeyEventArgs e)
        {
            ViewBase newView = null;

            switch (e.KeyData)
            {
                case Keys.Tab:
                case Keys.Right:
                    // Ask the ribbon to get use the next view for the qat
                    newView = Ribbon.GetNextQATView(Target, e.KeyData == Keys.Tab);
                    break;
                case Keys.Tab | Keys.Shift:
                case Keys.Left:
                    // Ask the ribbon to get use the previous view for the qat
                    newView = Ribbon.GetPreviousQATView(Target);
                    break;
                case Keys.Down:
                case Keys.Space:
                case Keys.Enter:
                    // Change to a fixed pressed appearance
                    SetFixed();
                    UpdateTargetState();

                    // Generate a click event
                    OnClick(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

                    // Get access to the popup for the group
                    if (VisualPopupManager.Singleton is { IsShowingCMS: false, CurrentPopup: VisualPopupQATOverflow popupOverflow }
                        )
                    {
                        popupOverflow.SetFirstFocusItem();
                    }
                    break;
            }

            // If we have a new view to focus and it is not ourself...
            if ((newView != null) && (newView != Target))
            {
                // If the new view is a tab then select that tab
                if (!Ribbon.RealMinimizedMode && (newView is ViewDrawRibbonTab tab))
                {
                    Ribbon.SelectedTab = tab.RibbonTab;
                }

                // Finally we switch focus to new view
                Ribbon.FocusView = newView;
            }
        }

        private void KeyDownPopupOverflow(VisualPopupQATOverflow c, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Tab:
                case Keys.Right:
                    // Ask the popup to move to the next focus item
                    c.SetNextFocusItem();
                    break;
                case Keys.Tab | Keys.Shift:
                case Keys.Left:
                    // Ask the popup to move to the previous focus item
                    c.SetPreviousFocusItem();
                    break;
                case Keys.Space:
                case Keys.Enter:
                    // Change to a fixed pressed appearance
                    SetFixed();
                    UpdateTargetState();

                    // Generate a click event
                    OnClick(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

                    // Get access to the popup for the group
                    if (VisualPopupManager.Singleton is { IsShowingCMS: false, CurrentPopup: VisualPopupQATOverflow popupOverflow }
                        )
                    {
                        popupOverflow.SetFirstFocusItem();
                    }
                    break;
            }
        }
        #endregion
    }
}
