namespace RS2_TourismAgency.WinUI
{
    partial class FrmPutovanjaList
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.Putovanja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Putovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(695, 32);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Putovanja
            // 
            this.Putovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Putovanja.Location = new System.Drawing.Point(39, 70);
            this.Putovanja.Name = "Putovanja";
            this.Putovanja.RowTemplate.Height = 25;
            this.Putovanja.Size = new System.Drawing.Size(731, 355);
            this.Putovanja.TabIndex = 1;
            // 
            // FrmPutovanjaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Putovanja);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmPutovanjaList";
            this.Text = "FrmPutovanjaList";
            ((System.ComponentModel.ISupportInitialize)(this.Putovanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnShow;
        private DataGridView Putovanja;
    }
}