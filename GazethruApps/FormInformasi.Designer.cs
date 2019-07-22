namespace GazethruApps
{
    partial class formInformasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInformasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTentang = new System.Windows.Forms.Button();
            this.btnPrestasi = new System.Windows.Forms.Button();
            this.btnKegiatan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1707, 48);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(764, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMASI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(1)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(667, 763);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 48);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTentang
            // 
            this.btnTentang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.btnTentang.FlatAppearance.BorderSize = 0;
            this.btnTentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTentang.ForeColor = System.Drawing.Color.White;
            this.btnTentang.Location = new System.Drawing.Point(133, 246);
            this.btnTentang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTentang.Name = "btnTentang";
            this.btnTentang.Size = new System.Drawing.Size(139, 48);
            this.btnTentang.TabIndex = 24;
            this.btnTentang.Text = "Tentang DTETI";
            this.btnTentang.UseVisualStyleBackColor = false;
            this.btnTentang.Click += new System.EventHandler(this.btnTentang_Click);
            // 
            // btnPrestasi
            // 
            this.btnPrestasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.btnPrestasi.FlatAppearance.BorderSize = 0;
            this.btnPrestasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestasi.ForeColor = System.Drawing.Color.White;
            this.btnPrestasi.Location = new System.Drawing.Point(640, 308);
            this.btnPrestasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrestasi.Name = "btnPrestasi";
            this.btnPrestasi.Size = new System.Drawing.Size(139, 48);
            this.btnPrestasi.TabIndex = 25;
            this.btnPrestasi.Text = "Prestasi";
            this.btnPrestasi.UseVisualStyleBackColor = false;
            this.btnPrestasi.Click += new System.EventHandler(this.btnPrestasi_Click);
            // 
            // btnKegiatan
            // 
            this.btnKegiatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.btnKegiatan.FlatAppearance.BorderSize = 0;
            this.btnKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKegiatan.ForeColor = System.Drawing.Color.White;
            this.btnKegiatan.Location = new System.Drawing.Point(1440, 578);
            this.btnKegiatan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKegiatan.Name = "btnKegiatan";
            this.btnKegiatan.Size = new System.Drawing.Size(139, 48);
            this.btnKegiatan.TabIndex = 26;
            this.btnKegiatan.Text = "Kegiatan";
            this.btnKegiatan.UseVisualStyleBackColor = false;
            this.btnKegiatan.Click += new System.EventHandler(this.btnKegiatan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 364);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 874);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1707, 12);
            this.panel2.TabIndex = 28;
            // 
            // formInformasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnKegiatan);
            this.Controls.Add(this.btnPrestasi);
            this.Controls.Add(this.btnTentang);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formInformasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformasi";
            this.Load += new System.EventHandler(this.FormInformasi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTentang;
        private System.Windows.Forms.Button btnPrestasi;
        private System.Windows.Forms.Button btnKegiatan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}