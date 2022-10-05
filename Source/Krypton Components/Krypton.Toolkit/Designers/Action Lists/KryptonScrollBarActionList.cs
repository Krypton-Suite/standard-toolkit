﻿namespace Krypton.Toolkit
{
    internal class KryptonScrollBarActionList : DesignerActionList
    {
        #region Instance Fields

        private readonly KryptonScrollBar _scrollBar;

        private readonly IComponentChangeService _service;

        #endregion

        #region Identity

        public KryptonScrollBarActionList(KryptonScrollBarDesigner owner) : base(owner.Component)
        {
            _scrollBar = owner.Component as KryptonScrollBar;

            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }

        #endregion

        #region Public

        public int Maximum
        {
            get => _scrollBar.Maximum;

            set
            {
                if (_scrollBar.Maximum != value)
                {
                    _service.OnComponentChanged(_scrollBar, null, _scrollBar.Maximum, value);

                    _scrollBar.Maximum = value;
                }
            }
        }

        public int Minimum
        {
            get => _scrollBar.Minimum;

            set
            {
                if (_scrollBar.Minimum != value)
                {
                    _service.OnComponentChanged(_scrollBar, null, _scrollBar.Minimum, value);

                    _scrollBar.Minimum = value;
                }
            }
        }

        public int Value
        {
            get => _scrollBar.Value;

            set
            {
                if (_scrollBar.Value != value)
                {
                    _service.OnComponentChanged(_scrollBar, null, _scrollBar.Value, value);

                    _scrollBar.Value = value;
                }
            }
        }

        /// <summary>Gets or sets the orientation of the scrollbar.</summary>
        /// <value>The orientation.</value>
        public ScrollBarOrientation Orientation
        {
            get => _scrollBar.Orientation;

            set
            {
                if (_scrollBar.Orientation != value)
                {
                    _service.OnComponentChanged(_scrollBar, null, _scrollBar.Orientation, value);

                    _scrollBar.Orientation = value;
                }
            }
        }
        #endregion

        #region Public Override

        /// <summary>Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem">DesignerActionItem</see> objects contained in the list.</summary>
        /// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem">DesignerActionItem</see> array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection actions = new();

            if (_scrollBar != null)
            {
                actions.Add(new DesignerActionHeaderItem(@"Appearance"));
                actions.Add(new DesignerActionPropertyItem(@"Orientation", @"Orientation", @"Appearance", @"The appearance of the scrollbar."));
                actions.Add(new DesignerActionHeaderItem(@"Values"));
                actions.Add(new DesignerActionPropertyItem(@"Maximum", @"Maximum", @"Values", @"The maximum value that the scrollbar can accept."));
                actions.Add(new DesignerActionPropertyItem(@"Minimum", @"Minimum", @"Values", @"The minimum value that the scrollbar can accept."));
                actions.Add(new DesignerActionPropertyItem(@"Value", @"Value", @"Values", @"The current value of the scrollbar."));

            }

            return actions;
        }

        #endregion
    }
}