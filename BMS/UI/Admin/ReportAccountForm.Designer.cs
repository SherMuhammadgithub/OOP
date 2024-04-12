namespace BMS.UI.Admin
{
    partial class ReportAccountForm
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
            this.IpReason = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IpRepAccountName = new System.Windows.Forms.TextBox();
            this.ReportBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // IpReason
            // 
            this.IpReason.Location = new System.Drawing.Point(202, 211);
            this.IpReason.Name = "IpReason";
            this.IpReason.Size = new System.Drawing.Size(100, 22);
            this.IpReason.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(202, 77);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(114, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Report An Account";
            // 
            // IpRepAccountName
            // 
            this.IpRepAccountName.Location = new System.Drawing.Point(202, 137);
            this.IpRepAccountName.Name = "IpRepAccountName";
            this.IpRepAccountName.ReadOnly = true;
            this.IpRepAccountName.Size = new System.Drawing.Size(100, 22);
            this.IpRepAccountName.TabIndex = 2;
            // 
            // ReportBtn
            // 
            this.ReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ReportBtn.IconColor = System.Drawing.Color.Black;
            this.ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportBtn.Location = new System.Drawing.Point(212, 276);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(75, 23);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // ReportAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 387);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.IpRepAccountName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.IpReason);
            this.Name = "ReportAccount";
            this.Text = "ReportAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpReason;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public System.Windows.Forms.TextBox IpRepAccountName;
        private FontAwesome.Sharp.IconButton ReportBtn;
    }
}