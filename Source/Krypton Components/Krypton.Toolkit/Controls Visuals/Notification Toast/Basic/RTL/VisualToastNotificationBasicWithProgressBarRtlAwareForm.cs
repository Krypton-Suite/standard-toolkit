﻿#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac et al. 2024 - 2025. All rights reserved.
 *
 */
#endregion

using ContentAlignment = System.Drawing.ContentAlignment;
using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    internal partial class VisualToastNotificationBasicWithProgressBarRtlAwareForm : VisualToastNotificationBaseForm
    {
        #region Instance Fields

        private int _time, _countdownValue;

        private Timer _timer;

        private SoundPlayer? _soundPlayer;

        private PaletteBase _palette;

        private readonly KryptonBasicToastNotificationData _basicToastNotificationData;

        #endregion

        #region Public

        internal bool ReturnValue => kchkDoNotShowAgain.Checked;

        internal CheckState ReturnCheckBoxStateValue => kchkDoNotShowAgain.CheckState;

        #endregion

        #region Identity

        public VisualToastNotificationBasicWithProgressBarRtlAwareForm(KryptonBasicToastNotificationData data)
        {
            InitializeComponent();

            _basicToastNotificationData = data;

            GotFocus += (sender, args) => kbtnDismiss.Focus();

            LocationChanged += VisualToastNotificationBasicWithProgressBarRtlAwareForm_LocationChanged;

            Resize += VisualToastNotificationBasicWithProgressBarRtlAwareForm_Resize;

            DoubleBuffered = true;

            UpdateBorderColors();

            /* FadeValues disabled and moved to extended until proven stable. Further development in V100
            UpdateFadeValues();
            */

            UpdateFonts();
        }

        #endregion

        #region Implementation

        private void UpdateText()
        {
            kwlblNotificationContent.Text = _basicToastNotificationData.NotificationContent ?? string.Empty;

            kwlblNotificationTitle.Text = _basicToastNotificationData.NotificationTitle;

            kwlblNotificationTitle.TextAlign =
                _basicToastNotificationData.NotificationTitleAlignment ?? ContentAlignment.MiddleCenter;
        }

        private void UpdateBorderColors()
        {
            StateCommon!.Border.Color1 = _basicToastNotificationData.BorderColor1 ?? GlobalStaticValues.EMPTY_COLOR;

            StateCommon.Border.Color2 = _basicToastNotificationData.BorderColor2 ?? GlobalStaticValues.EMPTY_COLOR;
        }

        /* FadeValues disabled and moved to extended until proven stable. Further development in V100
        private void UpdateFadeValues() => FadeValues.FadingEnabled = _basicToastNotificationData.UseFade;
        */

        private void UpdateFonts()
        {
            kwlblNotificationContent.StateCommon.Font = _basicToastNotificationData.NotificationContentFont ??
                                            KryptonManager.CurrentGlobalPalette.BaseFont;

            if (_basicToastNotificationData.NotificationTitleFont != null)
            {
                kwlblNotificationContent.LabelStyle = LabelStyle.NormalControl;

                kwlblNotificationTitle.StateCommon.Font =
                    _basicToastNotificationData.NotificationTitleFont ?? _palette.Header1ShortFont;
            }
            else
            {
                kwlblNotificationTitle.LabelStyle = LabelStyle.TitleControl;
            }
        }

        private void UpdateDoNotShowAgainOptionChecked() =>
            kchkDoNotShowAgain.Checked = _basicToastNotificationData.IsDoNotShowAgainOptionChecked;

        private void UpdateDoNotShowAgainOptionCheckState() =>
            kchkDoNotShowAgain.CheckState =
                _basicToastNotificationData.DoNotShowAgainOptionCheckState ?? CheckState.Unchecked;

        private void UpdateLocation()
        {
            //Once loaded, position the form, or position it to the bottom left of the screen with added padding
            Location = _basicToastNotificationData.NotificationLocation ?? new Point(Screen.PrimaryScreen!.WorkingArea.Width - Width - 5,
                Screen.PrimaryScreen.WorkingArea.Height - Height - 5);
        }

        private void ReportToastLocation() => klblToastLocation.Text = _basicToastNotificationData.ReportToastLocation ? $"Location: X: {Location.X}, Y: {Location.Y}" : string.Empty;

        private void ShowCloseButton()
        {
            CloseBox = _basicToastNotificationData.ShowCloseBox ?? false;

            FormBorderStyle = CloseBox ? FormBorderStyle.Fixed3D : FormBorderStyle.FixedSingle;

            ControlBox = _basicToastNotificationData.ShowCloseBox ?? false;
        }

        private void VisualToastNotificationBasicWithProgressBarRtlAwareForm_Resize(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void VisualToastNotificationBasicWithProgressBarRtlAwareForm_LocationChanged(object? sender, EventArgs e)
        {
            if (_basicToastNotificationData.ReportToastLocation)
            {
                ReportToastLocation();
            }
        }

        private void VisualToastNotificationBasicWithProgressBarRtlAwareForm_Load(object sender, EventArgs e)
        {
            UpdateLocation();

            ShowCloseButton();

            _timer.Start();

            _soundPlayer?.Play();

            kbtnDismiss.Text = KryptonManager.Strings.ToastNotificationStrings.Dismiss;

            itbDismiss.Text = KryptonManager.Strings.ToastNotificationStrings.Dismiss;
        }

        private void kbtnDismiss_Click(object sender, EventArgs e) => Close();

        private void UpdateProgressBarText() => kpbCountDown.Text = _basicToastNotificationData.ShowCountDownSecondsOnProgressBar ? $@"{_basicToastNotificationData.CountDownSeconds - _time}" : string.Empty;

        public new void Show()
        {
            TopMost = _basicToastNotificationData.TopMost ?? true;

            UpdateText();

            CommonToastNotificationFunctions.UpdateIcon(pbxImage);

            if (_basicToastNotificationData.CountDownSeconds != 0)
            {
                _countdownValue = _basicToastNotificationData.CountDownSeconds ?? 60;

                kpbCountDown.Maximum = _countdownValue;

                kpbCountDown.Value = _countdownValue;

                UpdateProgressBarText();

                _timer = new Timer();

                _timer.Interval = _basicToastNotificationData.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kpbCountDown.Value -= 1;

                    UpdateProgressBarText();

                    if (kpbCountDown.Value == kpbCountDown.Minimum)
                    {
                        _timer.Stop();

                        Close();
                    }
                };
            }


            base.Show();
        }

        public new DialogResult ShowDialog()
        {
            TopMost = _basicToastNotificationData.TopMost ?? true;

            UpdateText();

            CommonToastNotificationFunctions.UpdateIcon(pbxImage);

            if (_basicToastNotificationData.IsDoNotShowAgainOptionChecked)
            {
                UpdateDoNotShowAgainOptionChecked();
            }

            if (_basicToastNotificationData.DoNotShowAgainOptionCheckState != null)
            {
                UpdateDoNotShowAgainOptionCheckState();
            }

            if (_basicToastNotificationData.CountDownSeconds != 0)
            {
                _countdownValue = _basicToastNotificationData.CountDownSeconds ?? 60;

                kpbCountDown.Maximum = _countdownValue;

                kpbCountDown.Value = _countdownValue;

                UpdateProgressBarText();

                kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss}";

                _timer = new Timer();

                _timer.Interval = _basicToastNotificationData.CountDownTimerInterval ?? 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    kpbCountDown.Value -= 1;

                    UpdateProgressBarText();

                    kbtnDismiss.Text = $@"{KryptonManager.Strings.ToastNotificationStrings.Dismiss}";

                    if (_time == _basicToastNotificationData.CountDownSeconds)
                    {
                        _timer.Stop();

                        Close();
                    }
                };
            }

            return base.ShowDialog();
        }

        internal static bool InternalShowWithBooleanReturnValue(KryptonBasicToastNotificationData toastNotificationData)
        {
            using var toast = new VisualToastNotificationBasicWithProgressBarRtlAwareForm(toastNotificationData);

            return toast.ShowDialog() == DialogResult.OK && toast.ReturnValue;
        }

        internal static CheckState InternalShowWithCheckStateReturnValue(KryptonBasicToastNotificationData toastNotificationData)
        {
            using var toast = new VisualToastNotificationBasicWithProgressBarRtlAwareForm(toastNotificationData);

            return toast.ShowDialog() == DialogResult.OK
                ? toast.ReturnCheckBoxStateValue
                : CheckState.Unchecked;
        }

        private void itbDismiss_Click(object sender, EventArgs e) => Close();

        internal static void ShowNotification(KryptonBasicToastNotificationData toastNotificationData)
        {
            var kt = new VisualToastNotificationBasicWithProgressBarRtlAwareForm(toastNotificationData);

            kt.Show();
        }

        #endregion
    }
}