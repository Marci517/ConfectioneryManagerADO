namespace bmim2214_lab2
{
    partial class FillForm
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbMegyeNev = new System.Windows.Forms.Label();
            this.lbCukraszdaNev = new System.Windows.Forms.Label();
            this.cbHelyszinekFilter = new System.Windows.Forms.ComboBox();
            this.tbCukraszdaFilter = new System.Windows.Forms.TextBox();
            this.dgvCukraszdak = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolgozokSzama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbLast = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbActual = new System.Windows.Forms.RadioButton();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.lbActual = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.lbUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCukraszdak)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(549, 63);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 41);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lbMegyeNev
            // 
            this.lbMegyeNev.AutoSize = true;
            this.lbMegyeNev.Location = new System.Drawing.Point(12, 73);
            this.lbMegyeNev.Name = "lbMegyeNev";
            this.lbMegyeNev.Size = new System.Drawing.Size(60, 20);
            this.lbMegyeNev.TabIndex = 2;
            this.lbMegyeNev.Text = "Megye:";
            // 
            // lbCukraszdaNev
            // 
            this.lbCukraszdaNev.AutoSize = true;
            this.lbCukraszdaNev.Location = new System.Drawing.Point(12, 388);
            this.lbCukraszdaNev.Name = "lbCukraszdaNev";
            this.lbCukraszdaNev.Size = new System.Drawing.Size(193, 20);
            this.lbCukraszdaNev.TabIndex = 3;
            this.lbCukraszdaNev.Text = "Irj be egy cukraszda nevet";
            this.lbCukraszdaNev.Click += new System.EventHandler(this.lbMegyeNev_Click);
            // 
            // cbHelyszinekFilter
            // 
            this.cbHelyszinekFilter.FormattingEnabled = true;
            this.cbHelyszinekFilter.Location = new System.Drawing.Point(158, 70);
            this.cbHelyszinekFilter.Name = "cbHelyszinekFilter";
            this.cbHelyszinekFilter.Size = new System.Drawing.Size(192, 28);
            this.cbHelyszinekFilter.TabIndex = 4;
            this.cbHelyszinekFilter.SelectedIndexChanged += new System.EventHandler(this.cbCukraszdaFilter_SelectedIndexChanged);
            // 
            // tbCukraszdaFilter
            // 
            this.tbCukraszdaFilter.Location = new System.Drawing.Point(206, 388);
            this.tbCukraszdaFilter.Name = "tbCukraszdaFilter";
            this.tbCukraszdaFilter.Size = new System.Drawing.Size(204, 26);
            this.tbCukraszdaFilter.TabIndex = 5;
            this.tbCukraszdaFilter.TextChanged += new System.EventHandler(this.tbMegyeFilter_TextChanged);
            // 
            // dgvCukraszdak
            // 
            this.dgvCukraszdak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCukraszdak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.Nev,
            this.DolgozokSzama,
            this.HID,
            this.Megye});
            this.dgvCukraszdak.Location = new System.Drawing.Point(16, 139);
            this.dgvCukraszdak.Name = "dgvCukraszdak";
            this.dgvCukraszdak.RowHeadersWidth = 62;
            this.dgvCukraszdak.RowTemplate.Height = 28;
            this.dgvCukraszdak.Size = new System.Drawing.Size(747, 216);
            this.dgvCukraszdak.TabIndex = 6;
            this.dgvCukraszdak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHelyszinek_CellContentClick);
            // 
            // CID
            // 
            this.CID.HeaderText = "CID";
            this.CID.MinimumWidth = 8;
            this.CID.Name = "CID";
            this.CID.Visible = false;
            this.CID.Width = 150;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Nev";
            this.Nev.MinimumWidth = 8;
            this.Nev.Name = "Nev";
            this.Nev.Width = 150;
            // 
            // DolgozokSzama
            // 
            this.DolgozokSzama.HeaderText = "DolgozokSzama";
            this.DolgozokSzama.MinimumWidth = 8;
            this.DolgozokSzama.Name = "DolgozokSzama";
            this.DolgozokSzama.Width = 150;
            // 
            // HID
            // 
            this.HID.HeaderText = "HID";
            this.HID.MinimumWidth = 8;
            this.HID.Name = "HID";
            this.HID.Visible = false;
            this.HID.Width = 150;
            // 
            // Megye
            // 
            this.Megye.HeaderText = "Megye";
            this.Megye.MinimumWidth = 8;
            this.Megye.Name = "Megye";
            this.Megye.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelect,
            this.menuDelete,
            this.menuUpdate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSelect
            // 
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(87, 32);
            this.menuSelect.Text = "Kereses";
            this.menuSelect.Click += new System.EventHandler(this.keresesToolStripMenuItem_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(73, 32);
            this.menuDelete.Text = "Torles";
            this.menuDelete.Click += new System.EventHandler(this.torlesToolStripMenuItem_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(112, 32);
            this.menuUpdate.Text = "Modositas";
            this.menuUpdate.Click += new System.EventHandler(this.modositasToolStripMenuItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Torles";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(549, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Modosit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbLast
            // 
            this.rbLast.AutoSize = true;
            this.rbLast.Location = new System.Drawing.Point(985, 139);
            this.rbLast.Name = "rbLast";
            this.rbLast.Size = new System.Drawing.Size(67, 24);
            this.rbLast.TabIndex = 10;
            this.rbLast.TabStop = true;
            this.rbLast.Text = "Regi";
            this.rbLast.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(985, 194);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(49, 24);
            this.rbNew.TabIndex = 11;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "Uj";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // rbActual
            // 
            this.rbActual.AutoSize = true;
            this.rbActual.Location = new System.Drawing.Point(985, 246);
            this.rbActual.Name = "rbActual";
            this.rbActual.Size = new System.Drawing.Size(90, 24);
            this.rbActual.TabIndex = 12;
            this.rbActual.TabStop = true;
            this.rbActual.Text = "Aktualis";
            this.rbActual.UseVisualStyleBackColor = true;
            // 
            // tbUpdate
            // 
            this.tbUpdate.Location = new System.Drawing.Point(922, 73);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbUpdate.TabIndex = 13;
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(768, 75);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(134, 20);
            this.lbUpdate.TabIndex = 14;
            this.lbUpdate.Text = "Dolgozok Szama:";
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(1058, 143);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(0, 20);
            this.lbLast.TabIndex = 15;
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Location = new System.Drawing.Point(1040, 196);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(0, 20);
            this.lbNew.TabIndex = 16;
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Location = new System.Drawing.Point(1082, 249);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(0, 20);
            this.lbActual.TabIndex = 17;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(922, 374);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(118, 39);
            this.btBack.TabIndex = 18;
            this.btBack.Text = "Vissza";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(1152, 75);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(0, 20);
            this.lbUserType.TabIndex = 19;
            this.lbUserType.Click += new System.EventHandler(this.lbUserType_Click);
            // 
            // FillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 807);
            this.Controls.Add(this.lbUserType);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbLast);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.tbUpdate);
            this.Controls.Add(this.rbActual);
            this.Controls.Add(this.rbNew);
            this.Controls.Add(this.rbLast);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCukraszdak);
            this.Controls.Add(this.tbCukraszdaFilter);
            this.Controls.Add(this.cbHelyszinekFilter);
            this.Controls.Add(this.lbCukraszdaNev);
            this.Controls.Add(this.lbMegyeNev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FillForm";
            this.Text = "Kezeles";
            this.Load += new System.EventHandler(this.FillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCukraszdak)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbMegyeNev;
        private System.Windows.Forms.Label lbCukraszdaNev;
        private System.Windows.Forms.ComboBox cbHelyszinekFilter;
        private System.Windows.Forms.TextBox tbCukraszdaFilter;
        private System.Windows.Forms.DataGridView dgvCukraszdak;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolgozokSzama;
        private System.Windows.Forms.DataGridViewTextBoxColumn HID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megye;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSelect;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbLast;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbActual;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.Label lbNew;
        private System.Windows.Forms.Label lbActual;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbUserType;
    }
}

