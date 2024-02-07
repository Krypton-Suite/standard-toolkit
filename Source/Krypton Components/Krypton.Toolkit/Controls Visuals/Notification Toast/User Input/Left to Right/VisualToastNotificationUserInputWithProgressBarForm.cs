﻿#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2024 - 2024. All rights reserved.
 *
 */
#endregion

using ContentAlignment = System.Drawing.ContentAlignment;
using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    internal partial class VisualToastNotificationUserInputWithProgressBarForm : KryptonForm
    {
        #region Instance Fields

        private int _time;

        private Timer _timer;

        private SoundPlayer? _soundPlayer;

        private string _userResponse;

        private PaletteBase _palette;

        private readonly KryptonUserInputToastNotificationData _toastNotificationData;

        #endregion

        #region Identity

        public VisualToastNotificationUserInputWithProgressBarForm(KryptonUserInputToastNotificationData toastNotificationData)
        {
            _toastNotificationData = toastNotificationData;

            InitializeComponent();

            Resize += VisualToastNotificationUserInputWithProgressBarForm_Resize;

            GotFocus += VisualToastNotificationUserInputWithProgressBarForm_GotFocus;

            UpdateBorderColors();
        }

        #endregion

        #region Properties

        internal string UserResponse => _userResponse;

        #endregion

        #region Implementation

        private void UpdateText()
        {
            kwlNotificationContent.Text = _toastNotificationData.NotificationContent ?? string.Empty;

            kwlNotificationTitle.Text = _toastNotificationData.NotificationTitle;

            kwlNotificationTitle.TextAlign =
                _toastNotificationData.NotificationTitleAlignment ?? ContentAlignment.MiddleCenter;
        }

        private void UpdateBorderColors()
        {
            StateCommon!.Border.Color1 = _toastNotificationData.BorderColor1 ?? Color.Empty;

            StateCommon.Border.Color2 = _toastNotificationData.BorderColor2 ?? Color.Empty;
        }

        private void UpdateFadeValues() => FadeValues.FadingEnabled = _toastNotificationData.UseFade;

        private void UpdateFonts()
        {
            kwlNotificationContent.StateCommon.Font = _toastNotificationData.NotificationContentFont ??
                                            KryptonManager.CurrentGlobalPalette.BaseFont;

            if (_toastNotificationData.NotificationTitleFont != null)
            {
                kwlNotificationContent.LabelStyle = LabelStyle.NormalControl;

                kwlNotificationTitle.StateCommon.Font =
                    _toastNotificationData.NotificationTitleFont ?? _palette.Header1ShortFont;
            }
            else
            {
                kwlNotificationTitle.LabelStyle = LabelStyle.TitleControl;
            }
        }

        private void UpdateIcon()
        {
            switch (_toastNotificationData.NotificationIcon)
            {
                case KryptonToastNotificationIcon.None:
                    SetIcon(null);
                    break;
                case KryptonToastNotificationIcon.Hand:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Hand_128_x_128);
                    break;
                case KryptonToastNotificationIcon.SystemHand:
#if NET8_0_OR_GREATER
                    //SetIcon(GraphicsExtensions.ScaleImage());
#else
                    SetIcon(GraphicsExtensions.ScaleImage(SystemIcons.Hand.ToBitmap(), 128, 128));
#endif
                    break;
                case KryptonToastNotificationIcon.Question:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Question_128_x_128);
                    break;
                case KryptonToastNotificationIcon.SystemQuestion:
                    break;
                case KryptonToastNotificationIcon.Exclamation:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Warning_128_x_115);
                    break;
                case KryptonToastNotificationIcon.SystemExclamation:
                    break;
                case KryptonToastNotificationIcon.Asterisk:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Asterisk_128_x_128);
                    break;
                case KryptonToastNotificationIcon.SystemAsterisk:
                    break;
                case KryptonToastNotificationIcon.Stop:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Stop_128_x_128);
                    break;
                case KryptonToastNotificationIcon.Error:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Critical_128_x_128);
                    break;
                case KryptonToastNotificationIcon.Warning:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Warning_128_x_115);
                    break;
                case KryptonToastNotificationIcon.Information:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Information_128_x_128);
                    break;
                case KryptonToastNotificationIcon.Shield:
                    if (OSUtilities.IsWindowsEleven)
                    {
                        SetIcon(ToastNotificationImageResources.Toast_Notification_UAC_Shield_Windows_11_128_x_128);
                    }
                    else if (OSUtilities.IsWindowsTen)
                    {
                        SetIcon(ToastNotificationImageResources.Toast_Notification_UAC_Shield_Windows_10_128_x_128);
                    }
                    else
                    {
                        SetIcon(ToastNotificationImageResources.Toast_Notification_UAC_Shield_Windows_7_and_8_128_x_128);
                    }
                    break;
                case KryptonToastNotificationIcon.WindowsLogo:
                    break;
                case KryptonToastNotificationIcon.Application:
                    break;
                case KryptonToastNotificationIcon.SystemApplication:
                    break;
                case KryptonToastNotificationIcon.Ok:
                    SetIcon(ToastNotificationImageResources.Toast_Notification_Ok_128_x_128);
                    break;
                case KryptonToastNotificationIcon.Custom:
                    SetIcon(_toastNotificationData.CustomImage != null
                        ? new Bitmap(_toastNotificationData.CustomImage)
                        : null);
                    break;
                case null:
                    SetIcon(null);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void SetIcon(Bitmap? image) => pbxIcon.Image = image;

        private void UpdateLocation()
        {
            //Once loaded, position the form, or position it to the bottom left of the screen with added padding
            Location = _toastNotificationData.NotificationLocation ?? new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 5,
                Screen.PrimaryScreen.WorkingArea.Height - Height - 5);
        }

        private void UpdateUserInputArea()
        {
            ClearUserInputArea();

            switch (_toastNotificationData.NotificationInputAreaType)
            {
                case KryptonToastNotificationInputAreaType.None:
                    kpnlUserInput.Visible = false;
                    break;
                case KryptonToastNotificationInputAreaType.ComboBox:
                    kcmbUserInput.Visible = true;

                    kdudUserInput.Visible = false;

                    knudUserInput.Visible = false;

                    kmtxtUserInput.Visible = false;

                    ktxtUserInput.Visible = false;
                    break;
                case KryptonToastNotificationInputAreaType.DomainDropDown:
                    kcmbUserInput.Visible = false;

                    kdudUserInput.Visible = true;

                    knudUserInput.Visible = false;

                    kmtxtUserInput.Visible = false;

                    ktxtUserInput.Visible = false;
                    break;
                case KryptonToastNotificationInputAreaType.NumericDropDown:
                    kcmbUserInput.Visible = false;

                    kdudUserInput.Visible = false;

                    knudUserInput.Visible = true;

                    kmtxtUserInput.Visible = false;

                    ktxtUserInput.Visible = false;
                    break;
                case KryptonToastNotificationInputAreaType.MaskedTextBox:
                    kcmbUserInput.Visible = false;

                    kdudUserInput.Visible = false;

                    knudUserInput.Visible = false;

                    kmtxtUserInput.Visible = true;

                    ktxtUserInput.Visible = false;
                    break;
                case KryptonToastNotificationInputAreaType.TextBox:
                    kcmbUserInput.Visible = false;

                    kdudUserInput.Visible = false;

                    knudUserInput.Visible = false;

                    kmtxtUserInput.Visible = false;

                    ktxtUserInput.Visible = true;

                    if (!string.IsNullOrEmpty(_toastNotificationData.ToastNotificationCueText) || _toastNotificationData.ToastNotificationCueText != null)
                    {
                        ktxtUserInput.CueHint.CueHintText = _toastNotificationData.ToastNotificationCueText!;
                    }
                    break;
            }
        }

        private void ClearUserInputArea()
        {
            ktxtUserInput.Text = string.Empty;
            kdtpUserInput.Value = DateTime.Now;
            kdudUserInput.Text = string.Empty;
            kcmbUserInput.Items.Clear();
            kmtxtUserInput.Text = string.Empty;
        }

        private void ShowCloseButton()
        {
            CloseBox = _toastNotificationData.ShowCloseBox ?? false;

            FormBorderStyle = CloseBox ? FormBorderStyle.Fixed3D : FormBorderStyle.FixedSingle;

            ControlBox = _toastNotificationData.ShowCloseBox ?? false;
        }

        private void SetUserInputFocus(KryptonToastNotificationInputAreaType? inputAreaType)
        {
            switch (inputAreaType)
            {
                case KryptonToastNotificationInputAreaType.None:
                    kbtnDismiss.Focus();
                    break;
                case KryptonToastNotificationInputAreaType.ComboBox:
                    kcmbUserInput.Focus();
                    break;
                case KryptonToastNotificationInputAreaType.DomainDropDown:
                    kdudUserInput.Focus();
                    break;
                case KryptonToastNotificationInputAreaType.NumericDropDown:
                    knudUserInput.Focus();
                    break;
                case KryptonToastNotificationInputAreaType.MaskedTextBox:
                    kmtxtUserInput.Focus();
                    break;
                case KryptonToastNotificationInputAreaType.TextBox:
                    ktxtUserInput.Focus();
                    break;
                case null:
                    kbtnDismiss.Focus();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(inputAreaType), inputAreaType, null);
            }
        }

        private void VisualToastNotificationUserInputWithProgressBarForm_Load(object sender, EventArgs e)
        {
            UpdateIcon();

            UpdateUserInputArea();

            UpdateLocation();

            ShowCloseButton();

            _timer.Start();

            _soundPlayer?.Play();

            kbtnDismiss.Text = KryptonManager.Strings.KryptonToastNotificationStrings.Dismiss;
        }

        private void knudUserInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kmtxtUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void kdudUserInput_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void kdudUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void kdtpUserInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kdtpUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void kcmbUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kcmbUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisualToastNotificationUserInputWithProgressBarForm_GotFocus(object sender, EventArgs e)
        {
            SetUserInputFocus(_toastNotificationData.NotificationInputAreaType ?? KryptonToastNotificationInputAreaType.None);
        }

        private void VisualToastNotificationUserInputWithProgressBarForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void kbtnDismiss_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private new DialogResult ShowDialog()
        {
            TopMost = _toastNotificationData.TopMost ?? true;

            UpdateText();

            UpdateIcon();

            if (_toastNotificationData.CountDownSeconds != 0)
            {
                kpbCountDown.Maximum = _toastNotificationData.CountDownSeconds ?? 100;

                kpbCountDown.Value = kpbCountDown.Maximum;

                kpbCountDown.Text = $@"{_toastNotificationData.CountDownSeconds - _time}";

                _timer = new Timer();

                _timer.Interval = 1000;

                _timer.Tick += (sender, args) =>
                {
                    _time++;

                    //kpbCountDown.Increment(1);

                    kpbCountDown.Value = kpbCountDown.Value - 1;

                    kpbCountDown.Text = $@"{_toastNotificationData.CountDownSeconds - _time}";

                    if (kpbCountDown.Value == kpbCountDown.Minimum)
                    {
                        _timer.Stop();

                        Close();

                        DialogResult = DialogResult.Cancel;
                    }
                };
            }

            return base.ShowDialog();
        }

        internal static string InternalShow(KryptonUserInputToastNotificationData toastNotificationData)
        {
            using var toast = new VisualToastNotificationUserInputWithProgressBarForm(toastNotificationData);

            return toast.ShowDialog() == DialogResult.OK ? toast.UserResponse : string.Empty;
        }

        #endregion
    }
}