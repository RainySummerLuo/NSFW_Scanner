﻿using System.Windows.Forms;

namespace FileScanner
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            System.Diagnostics.Process thisProcess = System.Diagnostics.Process.GetProcessById(System.Diagnostics.Process.GetCurrentProcess().Id);
            thisProcess.Kill();
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.llbPath = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.llbPorn = new System.Windows.Forms.LinkLabel();
            this.llbSexy = new System.Windows.Forms.LinkLabel();
            this.llbNorm = new System.Windows.Forms.LinkLabel();
            this.llbPort = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.llbPicfile = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llbPath
            // 
            this.llbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPath.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbPath.Location = new System.Drawing.Point(21, 19);
            this.llbPath.Name = "llbPath";
            this.llbPath.Size = new System.Drawing.Size(284, 29);
            this.llbPath.TabIndex = 1;
            this.llbPath.Text = "D:\\test";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel2.Location = new System.Drawing.Point(21, 80);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 29);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.Text = "Porn";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel3.Location = new System.Drawing.Point(21, 117);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(69, 29);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.Text = "Sexy";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel4.Location = new System.Drawing.Point(21, 155);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(98, 29);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.Text = "Normal";
            // 
            // llbPorn
            // 
            this.llbPorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPorn.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbPorn.Location = new System.Drawing.Point(189, 80);
            this.llbPorn.Name = "llbPorn";
            this.llbPorn.Size = new System.Drawing.Size(131, 27);
            this.llbPorn.TabIndex = 5;
            this.llbPorn.Text = "00";
            // 
            // llbSexy
            // 
            this.llbSexy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSexy.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbSexy.Location = new System.Drawing.Point(189, 117);
            this.llbSexy.Name = "llbSexy";
            this.llbSexy.Size = new System.Drawing.Size(131, 27);
            this.llbSexy.TabIndex = 6;
            this.llbSexy.Text = "00";
            // 
            // llbNorm
            // 
            this.llbNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbNorm.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbNorm.Location = new System.Drawing.Point(189, 155);
            this.llbNorm.Name = "llbNorm";
            this.llbNorm.Size = new System.Drawing.Size(131, 27);
            this.llbNorm.TabIndex = 7;
            this.llbNorm.Text = "00";
            // 
            // llbPort
            // 
            this.llbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPort.ForeColor = System.Drawing.Color.Red;
            this.llbPort.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbPort.Location = new System.Drawing.Point(21, 194);
            this.llbPort.Name = "llbPort";
            this.llbPort.Size = new System.Drawing.Size(284, 26);
            this.llbPort.TabIndex = 10;
            this.llbPort.Text = "00.00%";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.progressBar1.Location = new System.Drawing.Point(12, 239);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.picShow.ErrorImage = null;
            this.picShow.Location = new System.Drawing.Point(311, 85);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(143, 140);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 8;
            this.picShow.TabStop = false;
            // 
            // picSearch
            // 
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::FileScanner.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(323, 19);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(51, 50);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 0;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.PicSearch);
            // 
            // llbPicfile
            // 
            this.llbPicfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPicfile.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbPicfile.Location = new System.Drawing.Point(24, 48);
            this.llbPicfile.Name = "llbPicfile";
            this.llbPicfile.Size = new System.Drawing.Size(281, 22);
            this.llbPicfile.TabIndex = 12;
            this.llbPicfile.Text = "test.jpg";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(181, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 29);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.Text = "NSFW";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 277);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(443, 152);
            this.listBox1.TabIndex = 14;
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::FileScanner.Properties.Resources.pause;
            this.pictureBox1.Location = new System.Drawing.Point(396, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(468, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llbPicfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.llbPort);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.llbNorm);
            this.Controls.Add(this.llbSexy);
            this.Controls.Add(this.llbPorn);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.llbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileScanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.LinkLabel llbPath;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel llbPorn;
        private System.Windows.Forms.LinkLabel llbSexy;
        private System.Windows.Forms.LinkLabel llbNorm;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.LinkLabel llbPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel llbPicfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private PictureBox pictureBox1;
    }
}

