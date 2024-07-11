﻿#region Licences

/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2024 - 2024. All rights reserved.
 *
 */

//--------------------------------------------------------------------------------
// Copyright (C) 2013-2021 JDH Software - <support@jdhsoftware.com>
//
// This program is provided to you under the terms of the Microsoft Public
// License (Ms-PL) as published at https://github.com/Cocotteseb/Krypton-OutlookGrid/blob/master/LICENSE.md
//
// Visit https://www.jdhsoftware.com and follow @jdhsoftware on Twitter
//
//--------------------------------------------------------------------------------

#endregion

namespace Krypton.Toolkit
{
    /// <summary>
    /// Class for Node collapsing events
    /// </summary>
    /// <seealso cref="T:OutlookGridRowNodeCancelEventBase" />
    public class CollapsingEventArgs : OutlookGridRowNodeCancelEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollapsingEventArgs"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public CollapsingEventArgs(OutlookGridRow node)
            : base(node)
        {
        }
    }
}