﻿namespace TestForm
{
    partial class Form5
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
            this.kryptonLanguageManager1 = new Krypton.Toolkit.KryptonLanguageManager();
            this.kryptonIntegratedToolBarManager1 = new Krypton.Toolkit.KryptonIntegratedToolBarManager();
            this.SuspendLayout();
            // 
            // kryptonLanguageManager1
            // 
            this.kryptonLanguageManager1.PaletteContentStyleStrings.ButtonGallery = null;
            this.kryptonLanguageManager1.PaletteContentStyleStrings.GridHeaderRowList = "Grid - RowColumn - List";
            // 
            // kryptonIntegratedToolBarManager1
            // 
            this.kryptonIntegratedToolBarManager1.IntegratedToolBarButtonAlignment = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.kryptonIntegratedToolBarManager1.IntegratedToolBarButtonOrientation = Krypton.Toolkit.PaletteButtonOrientation.Auto;
            this.kryptonIntegratedToolBarManager1.ParentForm = this;
            this.kryptonIntegratedToolBarManager1.ShowCopyButton = false;
            this.kryptonIntegratedToolBarManager1.ShowCutButton = false;
            this.kryptonIntegratedToolBarManager1.ShowIntegratedToolBar = true;
            this.kryptonIntegratedToolBarManager1.ShowNewButton = false;
            this.kryptonIntegratedToolBarManager1.ShowOpenButton = false;
            this.kryptonIntegratedToolBarManager1.ShowPageSetupButton = false;
            this.kryptonIntegratedToolBarManager1.ShowPasteButton = false;
            this.kryptonIntegratedToolBarManager1.ShowPrintButton = false;
            this.kryptonIntegratedToolBarManager1.ShowPrintPreviewButton = false;
            this.kryptonIntegratedToolBarManager1.ShowQuickPrintButton = false;
            this.kryptonIntegratedToolBarManager1.ShowRedoButton = false;
            this.kryptonIntegratedToolBarManager1.ShowSaveAllButton = false;
            this.kryptonIntegratedToolBarManager1.ShowSaveAsButton = false;
            this.kryptonIntegratedToolBarManager1.ShowSaveButton = false;
            this.kryptonIntegratedToolBarManager1.ShowUndoButton = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLanguageManager kryptonLanguageManager1;
        private Krypton.Toolkit.KryptonIntegratedToolBarManager kryptonIntegratedToolBarManager1;
    }
}