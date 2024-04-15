namespace BMS.UI
{
    partial class MoneyActions
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
            this.IpAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignUpPgLink = new System.Windows.Forms.LinkLabel();
            this.DepositBtn = new FontAwesome.Sharp.IconButton();
            this.withdraw = new FontAwesome.Sharp.IconButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(172, 154);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(219, 22);
            this.IpAmount.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.validateAmount);
            this.panel1.Controls.Add(this.SignUpPgLink);
            this.panel1.Controls.Add(this.DepositBtn);
            this.panel1.Controls.Add(this.withdraw);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Controls.Add(this.IpAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 327);
            this.panel1.TabIndex = 10;
            // 
            // SignUpPgLink
            // 
            this.SignUpPgLink.AutoSize = true;
            this.SignUpPgLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.SignUpPgLink.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPgLink.ForeColor = System.Drawing.Color.White;
            this.SignUpPgLink.LinkColor = System.Drawing.Color.White;
            this.SignUpPgLink.Location = new System.Drawing.Point(373, 288);
            this.SignUpPgLink.Name = "SignUpPgLink";
            this.SignUpPgLink.Size = new System.Drawing.Size(200, 23);
            this.SignUpPgLink.TabIndex = 62;
            this.SignUpPgLink.TabStop = true;
            this.SignUpPgLink.Text = "Wants to transfer? Transfer";
            this.SignUpPgLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpPgLink_LinkClicked);
            // 
            // DepositBtn
            // 
            this.DepositBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DepositBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.DepositBtn.FlatAppearance.BorderSize = 0;
            this.DepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositBtn.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.ForeColor = System.Drawing.Color.White;
            this.DepositBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.DepositBtn.IconColor = System.Drawing.Color.White;
            this.DepositBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DepositBtn.IconSize = 32;
            this.DepositBtn.Location = new System.Drawing.Point(99, 223);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DepositBtn.Size = new System.Drawing.Size(168, 36);
            this.DepositBtn.TabIndex = 61;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepositBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DepositBtn.UseMnemonic = false;
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // withdraw
            // 
            this.withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.withdraw.FlatAppearance.BorderSize = 0;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.withdraw.IconColor = System.Drawing.Color.White;
            this.withdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.withdraw.IconSize = 32;
            this.withdraw.Location = new System.Drawing.Point(301, 223);
            this.withdraw.Name = "withdraw";
            this.withdraw.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.withdraw.Size = new System.Drawing.Size(168, 36);
            this.withdraw.TabIndex = 59;
            this.withdraw.Text = "Withdraw";
            this.withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.withdraw.UseMnemonic = false;
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(236, 114);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(100, 25);
            this.guna2HtmlLabel1.TabIndex = 51;
            this.guna2HtmlLabel1.Text = "Enter Amount";
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.White;
            this.BalanceLbl.Location = new System.Drawing.Point(172, 34);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(240, 29);
            this.BalanceLbl.TabIndex = 49;
            this.BalanceLbl.Text = "Deposit or Withdraw Amount";
            // 
            // validateAmount
            // 
            this.validateAmount.BackColor = System.Drawing.Color.Transparent;
            this.validateAmount.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateAmount.ForeColor = System.Drawing.Color.Red;
            this.validateAmount.Location = new System.Drawing.Point(172, 182);
            this.validateAmount.Name = "validateAmount";
            this.validateAmount.Size = new System.Drawing.Size(126, 25);
            this.validateAmount.TabIndex = 65;
            this.validateAmount.Text = "Must be a number";
            this.validateAmount.Visible = false;
            // 
            // MoneyActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 347);
            this.Controls.Add(this.panel1);
            this.Name = "MoneyActions";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyActions";
            this.Load += new System.EventHandler(this.MoneyActions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IpAmount;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconButton DepositBtn;
        private FontAwesome.Sharp.IconButton withdraw;
        private System.Windows.Forms.LinkLabel SignUpPgLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateAmount;
    }
}