namespace BMS.UI.User
{
    partial class Reported
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
            this.noTransactionsLabel = new System.Windows.Forms.Label();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ReasonLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SignUpPgLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.SignUpPgLink);
            this.panel1.Controls.Add(this.ReasonLbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Controls.Add(this.noTransactionsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 377);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // noTransactionsLabel
            // 
            this.noTransactionsLabel.AutoSize = true;
            this.noTransactionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.noTransactionsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTransactionsLabel.ForeColor = System.Drawing.Color.Red;
            this.noTransactionsLabel.Location = new System.Drawing.Point(43, 40);
            this.noTransactionsLabel.Name = "noTransactionsLabel";
            this.noTransactionsLabel.Size = new System.Drawing.Size(373, 21);
            this.noTransactionsLabel.TabIndex = 87;
            this.noTransactionsLabel.Text = "Your Account has been Reported";
            this.noTransactionsLabel.Visible = false;
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.BalanceLbl.Location = new System.Drawing.Point(47, 99);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(128, 29);
            this.BalanceLbl.TabIndex = 88;
            this.BalanceLbl.Text = "Account Holder";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 201);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(61, 29);
            this.guna2HtmlLabel1.TabIndex = 89;
            this.guna2HtmlLabel1.Text = "Reason";
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(47, 154);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(158, 25);
            this.NameLbl.TabIndex = 90;
            this.NameLbl.Text = "Sher Muhammad Iqbal";
            // 
            // ReasonLbl
            // 
            this.ReasonLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReasonLbl.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonLbl.ForeColor = System.Drawing.Color.White;
            this.ReasonLbl.Location = new System.Drawing.Point(47, 248);
            this.ReasonLbl.Name = "ReasonLbl";
            this.ReasonLbl.Size = new System.Drawing.Size(44, 25);
            this.ReasonLbl.TabIndex = 91;
            this.ReasonLbl.Text = "Fraud";
            // 
            // SignUpPgLink
            // 
            this.SignUpPgLink.AutoSize = true;
            this.SignUpPgLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.SignUpPgLink.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPgLink.ForeColor = System.Drawing.Color.White;
            this.SignUpPgLink.LinkColor = System.Drawing.Color.White;
            this.SignUpPgLink.Location = new System.Drawing.Point(60, 337);
            this.SignUpPgLink.Name = "SignUpPgLink";
            this.SignUpPgLink.Size = new System.Drawing.Size(332, 23);
            this.SignUpPgLink.TabIndex = 92;
            this.SignUpPgLink.TabStop = true;
            this.SignUpPgLink.Text = "You were Reported by the Bank Administration";
            this.SignUpPgLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reported
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 397);
            this.Controls.Add(this.panel1);
            this.Name = "Reported";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Reported";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noTransactionsLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private System.Windows.Forms.LinkLabel SignUpPgLink;
        public Guna.UI2.WinForms.Guna2HtmlLabel ReasonLbl;
        public Guna.UI2.WinForms.Guna2HtmlLabel NameLbl;
    }
}