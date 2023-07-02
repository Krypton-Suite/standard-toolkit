﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit
{
    internal class PlacementModeConverter : StringLookupConverter
    {
        #region Static Fields

        #region Old

        //private readonly Pair[] _pairs =
        //{
        //    new(PlacementMode.Absolute, "Placement Mode - Absolute"),
        //    new(PlacementMode.AbsolutePoint, "Placement Mode - Absolute Point"),
        //    new(PlacementMode.Bottom, "Placement Mode - Bottom"),
        //    new(PlacementMode.Center, "Placement Mode - Center"),
        //    new(PlacementMode.Left, "Placement Mode - Left"),
        //    new(PlacementMode.Mouse, "Placement Mode - Mouse"),
        //    new(PlacementMode.MousePoint, "Placement Mode - Mouse Point"),
        //    new(PlacementMode.Relative, "Placement Mode - Relative"),
        //    new(PlacementMode.RelativePoint, "Placement Mode - Relative Point"),
        //    new(PlacementMode.Right, "Placement Mode - Right"),
        //    new(PlacementMode.Top, "Placement Mode - Top")
        //};

        #endregion

        [Localizable(true)]
        private readonly Pair[] _pairs =
        {
            new Pair(PlacementMode.Absolute, KryptonLanguageManager.PlacementModeStrings.Absolute),
            new Pair(PlacementMode.AbsolutePoint, KryptonLanguageManager.PlacementModeStrings.AbsolutePoint),
            new Pair(PlacementMode.Bottom, KryptonLanguageManager.PlacementModeStrings.Bottom),
            new Pair(PlacementMode.Center, KryptonLanguageManager.PlacementModeStrings.Center),
            new Pair(PlacementMode.Left, KryptonLanguageManager.PlacementModeStrings.Left),
            new Pair(PlacementMode.Mouse, KryptonLanguageManager.PlacementModeStrings.Mouse),
            new Pair(PlacementMode.MousePoint, KryptonLanguageManager.PlacementModeStrings.MousePoint),
            new Pair(PlacementMode.Relative, KryptonLanguageManager.PlacementModeStrings.Relative),
            new Pair(PlacementMode.RelativePoint, KryptonLanguageManager.PlacementModeStrings.RelativePoint),
            new Pair(PlacementMode.Right, KryptonLanguageManager.PlacementModeStrings.Right),
            new Pair(PlacementMode.Top, KryptonLanguageManager.PlacementModeStrings.Top)
        };

        #endregion

        #region Identity

        public PlacementModeConverter() : base(typeof(PlacementMode))
        {
        }

        #endregion

        #region Protected

        protected override Pair[] Pairs => _pairs;

        #endregion
    }
}
