﻿#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2024 - 2025. All rights reserved.
 *
 */
#endregion

using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    internal partial class VisualToastNotificationComboBoxUserInputRtlAwareForm : VisualToastNotificationBaseForm
    {
        #region Instance Fields

        private int _time;

        private Timer _timer;

        private readonly KryptonUserInputToastNotificationData _data;

        #endregion

        #region Internal

        internal string UserResponse => kcmbUserInput.Text ?? string.Empty;

        #endregion

        #region Identity

        public VisualToastNotificationComboBoxUserInputRtlAwareForm(KryptonUserInputToastNotificationData data)
        {
            InitializeComponent();

            _data = data;

            GotFocus += (sender, args) => kcmbUserInput.Focus();

            UpdateBorderColors();
        }

        #endregion

        #region Implementation

        private void UpdateBorderColors()
        {
            StateCommon!.Border.Color1 = _data.BorderColor1 ?? GlobalStaticValues.EMPTY_COLOR;

            StateCommon!.Border.Color2 = _data.BorderColor2 ?? GlobalStaticValues.EMPTY_COLOR;
        }

        private void UpdateText()
        {
            //kwlNotificationTitle.Text = _data.NotificationTitle ?? GlobalStaticValues.DEFAULT_EMPTY_STRING;

            //kwlNotificationMessage.Text = _data.NotificationContent ?? GlobalStaticValues.DEFAULT_EMPTY_STRING;
        }

        private void UpdateComboBoxItems()
        {
            if (_data.UserInputList.Count > 0)
            {
                foreach (var item in _data.UserInputList)
                {
                    kcmbUserInput.Items.Add(item);
                }

                kcmbUserInput.SelectedIndex = _data.SelectedIndex ?? 1;
            }

            kcmbUserInput.DropDownStyle = _data.UserInputComboBoxStyle ?? ComboBoxStyle.DropDown;
        }

        private void itbDismiss_Click(object sender, EventArgs e) => Close();

        private void VisualToastNotificationComboBoxUserInputRtlAwareForm_Load(object sender, EventArgs e)
        {
            CommonToastNotificationFunctions.UpdateUserInputToastIcon(pbxNotificationIcon);

            CommonToastNotificationFunctions.UpdateLocation(this);

            CommonToastNotificationFunctions.ShowCloseButton(this);

            _timer.Start();
        }

        private void VisualToastNotificationComboBoxUserInputRtlAwareForm_LocationChanged(object sender, EventArgs e)
        {
            if (_data.ReportToastLocation)
            {
                ReportToastLocation();
            }
        }

        private void VisualToastNotificationComboBoxUserInputRtlAwareForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ReportToastLocation() => klblToastLocation.Text =
            _data.ReportToastLocation ? $"Location: X: {Location.X}, Y: {Location.Y}" : string.Empty;

        public new DialogResult ShowDialog()
        {
            TopMost = _data.TopMost ?? true;

            UpdateText();

            CommonToastNotificationFunctions.UpdateUserInputToastIcon(pbxNotificationIcon);

            UpdateComboBoxItems();

            CommonToastNotificationFunctions.UpdateLocation(this);

            if (_data.CountDownSeconds != 0)
            {
                kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                itbDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                _timer = new Timer();

                _timer.Interval = _data.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                    itbDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                    if (_time == _data.CountDownSeconds)
                    {
                        _timer.Stop();

                        Close();
                    }
                };
            }

            return base.ShowDialog();
        }

        public new DialogResult ShowDialog(IWin32Window owner)
        {
            TopMost = _data.TopMost ?? true;

            UpdateText();

            CommonToastNotificationFunctions.UpdateUserInputToastIcon(pbxNotificationIcon);

            UpdateComboBoxItems();

            if (_data.CountDownSeconds != 0)
            {
                kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                itbDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                _timer = new Timer();

                _timer.Interval = _data.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                    itbDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss} ({_data.CountDownSeconds - _time})";

                    if (_time == _data.CountDownSeconds)
                    {
                        _timer.Stop();

                        Close();
                    }
                };
            }

            return base.ShowDialog(owner);
        }

        public new KryptonToastNotificationResult ShowToastNotificationResult()
        {

            return base.ShowToastNotificationResult();
        }

        public new KryptonToastNotificationResult ShowToastNotificationResult(IWin32Window owner)
        {

            return base.ShowToastNotificationResult(owner);
        }

        internal static string ShowNotification(KryptonUserInputToastNotificationData data)
        {
            var owner = data.ToastHost ?? FromHandle(PI.GetActiveWindow());

            using var toast = new VisualToastNotificationComboBoxUserInputRtlAwareForm(data);

            if (owner != null)
            {
                toast.StartPosition = owner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;

                return toast.ShowDialog(owner!) == DialogResult.OK ? toast.UserResponse : string.Empty;
            }
            else
            {
                return toast.ShowDialog() == DialogResult.OK ? toast.UserResponse : string.Empty;
            }
        }

        #endregion
    }
}
