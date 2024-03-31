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
            this.label1 = new System.Windows.Forms.Label();
            this.DepositeBtn = new System.Windows.Forms.Button();
            this.WithDrawBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.AccountCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(146, 101);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(130, 22);
            this.IpAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Amount";
            // 
            // DepositeBtn
            // 
            this.DepositeBtn.Location = new System.Drawing.Point(143, 185);
            this.DepositeBtn.Name = "DepositeBtn";
            this.DepositeBtn.Size = new System.Drawing.Size(92, 25);
            this.DepositeBtn.TabIndex = 7;
            this.DepositeBtn.Text = "Deposite";
            this.DepositeBtn.UseVisualStyleBackColor = true;
            this.DepositeBtn.Click += new System.EventHandler(this.DepositeBtn_Click);
            // 
            // WithDrawBtn
            // 
            this.WithDrawBtn.Location = new System.Drawing.Point(273, 185);
            this.WithDrawBtn.Name = "WithDrawBtn";
            this.WithDrawBtn.Size = new System.Drawing.Size(92, 25);
            this.WithDrawBtn.TabIndex = 8;
            this.WithDrawBtn.Text = "WithDraw";
            this.WithDrawBtn.UseVisualStyleBackColor = true;
            this.WithDrawBtn.Click += new System.EventHandler(this.WithDrawBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(393, 185);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(92, 25);
            this.TransferBtn.TabIndex = 9;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.Location = new System.Drawing.Point(352, 54);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(96, 16);
            this.AccountLbl.TabIndex = 11;
            this.AccountLbl.Text = "Select Account";
            this.AccountLbl.Click += new System.EventHandler(this.AccountLbl_Click);
            // 
            // AccountCb
            // 
            this.AccountCb.FormattingEnabled = true;
            this.AccountCb.Location = new System.Drawing.Point(355, 99);
            this.AccountCb.Name = "AccountCb";
            this.AccountCb.Size = new System.Drawing.Size(121, 24);
            this.AccountCb.TabIndex = 12;
            // 
            // MoneyActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.AccountCb);
            this.Controls.Add(this.AccountLbl);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.WithDrawBtn);
            this.Controls.Add(this.DepositeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpAmount);
            this.Name = "MoneyActions";
            this.Text = "MoneyActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DepositeBtn;
        private System.Windows.Forms.Button WithDrawBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.ComboBox AccountCb;
    }
}