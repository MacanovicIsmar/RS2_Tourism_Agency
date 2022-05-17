namespace RS2_TourismAgency.WinUI
{
    partial class FormKorisniciDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Mail = new System.Windows.Forms.TextBox();
            this.TB_Prezime = new System.Windows.Forms.TextBox();
            this.TB_Ime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_CONFIRMATION = new System.Windows.Forms.TextBox();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.CHECKLISTBOX_Uloge = new System.Windows.Forms.CheckedListBox();
            this.CB_Status = new System.Windows.Forms.CheckBox();
            this.BT_Sacuvaj = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Mail);
            this.groupBox1.Controls.Add(this.TB_Prezime);
            this.groupBox1.Controls.Add(this.TB_Ime);
            this.groupBox1.Location = new System.Drawing.Point(55, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // TB_Mail
            // 
            this.TB_Mail.Location = new System.Drawing.Point(113, 108);
            this.TB_Mail.Name = "TB_Mail";
            this.TB_Mail.Size = new System.Drawing.Size(215, 23);
            this.TB_Mail.TabIndex = 2;
            // 
            // TB_Prezime
            // 
            this.TB_Prezime.Location = new System.Drawing.Point(113, 71);
            this.TB_Prezime.Name = "TB_Prezime";
            this.TB_Prezime.Size = new System.Drawing.Size(215, 23);
            this.TB_Prezime.TabIndex = 1;
            // 
            // TB_Ime
            // 
            this.TB_Ime.Location = new System.Drawing.Point(113, 31);
            this.TB_Ime.Name = "TB_Ime";
            this.TB_Ime.Size = new System.Drawing.Size(215, 23);
            this.TB_Ime.TabIndex = 0;
            this.TB_Ime.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Ime_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_CONFIRMATION);
            this.groupBox2.Controls.Add(this.TB_PASSWORD);
            this.groupBox2.Controls.Add(this.TB_USERNAME);
            this.groupBox2.Location = new System.Drawing.Point(55, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "PassWord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "UserName";
            // 
            // TB_CONFIRMATION
            // 
            this.TB_CONFIRMATION.Location = new System.Drawing.Point(113, 108);
            this.TB_CONFIRMATION.Name = "TB_CONFIRMATION";
            this.TB_CONFIRMATION.Size = new System.Drawing.Size(215, 23);
            this.TB_CONFIRMATION.TabIndex = 2;
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Location = new System.Drawing.Point(113, 71);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.Size = new System.Drawing.Size(215, 23);
            this.TB_PASSWORD.TabIndex = 1;
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.Location = new System.Drawing.Point(113, 31);
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.Size = new System.Drawing.Size(215, 23);
            this.TB_USERNAME.TabIndex = 0;
            // 
            // CHECKLISTBOX_Uloge
            // 
            this.CHECKLISTBOX_Uloge.FormattingEnabled = true;
            this.CHECKLISTBOX_Uloge.Location = new System.Drawing.Point(55, 406);
            this.CHECKLISTBOX_Uloge.Name = "CHECKLISTBOX_Uloge";
            this.CHECKLISTBOX_Uloge.Size = new System.Drawing.Size(126, 112);
            this.CHECKLISTBOX_Uloge.TabIndex = 2;
            this.CHECKLISTBOX_Uloge.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CB_Status
            // 
            this.CB_Status.AutoSize = true;
            this.CB_Status.Location = new System.Drawing.Point(216, 406);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(58, 19);
            this.CB_Status.TabIndex = 3;
            this.CB_Status.Text = "Status";
            this.CB_Status.UseVisualStyleBackColor = true;
            // 
            // BT_Sacuvaj
            // 
            this.BT_Sacuvaj.Location = new System.Drawing.Point(329, 512);
            this.BT_Sacuvaj.Name = "BT_Sacuvaj";
            this.BT_Sacuvaj.Size = new System.Drawing.Size(99, 41);
            this.BT_Sacuvaj.TabIndex = 4;
            this.BT_Sacuvaj.Text = "Sacuvaj";
            this.BT_Sacuvaj.UseVisualStyleBackColor = true;
            this.BT_Sacuvaj.Click += new System.EventHandler(this.BT_Sacuvaj_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormKorisniciDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 576);
            this.Controls.Add(this.BT_Sacuvaj);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.CHECKLISTBOX_Uloge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKorisniciDetails";
            this.Text = "FormKorisniciDetails";
            this.Load += new System.EventHandler(this.FormKorisniciDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TB_Mail;
        private TextBox TB_Prezime;
        private TextBox TB_Ime;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TB_CONFIRMATION;
        private TextBox TB_PASSWORD;
        private TextBox TB_USERNAME;
        private CheckedListBox CHECKLISTBOX_Uloge;
        private CheckBox CB_Status;
        private Button BT_Sacuvaj;
        private ErrorProvider ErrorProvider;
    }
}