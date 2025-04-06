namespace bmim2214_lab2
{
    partial class FillForm3
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
            this.lbr = new System.Windows.Forms.Label();
            this.lbr2 = new System.Windows.Forms.Label();
            this.btr = new System.Windows.Forms.Button();
            this.btrb = new System.Windows.Forms.Button();
            this.btExit3 = new System.Windows.Forms.Button();
            this.tbru = new System.Windows.Forms.TextBox();
            this.tbrp = new System.Windows.Forms.TextBox();
            this.lbr3 = new System.Windows.Forms.Label();
            this.tbrp2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbr
            // 
            this.lbr.AutoSize = true;
            this.lbr.Location = new System.Drawing.Point(62, 98);
            this.lbr.Name = "lbr";
            this.lbr.Size = new System.Drawing.Size(205, 20);
            this.lbr.TabIndex = 0;
            this.lbr.Text = "Irj be egy felhasznalo nevet:";
            // 
            // lbr2
            // 
            this.lbr2.AutoSize = true;
            this.lbr2.Location = new System.Drawing.Point(62, 208);
            this.lbr2.Name = "lbr2";
            this.lbr2.Size = new System.Drawing.Size(113, 20);
            this.lbr2.TabIndex = 1;
            this.lbr2.Text = "Irj be jelszavat:";
            // 
            // btr
            // 
            this.btr.Location = new System.Drawing.Point(51, 471);
            this.btr.Name = "btr";
            this.btr.Size = new System.Drawing.Size(124, 56);
            this.btr.TabIndex = 2;
            this.btr.Text = "Regisztralok!";
            this.btr.UseVisualStyleBackColor = true;
            this.btr.Click += new System.EventHandler(this.btr_Click);
            // 
            // btrb
            // 
            this.btrb.Location = new System.Drawing.Point(329, 471);
            this.btrb.Name = "btrb";
            this.btrb.Size = new System.Drawing.Size(107, 56);
            this.btrb.TabIndex = 3;
            this.btrb.Text = "Vissza";
            this.btrb.UseVisualStyleBackColor = true;
            this.btrb.Click += new System.EventHandler(this.btrb_Click);
            // 
            // btExit3
            // 
            this.btExit3.Location = new System.Drawing.Point(597, 471);
            this.btExit3.Name = "btExit3";
            this.btExit3.Size = new System.Drawing.Size(113, 56);
            this.btExit3.TabIndex = 4;
            this.btExit3.Text = "Kilepes";
            this.btExit3.UseVisualStyleBackColor = true;
            this.btExit3.Click += new System.EventHandler(this.btExit3_Click);
            // 
            // tbru
            // 
            this.tbru.Location = new System.Drawing.Point(361, 98);
            this.tbru.Name = "tbru";
            this.tbru.Size = new System.Drawing.Size(277, 26);
            this.tbru.TabIndex = 5;
            // 
            // tbrp
            // 
            this.tbrp.Location = new System.Drawing.Point(361, 201);
            this.tbrp.Name = "tbrp";
            this.tbrp.Size = new System.Drawing.Size(277, 26);
            this.tbrp.TabIndex = 6;
            // 
            // lbr3
            // 
            this.lbr3.AutoSize = true;
            this.lbr3.Location = new System.Drawing.Point(66, 264);
            this.lbr3.Name = "lbr3";
            this.lbr3.Size = new System.Drawing.Size(162, 20);
            this.lbr3.TabIndex = 7;
            this.lbr3.Text = "Ird be ujra a jelszavat:";
            // 
            // tbrp2
            // 
            this.tbrp2.Location = new System.Drawing.Point(361, 275);
            this.tbrp2.Name = "tbrp2";
            this.tbrp2.Size = new System.Drawing.Size(277, 26);
            this.tbrp2.TabIndex = 8;
            this.tbrp2.TextChanged += new System.EventHandler(this.tbrp2_TextChanged);
            // 
            // FillForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 587);
            this.Controls.Add(this.tbrp2);
            this.Controls.Add(this.lbr3);
            this.Controls.Add(this.tbrp);
            this.Controls.Add(this.tbru);
            this.Controls.Add(this.btExit3);
            this.Controls.Add(this.btrb);
            this.Controls.Add(this.btr);
            this.Controls.Add(this.lbr2);
            this.Controls.Add(this.lbr);
            this.Name = "FillForm3";
            this.Text = "Regisztralas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbr;
        private System.Windows.Forms.Label lbr2;
        private System.Windows.Forms.Button btr;
        private System.Windows.Forms.Button btrb;
        private System.Windows.Forms.Button btExit3;
        private System.Windows.Forms.TextBox tbru;
        private System.Windows.Forms.TextBox tbrp;
        private System.Windows.Forms.Label lbr3;
        private System.Windows.Forms.TextBox tbrp2;
    }
}