﻿namespace Krypton.Toolkit
{
    /// <summary>
    /// Storage for palette header group states.
    /// </summary>
    public class KryptonPaletteHeaderGroup : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteHeaderGroup class.
        /// </summary>
        /// <param name="redirect">inheritance redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KryptonPaletteHeaderGroup(PaletteRedirect redirect,
                                         NeedPaintHandler needPaint)
        {
            Debug.Assert(redirect != null);
            
            // Create the storage objects
            StateCommon = new KryptonPaletteHeaderGroupState(redirect, needPaint);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => StateCommon.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase() => StateCommon.PopulateFromBase();

        #endregion

        #region StateCommon
        /// <summary>
        /// Gets access to the common header group appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category(@"Visuals")]
        [Description(@"Overrides for defining common header group appearance entries.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteHeaderGroupState StateCommon { get; }

        private bool ShouldSerializeStateCommon() => !StateCommon.IsDefault;

        #endregion
    }
}
