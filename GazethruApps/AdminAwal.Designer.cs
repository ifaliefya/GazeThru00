namespace GazethruApps
{
    partial class AdminAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAwal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Slideshow = new System.Windows.Forms.Button();
            this.btn_Tentang = new System.Windows.Forms.Button();
            this.btn_Prestasi = new System.Windows.Forms.Button();
            this.btn_Kegiatan = new System.Windows.Forms.Button();
            this.btn_Peta = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.adminSlideshow1 = new GazethruApps.AdminSlideshow();
            this.adminInformasi1 = new GazethruApps.AdminInformasi();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.btn_Peta);
            this.panel1.Controls.Add(this.btn_Kegiatan);
            this.panel1.Controls.Add(this.btn_Prestasi);
            this.panel1.Controls.Add(this.btn_Tentang);
            this.panel1.Controls.Add(this.btn_Slideshow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 839);
            this.panel1.TabIndex = 0;
            // 
            // btn_Slideshow
            // 
            this.btn_Slideshow.FlatAppearance.BorderSize = 0;
            this.btn_Slideshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Slideshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Slideshow.Image = ((System.Drawing.Image)(resources.GetObject("btn_Slideshow.Image")));
            this.btn_Slideshow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Slideshow.Location = new System.Drawing.Point(12, 179);
            this.btn_Slideshow.Name = "btn_Slideshow";
            this.btn_Slideshow.Size = new System.Drawing.Size(228, 60);
            this.btn_Slideshow.TabIndex = 0;
            this.btn_Slideshow.Text = "   Slideshow";
            this.btn_Slideshow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Slideshow.UseVisualStyleBackColor = true;
            this.btn_Slideshow.Click += new System.EventHandler(this.btn_Slideshow_Click);
            // 
            // btn_Tentang
            // 
            this.btn_Tentang.FlatAppearance.BorderSize = 0;
            this.btn_Tentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tentang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tentang.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tentang.Image")));
            this.btn_Tentang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tentang.Location = new System.Drawing.Point(12, 245);
            this.btn_Tentang.Name = "btn_Tentang";
            this.btn_Tentang.Size = new System.Drawing.Size(228, 60);
            this.btn_Tentang.TabIndex = 0;
            this.btn_Tentang.Text = "   Tentang DTETI";
            this.btn_Tentang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tentang.UseVisualStyleBackColor = true;
            this.btn_Tentang.Click += new System.EventHandler(this.btn_Tentang_Click);
            // 
            // btn_Prestasi
            // 
            this.btn_Prestasi.FlatAppearance.BorderSize = 0;
            this.btn_Prestasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prestasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestasi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prestasi.Image")));
            this.btn_Prestasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prestasi.Location = new System.Drawing.Point(12, 311);
            this.btn_Prestasi.Name = "btn_Prestasi";
            this.btn_Prestasi.Size = new System.Drawing.Size(228, 60);
            this.btn_Prestasi.TabIndex = 0;
            this.btn_Prestasi.Text = "   Prestasi";
            this.btn_Prestasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Prestasi.UseVisualStyleBackColor = true;
            // 
            // btn_Kegiatan
            // 
            this.btn_Kegiatan.FlatAppearance.BorderSize = 0;
            this.btn_Kegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kegiatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kegiatan.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kegiatan.Image")));
            this.btn_Kegiatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kegiatan.Location = new System.Drawing.Point(12, 377);
            this.btn_Kegiatan.Name = "btn_Kegiatan";
            this.btn_Kegiatan.Size = new System.Drawing.Size(228, 60);
            this.btn_Kegiatan.TabIndex = 0;
            this.btn_Kegiatan.Text = "   Kegiatan";
            this.btn_Kegiatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kegiatan.UseVisualStyleBackColor = true;
            // 
            // btn_Peta
            // 
            this.btn_Peta.FlatAppearance.BorderSize = 0;
            this.btn_Peta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Peta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Peta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Peta.Image")));
            this.btn_Peta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Peta.Location = new System.Drawing.Point(12, 443);
            this.btn_Peta.Name = "btn_Peta";
            this.btn_Peta.Size = new System.Drawing.Size(228, 60);
            this.btn_Peta.TabIndex = 0;
            this.btn_Peta.Text = "   Peta";
            this.btn_Peta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Peta.UseVisualStyleBackColor = true;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Sidepanel.Location = new System.Drawing.Point(3, 179);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 60);
            this.Sidepanel.TabIndex = 1;
            // 
            // adminSlideshow1
            // 
            this.adminSlideshow1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminSlideshow1.Location = new System.Drawing.Point(240, 97);
            this.adminSlideshow1.Name = "adminSlideshow1";
            this.adminSlideshow1.Size = new System.Drawing.Size(1449, 742);
            this.adminSlideshow1.TabIndex = 1;
            // 
            // adminInformasi1
            // 
            this.adminInformasi1.Location = new System.Drawing.Point(240, 97);
            this.adminInformasi1.Name = "adminInformasi1";
            this.adminInformasi1.Size = new System.Drawing.Size(1449, 742);
            this.adminInformasi1.TabIndex = 2;
            // 
            // AdminAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 839);
            this.Controls.Add(this.adminInformasi1);
            this.Controls.Add(this.adminSlideshow1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAwal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Tentang;
        private System.Windows.Forms.Button btn_Slideshow;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button btn_Peta;
        private System.Windows.Forms.Button btn_Kegiatan;
        private System.Windows.Forms.Button btn_Prestasi;
        private AdminSlideshow adminSlideshow1;
        private AdminInformasi adminInformasi1;
    }
}