namespace TestForm
{
    partial class ScrollBarsTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.knudHorizontalValue = new Krypton.Toolkit.KryptonNumericUpDown();
            this.knudVerticalValue = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ksbHorizontal = new Krypton.Toolkit.KryptonScrollBar();
            this.ksbVertical = new Krypton.Toolkit.KryptonScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.knudHorizontalValue);
            this.kryptonPanel1.Controls.Add(this.knudVerticalValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.ksbHorizontal);
            this.kryptonPanel1.Controls.Add(this.ksbVertical);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(516, 345);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // knudHorizontalValue
            // 
            this.knudHorizontalValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudHorizontalValue.Location = new System.Drawing.Point(172, 104);
            this.knudHorizontalValue.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudHorizontalValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontalValue.Name = "knudHorizontalValue";
            this.knudHorizontalValue.Size = new System.Drawing.Size(120, 22);
            this.knudHorizontalValue.TabIndex = 5;
            this.knudHorizontalValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontalValue.ValueChanged += new System.EventHandler(this.knudHorizontalValue_ValueChanged);
            // 
            // knudVerticalValue
            // 
            this.knudVerticalValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudVerticalValue.Location = new System.Drawing.Point(155, 59);
            this.knudVerticalValue.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudVerticalValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudVerticalValue.Name = "knudVerticalValue";
            this.knudVerticalValue.Size = new System.Drawing.Size(120, 22);
            this.knudVerticalValue.TabIndex = 4;
            this.knudVerticalValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudVerticalValue.ValueChanged += new System.EventHandler(this.knudVerticalValue_ValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(54, 104);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(111, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Horizontal Value:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(54, 59);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Vertical Value:";
            // 
            // ksbHorizontal
            // 
            this.ksbHorizontal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(140)))), ((int)(((byte)(201)))));
            this.ksbHorizontal.DisabledBorderColor = System.Drawing.Color.Gray;
            this.ksbHorizontal.Location = new System.Drawing.Point(38, 13);
            this.ksbHorizontal.Name = "ksbHorizontal";
            this.ksbHorizontal.Opacity = 1D;
            this.ksbHorizontal.Orientation = Krypton.Toolkit.ScrollBarOrientation.Horizontal;
            this.ksbHorizontal.ScrollBarWidth = 464;
            this.ksbHorizontal.Size = new System.Drawing.Size(464, 20);
            this.ksbHorizontal.TabIndex = 1;
            this.ksbHorizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ksbHorizontal_Scroll);
            // 
            // ksbVertical
            // 
            this.ksbVertical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(140)))), ((int)(((byte)(201)))));
            this.ksbVertical.DisabledBorderColor = System.Drawing.Color.Gray;
            this.ksbVertical.Location = new System.Drawing.Point(12, 12);
            this.ksbVertical.Name = "ksbVertical";
            this.ksbVertical.Opacity = 1D;
            this.ksbVertical.ScrollBarWidth = 20;
            this.ksbVertical.Size = new System.Drawing.Size(20, 339);
            this.ksbVertical.TabIndex = 0;
            this.ksbVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ksbVertical_Scroll);
            // 
            // ScrollBarsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 345);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ScrollBarsTest";
            this.Text = "ScrollBarsTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonPanel kryptonPanel1;
        private KryptonScrollBar ksbVertical;
        private KryptonScrollBar ksbHorizontal;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel kryptonLabel2;
        private KryptonNumericUpDown knudVerticalValue;
        private KryptonNumericUpDown knudHorizontalValue;
    }
}