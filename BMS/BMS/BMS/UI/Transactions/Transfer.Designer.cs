namespace BMS.UI
{
    partial class Transfer
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
            this.AccountCb = new System.Windows.Forms.ComboBox();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.IpAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountCb
            // 
            this.AccountCb.FormattingEnabled = true;
            this.AccountCb.Location = new System.Drawing.Point(306, 189);
            this.AccountCb.Name = "AccountCb";
            this.AccountCb.Size = new System.Drawing.Size(121, 24);
            this.AccountCb.TabIndex = 15;
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.Location = new System.Drawing.Point(313, 149);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(96, 16);
            this.AccountLbl.TabIndex = 14;
            this.AccountLbl.Text = "Select Account";
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(317, 283);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(92, 25);
            this.TransferBtn.TabIndex = 13;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(254, 239);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(219, 22);
            this.IpAmount.TabIndex = 16;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IpAmount);
            this.Controls.Add(this.AccountCb);
            this.Controls.Add(this.AccountLbl);
            this.Controls.Add(this.TransferBtn);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountCb;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox IpAmount;
    }
}