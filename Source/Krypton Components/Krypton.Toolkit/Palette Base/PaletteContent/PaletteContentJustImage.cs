﻿namespace Krypton.Toolkit
{
    /// <summary>
    /// Implement storage but remove accesss to the non image properties.
    /// </summary>
    public class PaletteContentJustImage : PaletteContent
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteContentJustImage class.
        /// </summary>
        /// <param name="inherit">Source for inheriting defaulted values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteContentJustImage(IPaletteContent inherit,
                                       NeedPaintHandler needPaint)
            : base(inherit, needPaint)
        {
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public override void PopulateFromBase(PaletteState state)
        {
            // Get the values and set into storage
            Draw = GetContentDraw(state);
            Image.ImageH = GetContentImageH(state);
            Image.ImageV = GetContentImageV(state);
            Image.Effect = GetContentImageEffect(state);
            Image.ImageColorMap = GetContentImageColorMap(state);
            Image.ImageColorTo = GetContentImageColorTo(state);
            Padding = GetContentPadding(state);
        }
        #endregion

        #region DrawFocus
        /// <summary>
        /// Gets a value indicating if content should be drawn with focus indication.
        /// </summary>
        [KryptonPersist(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override InheritBool DrawFocus
        {
            get => base.DrawFocus;
            set => base.DrawFocus = value;
        }
        #endregion

        #region ShortText
        /// <summary>
        /// Gets access to the short text palette details.
        /// </summary>
        [KryptonPersist]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override PaletteContentText ShortText => base.ShortText;

        #endregion

        #region LongText
        /// <summary>
        /// Gets access to the long text palette details.
        /// </summary>
        [KryptonPersist]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override PaletteContentText LongText => base.LongText;

        #endregion

        #region AdjacentGap
        /// <summary>
        /// Gets the padding between adjacent content items.
        /// </summary>
        [KryptonPersist(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int AdjacentGap
        {
            get => base.AdjacentGap;
            set => base.AdjacentGap = value;
        }
        #endregion
    }
}
