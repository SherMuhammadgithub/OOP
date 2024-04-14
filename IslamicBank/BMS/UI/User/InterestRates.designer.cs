namespace BMS
{
    partial class InterestRates
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InterestRateLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BankFeeLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SignUpPgLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.SignUpPgLink);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.BankFeeLbl);
            this.panel1.Controls.Add(this.InterestRateLbl);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 399);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.White;
            this.BalanceLbl.Location = new System.Drawing.Point(125, 83);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(272, 29);
            this.BalanceLbl.TabIndex = 50;
            this.BalanceLbl.Text = "Your Monthly Fee & Interest Rate";
            // 
            // InterestRateLbl
            // 
            this.InterestRateLbl.BackColor = System.Drawing.Color.Transparent;
            this.InterestRateLbl.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.InterestRateLbl.Location = new System.Drawing.Point(285, 166);
            this.InterestRateLbl.Name = "InterestRateLbl";
            this.InterestRateLbl.Size = new System.Drawing.Size(59, 25);
            this.InterestRateLbl.TabIndex = 54;
            this.InterestRateLbl.Text = "Amount";
            // 
            // BankFeeLbl
            // 
            this.BankFeeLbl.BackColor = System.Drawing.Color.Transparent;
            this.BankFeeLbl.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankFeeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.BankFeeLbl.Location = new System.Drawing.Point(285, 228);
            this.BankFeeLbl.Name = "BankFeeLbl";
            this.BankFeeLbl.Size = new System.Drawing.Size(59, 25);
            this.BankFeeLbl.TabIndex = 55;
            this.BankFeeLbl.Text = "Amount";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(155, 224);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 29);
            this.guna2HtmlLabel1.TabIndex = 56;
            this.guna2HtmlLabel1.Text = "Bank Fee:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(155, 162);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 29);
            this.guna2HtmlLabel2.TabIndex = 57;
            this.guna2HtmlLabel2.Text = "Interest Rate:";
            // 
            // SignUpPgLink
            // 
            this.SignUpPgLink.AutoSize = true;
            this.SignUpPgLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.SignUpPgLink.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPgLink.ForeColor = System.Drawing.Color.White;
            this.SignUpPgLink.LinkColor = System.Drawing.Color.White;
            this.SignUpPgLink.Location = new System.Drawing.Point(24, 333);
            this.SignUpPgLink.Name = "SignUpPgLink";
            this.SignUpPgLink.Size = new System.Drawing.Size(482, 23);
            this.SignUpPgLink.TabIndex = 63;
            this.SignUpPgLink.TabStop = true;
            this.SignUpPgLink.Text = "These Interest Rate and Bank Fee is Calculated based on your Balance";
            // 
            // InterestRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 419);
            this.Controls.Add(this.panel1);
            this.Name = "InterestRates";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterestRates";
            this.Load += new System.EventHandler(this.InterestRates_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel BankFeeLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel InterestRateLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.LinkLabel SignUpPgLink;
    }
}