namespace RS2_TourismAgency.WinUI
{
    partial class FrmKorisniciList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DGW_Korisnici = new System.Windows.Forms.DataGridView();
            this.ImeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleNamesD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TBUSERNAME = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.TBIME = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGW_Korisnici
            // 
            this.DGW_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Korisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImeD,
            this.PrezimeD,
            this.RoleNamesD,
            this.StatusD});
            this.DGW_Korisnici.Location = new System.Drawing.Point(69, 80);
            this.DGW_Korisnici.Name = "DGW_Korisnici";
            this.DGW_Korisnici.RowTemplate.Height = 25;
            this.DGW_Korisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_Korisnici.Size = new System.Drawing.Size(657, 322);
            this.DGW_Korisnici.TabIndex = 1;
            this.DGW_Korisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Korisnici_CellContentClick);
            this.DGW_Korisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Korisnici_CellDoubleClick);
            // 
            // ImeD
            // 
            this.ImeD.DataPropertyName = "Ime";
            this.ImeD.HeaderText = "Ime";
            this.ImeD.Name = "ImeD";
            // 
            // PrezimeD
            // 
            this.PrezimeD.DataPropertyName = "Prezime";
            this.PrezimeD.HeaderText = "Prezime";
            this.PrezimeD.Name = "PrezimeD";
            // 
            // RoleNamesD
            // 
            this.RoleNamesD.DataPropertyName = "RoleNames";
            this.RoleNamesD.HeaderText = "RoleNames";
            this.RoleNamesD.Name = "RoleNamesD";
            // 
            // StatusD
            // 
            this.StatusD.DataPropertyName = "Status";
            this.StatusD.HeaderText = "Status";
            this.StatusD.Name = "StatusD";
            // 
            // TBUSERNAME
            // 
            this.TBUSERNAME.Location = new System.Drawing.Point(69, 48);
            this.TBUSERNAME.Name = "TBUSERNAME";
            this.TBUSERNAME.Size = new System.Drawing.Size(203, 23);
            this.TBUSERNAME.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(69, 21);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(62, 15);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(291, 21);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(27, 15);
            this.Ime.TabIndex = 5;
            this.Ime.Text = "Ime";
            // 
            // TBIME
            // 
            this.TBIME.Location = new System.Drawing.Point(291, 48);
            this.TBIME.Name = "TBIME";
            this.TBIME.Size = new System.Drawing.Size(203, 23);
            this.TBIME.TabIndex = 4;
            // 
            // FrmKorisniciList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.TBIME);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.TBUSERNAME);
            this.Controls.Add(this.DGW_Korisnici);
            this.Controls.Add(this.button1);
            this.Name = "FrmKorisniciList";
            this.Text = "FormKorisnici";
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Korisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView DGW_Korisnici;
        private TextBox TBUSERNAME;
        private Label UserName;
        private Label Ime;
        private TextBox TBIME;
        private DataGridViewTextBoxColumn ImeD;
        private DataGridViewTextBoxColumn PrezimeD;
        private DataGridViewTextBoxColumn RoleNamesD;
        private DataGridViewCheckBoxColumn StatusD;
    }
}