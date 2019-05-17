namespace GazethruApps
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUname = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.textBoxPsswrd = new System.Windows.Forms.TextBox();
            this.labelPsswrd = new System.Windows.Forms.Label();
            this.linkLabelBackHome = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Admin";
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(522, 186);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(86, 20);
            this.labelUname.TabIndex = 1;
            this.labelUname.Text = "Username";
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUname.Location = new System.Drawing.Point(628, 183);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(175, 27);
            this.textBoxUname.TabIndex = 2;
            // 
            // textBoxPsswrd
            // 
            this.textBoxPsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPsswrd.Location = new System.Drawing.Point(628, 237);
            this.textBoxPsswrd.Name = "textBoxPsswrd";
            this.textBoxPsswrd.Size = new System.Drawing.Size(175, 27);
            this.textBoxPsswrd.TabIndex = 4;
            // 
            // labelPsswrd
            // 
            this.labelPsswrd.AutoSize = true;
            this.labelPsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPsswrd.Location = new System.Drawing.Point(522, 240);
            this.labelPsswrd.Name = "labelPsswrd";
            this.labelPsswrd.Size = new System.Drawing.Size(83, 20);
            this.labelPsswrd.TabIndex = 3;
            this.labelPsswrd.Text = "Password";
            // 
            // linkLabelBackHome
            // 
            this.linkLabelBackHome.AutoSize = true;
            this.linkLabelBackHome.Location = new System.Drawing.Point(625, 340);
            this.linkLabelBackHome.Name = "linkLabelBackHome";
            this.linkLabelBackHome.Size = new System.Drawing.Size(133, 17);
            this.linkLabelBackHome.TabIndex = 5;
            this.linkLabelBackHome.TabStop = true;
            this.linkLabelBackHome.Text = "kembali ke Beranda";
            this.linkLabelBackHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackHome_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(654, 290);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 839);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.linkLabelBackHome);
            this.Controls.Add(this.textBoxPsswrd);
            this.Controls.Add(this.labelPsswrd);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.TextBox textBoxPsswrd;
        private System.Windows.Forms.Label labelPsswrd;
        private System.Windows.Forms.LinkLabel linkLabelBackHome;
        private System.Windows.Forms.Button buttonLogin;
    }
}