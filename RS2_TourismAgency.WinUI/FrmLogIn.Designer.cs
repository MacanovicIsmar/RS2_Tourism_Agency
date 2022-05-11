namespace RS2_TourismAgency.WinUI
{
    partial class FrmLogIn
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
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_PassWord = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.BT_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(53, 42);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(100, 23);
            this.TB_UserName.TabIndex = 0;
            // 
            // TB_PassWord
            // 
            this.TB_PassWord.Location = new System.Drawing.Point(53, 115);
            this.TB_PassWord.Name = "TB_PassWord";
            this.TB_PassWord.Size = new System.Drawing.Size(100, 23);
            this.TB_PassWord.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(53, 22);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(62, 15);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Location = new System.Drawing.Point(53, 97);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(59, 15);
            this.LB_Password.TabIndex = 3;
            this.LB_Password.Text = "PassWord";
            // 
            // BT_LogIn
            // 
            this.BT_LogIn.Location = new System.Drawing.Point(53, 171);
            this.BT_LogIn.Name = "BT_LogIn";
            this.BT_LogIn.Size = new System.Drawing.Size(100, 23);
            this.BT_LogIn.TabIndex = 4;
            this.BT_LogIn.Text = "LogIn";
            this.BT_LogIn.UseVisualStyleBackColor = true;
            this.BT_LogIn.Click += new System.EventHandler(this.BT_LogIn_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 236);
            this.Controls.Add(this.BT_LogIn);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.TB_PassWord);
            this.Controls.Add(this.TB_UserName);
            this.Name = "FrmLogIn";
            this.Text = "FrmLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_UserName;
        private TextBox TB_PassWord;
        private Label UserName;
        private Label LB_Password;
        private Button BT_LogIn;
    }
}