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
    internal partial class VisualToastNotificationComboBoxUserInputWithProgressBarForm : VisualToastNotificationBaseForm
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

        public VisualToastNotificationComboBoxUserInputWithProgressBarForm(KryptonUserInputToastNotificationData data)
        {
            InitializeComponent();

            _data = data;

            GotFocus += (sender, args) => kcmbUserInput.Focus();

            Resize += VisualToastNotificationComboBoxUserInputWithProgressBarForm_Resize;

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
            klblHeader.Text = _data.NotificationTitle ?? GlobalStaticValues.DEFAULT_EMPTY_STRING;

            krtbNotificationContentText.Text = _data.NotificationContent ?? GlobalStaticValues.DEFAULT_EMPTY_STRING;
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

        private void VisualToastNotificationComboBoxUserInputWithProgressBarForm_Resize(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void VisualToastNotificationComboBoxUserInputWithProgressBarForm_Load(object sender, EventArgs e)
        {
            CommonToastNotificationFunctions.UpdateUserInputToastIcon(pbxNotificationIcon);

            CommonToastNotificationFunctions.UpdateLocation(this);

            CommonToastNotificationFunctions.ShowCloseButton(this);

            kbtnDismiss.Text = KryptonManager.Strings.ToastNotificationStrings.Dismiss;

            _timer.Start();

            _data.DisplayDebugData(_data);
        }

        public new DialogResult ShowDialog()
        {
            TopMost = _data.TopMost ?? true;

            UpdateText();

            CommonToastNotificationFunctions.UpdateUserInputToastIcon(pbxNotificationIcon);

            UpdateComboBoxItems();

            CommonToastNotificationFunctions.UpdateLocation(this);

            if (_data.CountDownSeconds != 0)
            {
                kpbCountDown.Maximum = _data.CountDownSeconds ?? 100;

                kpbCountDown.Value = kpbCountDown.Maximum;

                kpbCountDown.Text = $@"{_data.CountDownSeconds - _time}";

                _timer = new Timer();

                _timer.Interval = _data.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kpbCountDown.Value -= 1;

                    kpbCountDown.Text = $@"{_data.CountDownSeconds - _time}";

                    if (kpbCountDown.Value == kpbCountDown.Minimum)
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
                kpbCountDown.Maximum = _data.CountDownSeconds ?? 100;

                kpbCountDown.Value = kpbCountDown.Maximum;

                kpbCountDown.Text = $@"{_data.CountDownSeconds - _time}";

                _timer = new Timer();

                _timer.Interval = _data.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kpbCountDown.Value -= 1;

                    kpbCountDown.Text = $@"{_data.CountDownSeconds - _time}";

                    if (kpbCountDown.Value == kpbCountDown.Minimum)
                    {
                        _timer.Stop();

                        Close();
                    }
                };
            }

            return base.ShowDialog(owner);
        }

        internal static string ShowNotification(KryptonUserInputToastNotificationData data)
        {
            var owner = data.ToastHost ?? FromHandle(PI.GetActiveWindow());

            using var toast = new VisualToastNotificationComboBoxUserInputWithProgressBarForm(data);

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
