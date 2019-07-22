namespace GazethruApps
{
    partial class AdminPetaNewLantai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.NoInfo = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.buttonBrowsePict = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsertnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.Location = new System.Drawing.Point(531, 176);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(448, 23);
            this.textBoxJudul.TabIndex = 15;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(427, 179);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(100, 17);
            this.labelJudul.TabIndex = 14;
            this.labelJudul.Text = "Nama Lantai  :";
            // 
            // NoInfo
            // 
            this.NoInfo.AutoSize = true;
            this.NoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoInfo.Location = new System.Drawing.Point(348, 179);
            this.NoInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoInfo.Name = "NoInfo";
            this.NoInfo.Size = new System.Drawing.Size(32, 17);
            this.NoInfo.TabIndex = 13;
            this.NoInfo.Text = "000";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(316, 179);
            this.labelNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(38, 17);
            this.labelNo.TabIndex = 12;
            this.labelNo.Text = "No : ";
            // 
            // buttonBrowsePict
            // 
            this.buttonBrowsePict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowsePict.Location = new System.Drawing.Point(319, 535);
            this.buttonBrowsePict.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowsePict.Name = "buttonBrowsePict";
            this.buttonBrowsePict.Size = new System.Drawing.Size(77, 32);
            this.buttonBrowsePict.TabIndex = 18;
            this.buttonBrowsePict.Text = "Browse";
            this.buttonBrowsePict.UseVisualStyleBackColor = true;
            this.buttonBrowsePict.Click += new System.EventHandler(this.buttonBrowsePict_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 224);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsertnEdit
            // 
            this.btnInsertnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertnEdit.Location = new System.Drawing.Point(499, 584);
            this.btnInsertnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertnEdit.Name = "btnInsertnEdit";
            this.btnInsertnEdit.Size = new System.Drawing.Size(293, 32);
            this.btnInsertnEdit.TabIndex = 19;
            this.btnInsertnEdit.Text = "Simpan dan Edit Detail ->";
            this.btnInsertnEdit.UseVisualStyleBackColor = true;
            this.btnInsertnEdit.Click += new System.EventHandler(this.btnInsertnEdit_Click);
            // 
            // AdminPetaNewLantai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsertnEdit);
            this.Controls.Add(this.buttonBrowsePict);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.NoInfo);
            this.Controls.Add(this.labelNo);
            this.Name = "AdminPetaNewLantai";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.AdminPetaNewLantai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label NoInfo;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Button buttonBrowsePict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsertnEdit;
    }
}
