﻿#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2024 - 2024. All rights reserved.
 *
 */
#endregion

using Timer = System.Windows.Forms.Timer;

namespace Krypton.Toolkit
{
    internal partial class VisualToastNotificationComboBoxUserInputRtlAwareForm : KryptonForm
    {
        public VisualToastNotificationComboBoxUserInputRtlAwareForm()
        {
            InitializeComponent();
        }

        internal static string ShowNotification(KryptonUserInputToastNotificationData data)
        {
            throw new NotImplementedException();
        }
    }
}