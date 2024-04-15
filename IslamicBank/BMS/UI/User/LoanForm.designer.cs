namespace BMS.UI
{
    partial class LoanForm
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
            this.IpName = new System.Windows.Forms.TextBox();
            this.IpMonthlyPay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyBtn = new FontAwesome.Sharp.IconButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateMonthlyPay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(283, 190);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(147, 22);
            this.IpAmount.TabIndex = 10;
            // 
            // IpName
            // 
            this.IpName.Location = new System.Drawing.Point(70, 190);
            this.IpName.Name = "IpName";
            this.IpName.ReadOnly = true;
            this.IpName.Size = new System.Drawing.Size(144, 22);
            this.IpName.TabIndex = 9;
            // 
            // IpMonthlyPay
            // 
            this.IpMonthlyPay.Location = new System.Drawing.Point(165, 286);
            this.IpMonthlyPay.Name = "IpMonthlyPay";
            this.IpMonthlyPay.Size = new System.Drawing.Size(165, 22);
            this.IpMonthlyPay.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.validateMonthlyPay);
            this.panel1.Controls.Add(this.validateAmount);
            this.panel1.Controls.Add(this.ApplyBtn);
            this.panel1.Controls.Add(this.IpMonthlyPay);
            this.panel1.Controls.Add(this.IpAmount);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.IpName);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 426);
            this.panel1.TabIndex = 16;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.ApplyBtn.FlatAppearance.BorderSize = 0;
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.ForeColor = System.Drawing.Color.White;
            this.ApplyBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ApplyBtn.IconColor = System.Drawing.Color.White;
            this.ApplyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ApplyBtn.IconSize = 32;
            this.ApplyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyBtn.Location = new System.Drawing.Point(114, 355);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ApplyBtn.Size = new System.Drawing.Size(251, 36);
            this.ApplyBtn.TabIndex = 63;
            this.ApplyBtn.Text = "Apply Loan";
            this.ApplyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ApplyBtn.UseMnemonic = false;
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click_1);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(165, 241);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(165, 25);
            this.guna2HtmlLabel3.TabIndex = 55;
            this.guna2HtmlLabel3.Text = "Enter Monthly Payment";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(283, 147);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(100, 25);
            this.guna2HtmlLabel2.TabIndex = 54;
            this.guna2HtmlLabel2.Text = "Enter Amount";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(70, 147);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(160, 25);
            this.guna2HtmlLabel1.TabIndex = 53;
            this.guna2HtmlLabel1.Text = "Account Holder\'s Name";
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.White;
            this.BalanceLbl.Location = new System.Drawing.Point(185, 62);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(136, 29);
            this.BalanceLbl.TabIndex = 50;
            this.BalanceLbl.Text = "Apply For a Loan";
            // 
            // validateAmount
            // 
            this.validateAmount.BackColor = System.Drawing.Color.Transparent;
            this.validateAmount.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateAmount.ForeColor = System.Drawing.Color.Red;
            this.validateAmount.Location = new System.Drawing.Point(285, 218);
            this.validateAmount.Name = "validateAmount";
            this.validateAmount.Size = new System.Drawing.Size(126, 25);
            this.validateAmount.TabIndex = 64;
            this.validateAmount.Text = "Must be a number";
            this.validateAmount.Visible = false;
            // 
            // validateMonthlyPay
            // 
            this.validateMonthlyPay.BackColor = System.Drawing.Color.Transparent;
            this.validateMonthlyPay.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateMonthlyPay.ForeColor = System.Drawing.Color.Red;
            this.validateMonthlyPay.Location = new System.Drawing.Point(165, 314);
            this.validateMonthlyPay.Name = "validateMonthlyPay";
            this.validateMonthlyPay.Size = new System.Drawing.Size(126, 25);
            this.validateMonthlyPay.TabIndex = 65;
            this.validateMonthlyPay.Text = "Must be a number";
            this.validateMonthlyPay.Visible = false;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 446);
            this.Controls.Add(this.panel1);
            this.Name = "LoanForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IpAmount;
        private System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.TextBox IpMonthlyPay;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private FontAwesome.Sharp.IconButton ApplyBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateMonthlyPay;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateAmount;
    }
}