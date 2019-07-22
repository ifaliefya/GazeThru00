namespace GazethruApps
{
    partial class AdminInformasi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxIsi = new System.Windows.Forms.RichTextBox();
            this.labelIsi = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(795, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(676, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Baru";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(510, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(104, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(179, 28);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(45, 43);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 24);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Cari :";
            // 
            // textBoxIsi
            // 
            this.textBoxIsi.Location = new System.Drawing.Point(874, 213);
            this.textBoxIsi.Name = "textBoxIsi";
            this.textBoxIsi.Size = new System.Drawing.Size(419, 389);
            this.textBoxIsi.TabIndex = 11;
            this.textBoxIsi.Text = "";
            // 
            // labelIsi
            // 
            this.labelIsi.AutoSize = true;
            this.labelIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsi.Location = new System.Drawing.Point(870, 178);
            this.labelIsi.Name = "labelIsi";
            this.labelIsi.Size = new System.Drawing.Size(110, 20);
            this.labelIsi.TabIndex = 10;
            this.labelIsi.Text = "Description : ";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.Location = new System.Drawing.Point(939, 120);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(354, 27);
            this.textBoxJudul.TabIndex = 9;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(874, 123);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(59, 20);
            this.labelJudul.TabIndex = 8;
            this.labelJudul.Text = "Judul :";
            // 
            // AdminInformasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxIsi);
            this.Controls.Add(this.labelIsi);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdminInformasi";
            this.Size = new System.Drawing.Size(1449, 742);
            this.Load += new System.EventHandler(this.AdminInformasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.RichTextBox textBoxIsi;
        private System.Windows.Forms.Label labelIsi;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label labelJudul;
    }
}
