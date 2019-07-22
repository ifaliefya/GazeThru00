namespace GazethruApps
{
    partial class AdminPetaNewRuang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPetaNewRuang));
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelNamaLantai = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.picPointer = new System.Windows.Forms.PictureBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.buttonBrowsePict = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocY = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tbLocX = new System.Windows.Forms.TextBox();
            this.textBoxIsi = new System.Windows.Forms.RichTextBox();
            this.pictureBoxRuang = new System.Windows.Forms.PictureBox();
            this.labelIDNow = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelPeta = new System.Windows.Forms.Panel();
            this.pbPetaLantai = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPointer)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuang)).BeginInit();
            this.panelPeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPetaLantai)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(1032, 91);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(125, 20);
            this.labelJudul.TabIndex = 15;
            this.labelJudul.Text = "Nama Lantai  :";
            // 
            // labelNamaLantai
            // 
            this.labelNamaLantai.AutoSize = true;
            this.labelNamaLantai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaLantai.Location = new System.Drawing.Point(1032, 121);
            this.labelNamaLantai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaLantai.Name = "labelNamaLantai";
            this.labelNamaLantai.Size = new System.Drawing.Size(147, 20);
            this.labelNamaLantai.TabIndex = 16;
            this.labelNamaLantai.Text = "Lantai Berapa Ini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(276, 376);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(17, 39);
            this.labelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(147, 17);
            this.labelList.TabIndex = 18;
            this.labelList.Text = "Daftar Titik Ruangan :";
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPoint.Location = new System.Drawing.Point(911, 420);
            this.buttonAddPoint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(113, 30);
            this.buttonAddPoint.TabIndex = 20;
            this.buttonAddPoint.Text = "    Tambah";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // picPointer
            // 
            this.picPointer.BackColor = System.Drawing.Color.Transparent;
            this.picPointer.Image = ((System.Drawing.Image)(resources.GetObject("picPointer.Image")));
            this.picPointer.Location = new System.Drawing.Point(911, 420);
            this.picPointer.Name = "picPointer";
            this.picPointer.Size = new System.Drawing.Size(22, 30);
            this.picPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPointer.TabIndex = 47;
            this.picPointer.TabStop = false;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.buttonCancel);
            this.panelDetails.Controls.Add(this.buttonSave);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.textBoxJudul);
            this.panelDetails.Controls.Add(this.buttonBrowsePict);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.tbLocY);
            this.panelDetails.Controls.Add(this.buttonEdit);
            this.panelDetails.Controls.Add(this.tbLocX);
            this.panelDetails.Controls.Add(this.textBoxIsi);
            this.panelDetails.Controls.Add(this.pictureBoxRuang);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetails.Location = new System.Drawing.Point(0, 467);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(1280, 253);
            this.panelDetails.TabIndex = 51;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1126, 91);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 30);
            this.buttonCancel.TabIndex = 63;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1126, 53);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 30);
            this.buttonSave.TabIndex = 62;
            this.buttonSave.Text = "Simpan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Deskripsi Ruang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nama Ruang :";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.Location = new System.Drawing.Point(832, 26);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(259, 23);
            this.textBoxJudul.TabIndex = 57;
            // 
            // buttonBrowsePict
            // 
            this.buttonBrowsePict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowsePict.Location = new System.Drawing.Point(381, 198);
            this.buttonBrowsePict.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowsePict.Name = "buttonBrowsePict";
            this.buttonBrowsePict.Size = new System.Drawing.Size(91, 30);
            this.buttonBrowsePict.TabIndex = 58;
            this.buttonBrowsePict.Text = "Browse";
            this.buttonBrowsePict.UseVisualStyleBackColor = true;
            this.buttonBrowsePict.Click += new System.EventHandler(this.buttonBrowsePict_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Lokasi :";
            // 
            // tbLocY
            // 
            this.tbLocY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocY.Location = new System.Drawing.Point(629, 26);
            this.tbLocY.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocY.Name = "tbLocY";
            this.tbLocY.Size = new System.Drawing.Size(71, 23);
            this.tbLocY.TabIndex = 56;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(1126, 16);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(113, 30);
            this.buttonEdit.TabIndex = 54;
            this.buttonEdit.Text = "Edit Details";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // tbLocX
            // 
            this.tbLocX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocX.Location = new System.Drawing.Point(554, 26);
            this.tbLocX.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocX.Name = "tbLocX";
            this.tbLocX.Size = new System.Drawing.Size(71, 23);
            this.tbLocX.TabIndex = 55;
            // 
            // textBoxIsi
            // 
            this.textBoxIsi.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIsi.Location = new System.Drawing.Point(493, 91);
            this.textBoxIsi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIsi.Name = "textBoxIsi";
            this.textBoxIsi.Size = new System.Drawing.Size(620, 137);
            this.textBoxIsi.TabIndex = 60;
            this.textBoxIsi.Text = "";
            // 
            // pictureBoxRuang
            // 
            this.pictureBoxRuang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxRuang.Location = new System.Drawing.Point(20, 22);
            this.pictureBoxRuang.Name = "pictureBoxRuang";
            this.pictureBoxRuang.Size = new System.Drawing.Size(452, 206);
            this.pictureBoxRuang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRuang.TabIndex = 41;
            this.pictureBoxRuang.TabStop = false;
            // 
            // labelIDNow
            // 
            this.labelIDNow.AutoSize = true;
            this.labelIDNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDNow.Location = new System.Drawing.Point(627, 425);
            this.labelIDNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDNow.Name = "labelIDNow";
            this.labelIDNow.Size = new System.Drawing.Size(29, 20);
            this.labelIDNow.TabIndex = 16;
            this.labelIDNow.Text = "00";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(570, 420);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(37, 30);
            this.buttonPrev.TabIndex = 52;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(676, 420);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(37, 30);
            this.buttonNext.TabIndex = 53;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // panelPeta
            // 
            this.panelPeta.Controls.Add(this.pbPetaLantai);
            this.panelPeta.Location = new System.Drawing.Point(301, 39);
            this.panelPeta.Name = "panelPeta";
            this.panelPeta.Size = new System.Drawing.Size(723, 374);
            this.panelPeta.TabIndex = 54;
            // 
            // pbPetaLantai
            // 
            this.pbPetaLantai.BackColor = System.Drawing.Color.White;
            this.pbPetaLantai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPetaLantai.Image = ((System.Drawing.Image)(resources.GetObject("pbPetaLantai.Image")));
            this.pbPetaLantai.Location = new System.Drawing.Point(0, 0);
            this.pbPetaLantai.Name = "pbPetaLantai";
            this.pbPetaLantai.Size = new System.Drawing.Size(723, 374);
            this.pbPetaLantai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPetaLantai.TabIndex = 50;
            this.pbPetaLantai.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1037, 224);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(175, 23);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Selesai";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdminPetaNewRuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelPeta);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.labelIDNow);
            this.Controls.Add(this.picPointer);
            this.Controls.Add(this.buttonAddPoint);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNamaLantai);
            this.Controls.Add(this.labelJudul);
            this.Name = "AdminPetaNewRuang";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.AdminPetaNewRuang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPointer)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuang)).EndInit();
            this.panelPeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPetaLantai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelNamaLantai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button buttonAddPoint;
        private System.Windows.Forms.PictureBox picPointer;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelIDNow;
        private System.Windows.Forms.PictureBox pictureBoxRuang;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.RichTextBox textBoxIsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLocY;
        private System.Windows.Forms.TextBox tbLocX;
        private System.Windows.Forms.Panel panelPeta;
        private System.Windows.Forms.PictureBox pbPetaLantai;
        private System.Windows.Forms.Button buttonBrowsePict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBack;
    }
}
