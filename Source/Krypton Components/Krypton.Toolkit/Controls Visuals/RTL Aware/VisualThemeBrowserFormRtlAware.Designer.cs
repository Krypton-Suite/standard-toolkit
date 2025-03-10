﻿namespace Krypton.Toolkit
{
    partial class VisualThemeBrowserFormRtlAware
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kbtnImport = new Krypton.Toolkit.KryptonButton();
            this.kchkSilent = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.klblHeader = new Krypton.Toolkit.KryptonLabel();
            this.klbThemeList = new Krypton.Toolkit.KryptonListBox();
            this.kcpbCustom = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 481);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonPanel1.Size = new System.Drawing.Size(836, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.kbtnImport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kchkSilent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kbtnCancel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.kbtnOk, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 49);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // kbtnImport
            // 
            this.kbtnImport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kbtnImport.Location = new System.Drawing.Point(736, 12);
            this.kbtnImport.Margin = new System.Windows.Forms.Padding(10);
            this.kbtnImport.Name = "kbtnImport";
            this.kbtnImport.Size = new System.Drawing.Size(90, 25);
            this.kbtnImport.TabIndex = 0;
            this.kbtnImport.Values.Text = "kryptonButton1";
            this.kbtnImport.Click += new System.EventHandler(this.kbtnImport_Click);
            // 
            // kchkSilent
            // 
            this.kchkSilent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kchkSilent.Location = new System.Drawing.Point(591, 14);
            this.kchkSilent.Margin = new System.Windows.Forms.Padding(10);
            this.kchkSilent.Name = "kchkSilent";
            this.kchkSilent.Size = new System.Drawing.Size(125, 20);
            this.kchkSilent.TabIndex = 1;
            this.kchkSilent.Values.Text = "kryptonCheckBox1";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(10, 12);
            this.kbtnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.TabIndex = 2;
            this.kbtnCancel.Values.Text = "kryptonButton1";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(120, 12);
            this.kbtnOk.Margin = new System.Windows.Forms.Padding(10);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.TabIndex = 3;
            this.kbtnOk.Values.Text = "kryptonButton2";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderSecondary;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(836, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(836, 481);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.klblHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.klbThemeList, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 481);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // klblHeader
            // 
            this.klblHeader.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.klblHeader.Location = new System.Drawing.Point(731, 10);
            this.klblHeader.Margin = new System.Windows.Forms.Padding(10);
            this.klblHeader.Name = "klblHeader";
            this.klblHeader.Size = new System.Drawing.Size(95, 20);
            this.klblHeader.TabIndex = 0;
            this.klblHeader.Values.Text = "kryptonLabel1";
            // 
            // klbThemeList
            // 
            this.klbThemeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klbThemeList.Location = new System.Drawing.Point(10, 50);
            this.klbThemeList.Margin = new System.Windows.Forms.Padding(10);
            this.klbThemeList.Name = "klbThemeList";
            this.klbThemeList.Size = new System.Drawing.Size(816, 421);
            this.klbThemeList.TabIndex = 1;
            this.klbThemeList.SelectedIndexChanged += new System.EventHandler(this.klbThemeList_SelectedIndexChanged);
            // 
            // kcpbCustom
            // 
            this.kcpbCustom.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.kcpbCustom.Ribbon.RibbonAppButton.StateNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.kcpbCustom.Ribbon.RibbonAppButton.StatePressed.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(196)))));
            this.kcpbCustom.Ribbon.RibbonAppButton.StatePressed.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StatePressed.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StatePressed.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StatePressed.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(136)))), ((int)(((byte)(9)))));
            this.kcpbCustom.Ribbon.RibbonAppButton.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(230)))));
            this.kcpbCustom.Ribbon.RibbonAppButton.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppButton.StateTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(201)))), ((int)(((byte)(41)))));
            this.kcpbCustom.Ribbon.RibbonAppMenuDocs.BackColor1 = System.Drawing.Color.White;
            this.kcpbCustom.Ribbon.RibbonAppMenuDocs.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuDocs.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuDocs.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuDocs.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuOuter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.kcpbCustom.Ribbon.RibbonAppMenuOuter.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuOuter.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuOuter.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonAppMenuOuter.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBack.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.kcpbCustom.Ribbon.RibbonGalleryBack.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBack.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBack.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBack.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBorder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(214)))));
            this.kcpbCustom.Ribbon.RibbonGalleryBorder.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBorder.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBorder.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGalleryBorder.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextCheckedNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextCheckedNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextCheckedNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextCheckedNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextPressed.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextPressed.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextPressed.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextPressed.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextPressed.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateContextTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupArea.StateTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateContextTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedBorder.StateTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextNormal.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateContextTracking.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateNormal.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBack.StateTracking.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextNormal.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateContextTracking.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateNormal.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupCollapsedFrameBorder.StateTracking.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateContextTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateNormal.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateNormal.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateNormal.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateNormal.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateNormal.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateTracking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateTracking.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateTracking.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateTracking.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonGroupNormalBorder.StateTracking.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonQATFullbar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.kcpbCustom.Ribbon.RibbonQATFullbar.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATFullbar.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATFullbar.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATFullbar.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateActive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateActive.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateActive.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateActive.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateActive.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateInactive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(206)))));
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateInactive.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateInactive.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateInactive.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATMinibar.StateInactive.BackColor5 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kcpbCustom.Ribbon.RibbonQATOverflow.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.kcpbCustom.Ribbon.RibbonQATOverflow.BackColor2 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATOverflow.BackColor3 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATOverflow.BackColor4 = System.Drawing.Color.Empty;
            this.kcpbCustom.Ribbon.RibbonQATOverflow.BackColor5 = System.Drawing.Color.Empty;
            this.kcpbCustom.ThemeName = null;
            // 
            // VisualThemeBrowserFormRtlAware
            // 
            this.AcceptButton = this.kbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(836, 531);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualThemeBrowserFormRtlAware";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select a Theme";
            this.Load += new System.EventHandler(this.VisualThemeBrowserFormRtlAware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonPanel kryptonPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private KryptonButton kbtnImport;
        private KryptonCheckBox kchkSilent;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnOk;
        private KryptonBorderEdge kryptonBorderEdge1;
        private KryptonPanel kryptonPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private KryptonLabel klblHeader;
        private KryptonListBox klbThemeList;
        private KryptonCustomPaletteBase kcpbCustom;
    }
}