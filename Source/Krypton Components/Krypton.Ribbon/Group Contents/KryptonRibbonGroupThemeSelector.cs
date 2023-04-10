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
    /// Represents a ribbon group combo box.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(KryptonRibbonGroupComboBox), "ToolboxBitmaps.KryptonRibbonGroupComboBox.bmp")]
    [Designer(typeof(KryptonRibbonGroupComboBoxDesigner))]
    [DesignerCategory(@"code")]
    [DesignTimeVisible(false)]
    [DefaultEvent(@"SelectedTextChanged")]
    [DefaultProperty(nameof(Text))]
    public class KryptonRibbonGroupThemeSelector : KryptonRibbonGroupComboBox
    {
        #region Instance Fields

        private readonly string[] _themeArray = new[]
        {
            @"Professional - System",

            @"Professional - Office 2003",

            @"Office 2007 - Black",

            @"Office 2007 - Black (Dark Mode)",

            //@"Office 2007 - Black (Light Mode)",

            @"Office 2007 - Blue",

            @"Office 2007 - Blue (Dark Mode)",

            @"Office 2007 - Blue (Light Mode)",

            @"Office 2007 - Silver",

            @"Office 2007 - Silver (Dark Mode)",

            @"Office 2007 - Silver (Light Mode)",

            @"Office 2010 - Black",

            @"Office 2010 - Black (Dark Mode)",

            //@"Office 2010 - Black (Light Mode)",

            @"Office 2010 - Blue",

            @"Office 2010 - Blue (Dark Mode)",

            @"Office 2010 - Blue (Light Mode)",

            @"Office 2010 - Silver",

            @"Office 2010 - Silver (Dark Mode)",

            @"Office 2010 - Silver (Light Mode)",

            @"Office 2010 - White",

            @"Office 2013",

            @"Microsoft 365 - Black",

            @"Microsoft 365 - Black (Dark Mode)",

            //@"Microsoft 365 - Black (Light Mode)",

            @"Microsoft 365 - Blue",

            @"Microsoft 365 - Blue (Dark Mode)",

            @"Microsoft 365 - Blue (Light Mode)",

            @"Microsoft 365 - Silver",

            @"Microsoft 365 - Silver (Dark Mode)",

            @"Microsoft 365 - Silver (Light Mode)",

            @"Microsoft 365 - White",

            @"Sparkle - Blue",

            @"Sparkle - Blue (Dark Mode)",

            @"Sparkle - Blue (Light Mode)",

            @"Sparkle - Orange",

            @"Sparkle - Orange (Dark Mode)",

            @"Sparkle - Orange (Light Mode)",

            @"Sparkle - Purple",

            @"Sparkle - Purple (Dark Mode)",

            @"Sparkle - Purple (Light Mode)",

            @"Custom"
        };

        #endregion

        #region Identity

        public KryptonRibbonGroupThemeSelector()
        {
            foreach (var theme in _themeArray)
            {
                Items.Add(theme);
            }
        }
        #endregion
    }
}
