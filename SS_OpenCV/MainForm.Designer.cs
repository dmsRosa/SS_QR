﻿namespace SS_OpenCV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalepointxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferentiationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonUniformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationWithThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageViewer = new Emgu.CV.UI.ImageBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.trabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.evalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.transformsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.autoZoomToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativeToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.redChannelToolStripMenuItem,
            this.brightContrastToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // redChannelToolStripMenuItem
            // 
            this.redChannelToolStripMenuItem.Name = "redChannelToolStripMenuItem";
            this.redChannelToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.redChannelToolStripMenuItem.Text = "Red Channel";
            this.redChannelToolStripMenuItem.Click += new System.EventHandler(this.redChannelToolStripMenuItem_Click_1);
            // 
            // brightContrastToolStripMenuItem
            // 
            this.brightContrastToolStripMenuItem.Name = "brightContrastToolStripMenuItem";
            this.brightContrastToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.brightContrastToolStripMenuItem.Text = "BrightContrast";
            this.brightContrastToolStripMenuItem.Click += new System.EventHandler(this.brightContrastToolStripMenuItem_Click);
            // 
            // transformsToolStripMenuItem
            // 
            this.transformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.scalepointxyToolStripMenuItem});
            this.transformsToolStripMenuItem.Name = "transformsToolStripMenuItem";
            this.transformsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transformsToolStripMenuItem.Text = "Transforms";
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.translationToolStripMenuItem.Text = "Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.rotationToolStripMenuItem.Text = "Rotation";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // scalepointxyToolStripMenuItem
            // 
            this.scalepointxyToolStripMenuItem.Name = "scalepointxyToolStripMenuItem";
            this.scalepointxyToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.scalepointxyToolStripMenuItem.Text = "Scale_point_xy";
            this.scalepointxyToolStripMenuItem.Click += new System.EventHandler(this.scalepointxyToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.diferentiationToolStripMenuItem,
            this.nonUniformToolStripMenuItem,
            this.grayHistogramToolStripMenuItem,
            this.colorHistogramToolStripMenuItem,
            this.allHistogramToolStripMenuItem,
            this.binarizationWithThresholdToolStripMenuItem,
            this.trabToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.mediaToolStripMenuItem.Text = "Mean - solution A";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // diferentiationToolStripMenuItem
            // 
            this.diferentiationToolStripMenuItem.Name = "diferentiationToolStripMenuItem";
            this.diferentiationToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.diferentiationToolStripMenuItem.Text = "Diferentiation";
            this.diferentiationToolStripMenuItem.Click += new System.EventHandler(this.diferentiationToolStripMenuItem_Click);
            // 
            // nonUniformToolStripMenuItem
            // 
            this.nonUniformToolStripMenuItem.Name = "nonUniformToolStripMenuItem";
            this.nonUniformToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.nonUniformToolStripMenuItem.Text = "Non Uniform";
            this.nonUniformToolStripMenuItem.Click += new System.EventHandler(this.nonUniformToolStripMenuItem_Click);
            // 
            // grayHistogramToolStripMenuItem
            // 
            this.grayHistogramToolStripMenuItem.Name = "grayHistogramToolStripMenuItem";
            this.grayHistogramToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.grayHistogramToolStripMenuItem.Text = "Gray Histogram";
            this.grayHistogramToolStripMenuItem.Click += new System.EventHandler(this.grayHistogramToolStripMenuItem_Click);
            // 
            // colorHistogramToolStripMenuItem
            // 
            this.colorHistogramToolStripMenuItem.Name = "colorHistogramToolStripMenuItem";
            this.colorHistogramToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.colorHistogramToolStripMenuItem.Text = "Color Histogram";
            this.colorHistogramToolStripMenuItem.Click += new System.EventHandler(this.colorHistogramToolStripMenuItem_Click);
            // 
            // allHistogramToolStripMenuItem
            // 
            this.allHistogramToolStripMenuItem.Name = "allHistogramToolStripMenuItem";
            this.allHistogramToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.allHistogramToolStripMenuItem.Text = "All Histogram";
            this.allHistogramToolStripMenuItem.Click += new System.EventHandler(this.allHistogramToolStripMenuItem_Click);
            // 
            // binarizationWithThresholdToolStripMenuItem
            // 
            this.binarizationWithThresholdToolStripMenuItem.Name = "binarizationWithThresholdToolStripMenuItem";
            this.binarizationWithThresholdToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.binarizationWithThresholdToolStripMenuItem.Text = "Binarization with threshold";
            this.binarizationWithThresholdToolStripMenuItem.Click += new System.EventHandler(this.binarizationWithThresholdToolStripMenuItem_Click);
            // 
            // autoZoomToolStripMenuItem
            // 
            this.autoZoomToolStripMenuItem.CheckOnClick = true;
            this.autoZoomToolStripMenuItem.Name = "autoZoomToolStripMenuItem";
            this.autoZoomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoZoomToolStripMenuItem.Text = "Auto Zoom";
            this.autoZoomToolStripMenuItem.Click += new System.EventHandler(this.autoZoomToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.autoresToolStripMenuItem.Text = "Autores...";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // evalToolStripMenuItem
            // 
            this.evalToolStripMenuItem.Name = "evalToolStripMenuItem";
            this.evalToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.evalToolStripMenuItem.Text = "Eval";
            this.evalToolStripMenuItem.Click += new System.EventHandler(this.evalToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ImageViewer);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 373);
            this.panel1.TabIndex = 6;
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(0, 2);
            this.ImageViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(810, 559);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageViewer.TabIndex = 2;
            this.ImageViewer.TabStop = false;
            this.ImageViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageViewer_MouseClick);
            this.ImageViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageViewer_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(771, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 20);
            this.statusLabel.Text = "X :-   Y:-";
            // 
            // trabToolStripMenuItem
            // 
            this.trabToolStripMenuItem.Name = "trabToolStripMenuItem";
            this.trabToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.trabToolStripMenuItem.Text = "trab";
            this.trabToolStripMenuItem.Click += new System.EventHandler(this.trabToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Sistemas Sensoriais 2022/2023 - Image processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoZoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem evalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private Emgu.CV.UI.ImageBox ImageViewer;
        private System.Windows.Forms.ToolStripMenuItem redChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scalepointxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonUniformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferentiationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationWithThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabToolStripMenuItem;
    }
}

