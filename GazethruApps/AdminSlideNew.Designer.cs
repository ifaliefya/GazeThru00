﻿namespace GazethruApps
{
    partial class AdminSlideNew
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBrowsePict = new System.Windows.Forms.Button();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.TanggalNOW = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.ShowHide = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(70, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBrowsePict
            // 
            this.buttonBrowsePict.Location = new System.Drawing.Point(71, 591);
            this.buttonBrowsePict.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowsePict.Name = "buttonBrowsePict";
            this.buttonBrowsePict.Size = new System.Drawing.Size(77, 32);
            this.buttonBrowsePict.TabIndex = 1;
            this.buttonBrowsePict.Text = "Browse";
            this.buttonBrowsePict.UseVisualStyleBackColor = true;
            this.buttonBrowsePict.Click += new System.EventHandler(this.buttonBrowsePict_Click);
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(120, 60);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(270, 20);
            this.textBoxJudul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Judul :";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Location = new System.Drawing.Point(67, 24);
            this.labelTgl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(52, 13);
            this.labelTgl.TabIndex = 4;
            this.labelTgl.Text = "Tanggal :";
            // 
            // TanggalNOW
            // 
            this.TanggalNOW.AutoSize = true;
            this.TanggalNOW.Location = new System.Drawing.Point(122, 24);
            this.TanggalNOW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TanggalNOW.Name = "TanggalNOW";
            this.TanggalNOW.Size = new System.Drawing.Size(75, 13);
            this.TanggalNOW.TabIndex = 5;
            this.TanggalNOW.Text = "DD-MM-YYYY";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(313, 591);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(77, 32);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // ShowHide
            // 
            this.ShowHide.AutoSize = true;
            this.ShowHide.Location = new System.Drawing.Point(313, 24);
            this.ShowHide.Margin = new System.Windows.Forms.Padding(2);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(80, 17);
            this.ShowHide.TabIndex = 7;
            this.ShowHide.Text = "Show/Hide";
            this.ShowHide.UseVisualStyleBackColor = true;
            // 
            // AdminSlideNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 681);
            this.Controls.Add(this.ShowHide);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.TanggalNOW);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.buttonBrowsePict);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminSlideNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambahkan Slideshow Baru";
            this.Load += new System.EventHandler(this.AdminSlideNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBrowsePict;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label TanggalNOW;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.CheckBox ShowHide;
    }
}