namespace GazethruApps
{
    partial class AdminSlideEdit
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
            this.ShowHide = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.TanggalNOW = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.buttonBrowsePict = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowHide
            // 
            this.ShowHide.AutoSize = true;
            this.ShowHide.Location = new System.Drawing.Point(377, 35);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(97, 21);
            this.ShowHide.TabIndex = 15;
            this.ShowHide.Text = "Show/Hide";
            this.ShowHide.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(409, 101);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // TanggalNOW
            // 
            this.TanggalNOW.AutoSize = true;
            this.TanggalNOW.Location = new System.Drawing.Point(123, 35);
            this.TanggalNOW.Name = "TanggalNOW";
            this.TanggalNOW.Size = new System.Drawing.Size(96, 17);
            this.TanggalNOW.TabIndex = 13;
            this.TanggalNOW.Text = "DD-MM-YYYY";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Location = new System.Drawing.Point(49, 35);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(68, 17);
            this.labelTgl.TabIndex = 12;
            this.labelTgl.Text = "Tanggal :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Judul :";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(126, 69);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(358, 22);
            this.textBoxJudul.TabIndex = 10;
            // 
            // buttonBrowsePict
            // 
            this.buttonBrowsePict.Location = new System.Drawing.Point(42, 110);
            this.buttonBrowsePict.Name = "buttonBrowsePict";
            this.buttonBrowsePict.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePict.TabIndex = 9;
            this.buttonBrowsePict.Text = "Browse";
            this.buttonBrowsePict.UseVisualStyleBackColor = true;
            this.buttonBrowsePict.Click += new System.EventHandler(this.buttonBrowsePict_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminSlideEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 687);
            this.Controls.Add(this.ShowHide);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.TanggalNOW);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.buttonBrowsePict);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminSlideEdit";
            this.Text = "Edit Slider";
            this.Load += new System.EventHandler(this.AdminSlideEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowHide;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label TanggalNOW;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Button buttonBrowsePict;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}