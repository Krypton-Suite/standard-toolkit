﻿namespace Krypton.Toolkit
{
    partial class VisualToastNotificationBasicWithProgressBarForm
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
            this.kpnlMain = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kpbCountDown = new Krypton.Toolkit.KryptonProgressBar();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kpnlFooter = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kbtnDismiss = new Krypton.Toolkit.KryptonButton();
            this.klblToastLocation = new Krypton.Toolkit.KryptonLabel();
            this.kchkDoNotShowAgain = new Krypton.Toolkit.KryptonCheckBox();
            this.itbDismiss = new Krypton.Toolkit.InternalToastButton();
            this.klblHeader = new Krypton.Toolkit.KryptonLabel();
            this.krtbNotificationContentText = new Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).BeginInit();
            this.kpnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlFooter)).BeginInit();
            this.kpnlFooter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlMain
            // 
            this.kpnlMain.Controls.Add(this.tableLayoutPanel1);
            this.kpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlMain.Location = new System.Drawing.Point(0, 0);
            this.kpnlMain.Name = "kpnlMain";
            this.kpnlMain.Size = new System.Drawing.Size(601, 242);
            this.kpnlMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.krtbNotificationContentText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.klblHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kpbCountDown, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbxImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kpbCountDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kpbCountDown, 2);
            this.kpbCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpbCountDown.Location = new System.Drawing.Point(3, 213);
            this.kpbCountDown.Name = "kpbCountDown";
            this.kpbCountDown.Size = new System.Drawing.Size(595, 26);
            this.kpbCountDown.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kpbCountDown.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kpbCountDown.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kpbCountDown.TabIndex = 0;
            this.kpbCountDown.Text = "kryptonProgressBar1";
            this.kpbCountDown.Values.Text = "kryptonProgressBar1";
            // 
            // pbxImage
            // 
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(5, 5);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbxImage.Name = "pbxImage";
            this.tableLayoutPanel1.SetRowSpan(this.pbxImage, 2);
            this.pbxImage.Size = new System.Drawing.Size(128, 200);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxImage.TabIndex = 1;
            this.pbxImage.TabStop = false;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(601, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kpnlFooter
            // 
            this.kpnlFooter.Controls.Add(this.tableLayoutPanel2);
            this.kpnlFooter.Controls.Add(this.kryptonBorderEdge1);
            this.kpnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlFooter.Location = new System.Drawing.Point(0, 242);
            this.kpnlFooter.Name = "kpnlFooter";
            this.kpnlFooter.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kpnlFooter.Size = new System.Drawing.Size(601, 50);
            this.kpnlFooter.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.kbtnDismiss, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.klblToastLocation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kchkDoNotShowAgain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.itbDismiss, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 49);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // kbtnDismiss
            // 
            this.kbtnDismiss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kbtnDismiss.AutoSize = true;
            this.kbtnDismiss.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnDismiss.Location = new System.Drawing.Point(525, 13);
            this.kbtnDismiss.Margin = new System.Windows.Forms.Padding(10);
            this.kbtnDismiss.Name = "kbtnDismiss";
            this.kbtnDismiss.Size = new System.Drawing.Size(23, 22);
            this.kbtnDismiss.TabIndex = 2;
            this.kbtnDismiss.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnDismiss.Values.Text = "{0}";
            this.kbtnDismiss.Visible = false;
            // 
            // klblToastLocation
            // 
            this.klblToastLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.klblToastLocation.Location = new System.Drawing.Point(75, 23);
            this.klblToastLocation.Margin = new System.Windows.Forms.Padding(10);
            this.klblToastLocation.Name = "klblToastLocation";
            this.klblToastLocation.Size = new System.Drawing.Size(6, 2);
            this.klblToastLocation.TabIndex = 3;
            this.klblToastLocation.Values.Text = "";
            // 
            // kchkDoNotShowAgain
            // 
            this.kchkDoNotShowAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kchkDoNotShowAgain.Location = new System.Drawing.Point(10, 10);
            this.kchkDoNotShowAgain.Margin = new System.Windows.Forms.Padding(10);
            this.kchkDoNotShowAgain.Name = "kchkDoNotShowAgain";
            this.kchkDoNotShowAgain.Size = new System.Drawing.Size(45, 29);
            this.kchkDoNotShowAgain.TabIndex = 4;
            this.kchkDoNotShowAgain.Values.Text = "CB1";
            this.kchkDoNotShowAgain.Visible = false;
            // 
            // itbDismiss
            // 
            this.itbDismiss.AutoSize = true;
            this.itbDismiss.Location = new System.Drawing.Point(568, 13);
            this.itbDismiss.Margin = new System.Windows.Forms.Padding(10);
            this.itbDismiss.Name = "itbDismiss";
            this.itbDismiss.Size = new System.Drawing.Size(23, 22);
            this.itbDismiss.TabIndex = 5;
            this.itbDismiss.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.itbDismiss.Values.Text = "{0}";
            this.itbDismiss.Click += new System.EventHandler(this.itbDismiss_Click);
            // 
            // klblHeader
            // 
            this.klblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblHeader.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.klblHeader.Location = new System.Drawing.Point(143, 5);
            this.klblHeader.Margin = new System.Windows.Forms.Padding(5);
            this.klblHeader.Name = "klblHeader";
            this.klblHeader.Size = new System.Drawing.Size(453, 29);
            this.klblHeader.TabIndex = 4;
            this.klblHeader.Values.Text = "kryptonLabel1";
            // 
            // krtbNotificationContentText
            // 
            this.krtbNotificationContentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbNotificationContentText.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.krtbNotificationContentText.Location = new System.Drawing.Point(143, 44);
            this.krtbNotificationContentText.Margin = new System.Windows.Forms.Padding(5);
            this.krtbNotificationContentText.Name = "krtbNotificationContentText";
            this.krtbNotificationContentText.ReadOnly = true;
            this.krtbNotificationContentText.Size = new System.Drawing.Size(453, 161);
            this.krtbNotificationContentText.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.krtbNotificationContentText.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.krtbNotificationContentText.TabIndex = 5;
            this.krtbNotificationContentText.Text = "kryptonRichTextBox1";
            // 
            // VisualToastNotificationBasicWithProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 292);
            this.Controls.Add(this.kpnlMain);
            this.Controls.Add(this.kpnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualToastNotificationBasicWithProgressBarForm";
            this.NotificationResult = Krypton.Toolkit.KryptonToastNotificationResult.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Inherit;
            this.Load += new System.EventHandler(this.VisualToastNotificationBasicWithProgressBarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).EndInit();
            this.kpnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlFooter)).EndInit();
            this.kpnlFooter.ResumeLayout(false);
            this.kpnlFooter.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private KryptonPanel kpnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private KryptonProgressBar kpbCountDown;
        private PictureBox pbxImage;
        private KryptonBorderEdge kryptonBorderEdge1;
        private KryptonPanel kpnlFooter;
        private TableLayoutPanel tableLayoutPanel2;
        private KryptonButton kbtnDismiss;
        private KryptonLabel klblToastLocation;
        private KryptonCheckBox kchkDoNotShowAgain;
        private InternalToastButton itbDismiss;
        private KryptonLabel klblHeader;
        private KryptonRichTextBox krtbNotificationContentText;
    }
}