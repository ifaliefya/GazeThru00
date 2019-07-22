namespace GazethruApps
{
    partial class AdminPetaNew
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
            this.panelEdit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Location = new System.Drawing.Point(2, 8);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1280, 720);
            this.panelEdit.TabIndex = 0;
            // 
            // AdminPetaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 740);
            this.Controls.Add(this.panelEdit);
            this.Name = "AdminPetaNew";
            this.Text = "Tambah Lantai Baru";
            this.Load += new System.EventHandler(this.AdminPetaNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEdit;
    }
}