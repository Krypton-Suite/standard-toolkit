using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class ScrollBarsTest : KryptonForm
    {
        public ScrollBarsTest()
        {
            SetInheritedControlOverride();

            InitializeComponent();
        }

        private void ksbVertical_Scroll(object sender, ScrollEventArgs e)
        {
            knudVerticalValue.Value = ksbVertical.Value;
        }

        private void knudVerticalValue_ValueChanged(object sender, EventArgs e)
        {
            ksbVertical.Value = (int)knudVerticalValue.Value;
        }

        private void ksbHorizontal_Scroll(object sender, ScrollEventArgs e)
        {
            knudHorizontalValue.Value = ksbHorizontal.Value;
        }

        private void knudHorizontalValue_ValueChanged(object sender, EventArgs e)
        {
            ksbHorizontal.Value = (int)knudHorizontalValue.Value;
        }
    }
}
