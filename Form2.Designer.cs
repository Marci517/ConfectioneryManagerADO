namespace bmim2214_lab2
{
    partial class FillForm2
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btGuest = new System.Windows.Forms.Button();
            this.btExit2 = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(55, 113);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(124, 20);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Felhasznalonev:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(121, 264);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(58, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Jelszo:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(232, 113);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(264, 26);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(232, 264);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(264, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(68, 431);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(127, 48);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Bejelentkezes";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(363, 431);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(93, 48);
            this.btAdmin.TabIndex = 5;
            this.btAdmin.Text = "ADMIN";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btGuest
            // 
            this.btGuest.Location = new System.Drawing.Point(623, 431);
            this.btGuest.Name = "btGuest";
            this.btGuest.Size = new System.Drawing.Size(95, 48);
            this.btGuest.TabIndex = 6;
            this.btGuest.Text = "VENDEG";
            this.btGuest.UseVisualStyleBackColor = true;
            this.btGuest.Click += new System.EventHandler(this.btGuest_Click);
            // 
            // btExit2
            // 
            this.btExit2.Location = new System.Drawing.Point(812, 502);
            this.btExit2.Name = "btExit2";
            this.btExit2.Size = new System.Drawing.Size(75, 44);
            this.btExit2.TabIndex = 7;
            this.btExit2.Text = "Kilepes";
            this.btExit2.UseVisualStyleBackColor = true;
            this.btExit2.Click += new System.EventHandler(this.btExit2_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(812, 431);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(125, 44);
            this.btRegistration.TabIndex = 8;
            this.btRegistration.Text = "Regisztralas";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // FillForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btExit2);
            this.Controls.Add(this.btGuest);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "FillForm2";
            this.Text = "Bejelentkezes";
            this.Load += new System.EventHandler(this.FillForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btGuest;
        private System.Windows.Forms.Button btExit2;
        private System.Windows.Forms.Button btRegistration;
    }
}