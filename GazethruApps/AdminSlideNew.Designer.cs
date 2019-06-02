namespace GazethruApps
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
            this.checkShowHide = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBrowsePict
            // 
            this.buttonBrowsePict.Location = new System.Drawing.Point(45, 104);
            this.buttonBrowsePict.Name = "buttonBrowsePict";
            this.buttonBrowsePict.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePict.TabIndex = 1;
            this.buttonBrowsePict.Text = "Browse";
            this.buttonBrowsePict.UseVisualStyleBackColor = true;
            this.buttonBrowsePict.Click += new System.EventHandler(this.buttonBrowsePict_Click);
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(129, 63);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(358, 22);
            this.textBoxJudul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Judul :";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Location = new System.Drawing.Point(52, 29);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(68, 17);
            this.labelTgl.TabIndex = 4;
            this.labelTgl.Text = "Tanggal :";
            // 
            // TanggalNOW
            // 
            this.TanggalNOW.AutoSize = true;
            this.TanggalNOW.Location = new System.Drawing.Point(126, 29);
            this.TanggalNOW.Name = "TanggalNOW";
            this.TanggalNOW.Size = new System.Drawing.Size(96, 17);
            this.TanggalNOW.TabIndex = 5;
            this.TanggalNOW.Text = "DD-MM-YYYY";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(412, 95);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // checkShowHide
            // 
            this.checkShowHide.AutoSize = true;
            this.checkShowHide.Location = new System.Drawing.Point(380, 29);
            this.checkShowHide.Name = "checkShowHide";
            this.checkShowHide.Size = new System.Drawing.Size(97, 21);
            this.checkShowHide.TabIndex = 7;
            this.checkShowHide.Text = "Show/Hide";
            this.checkShowHide.UseVisualStyleBackColor = true;
            this.checkShowHide.CheckedChanged += new System.EventHandler(this.checkShowHide_CheckedChanged);
            // 
            // AdminSlideNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 687);
            this.Controls.Add(this.checkShowHide);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.TanggalNOW);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.buttonBrowsePict);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminSlideNew";
            this.Text = "Tambahkan Slideshow Baru";
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
        private System.Windows.Forms.CheckBox checkShowHide;
    }
}