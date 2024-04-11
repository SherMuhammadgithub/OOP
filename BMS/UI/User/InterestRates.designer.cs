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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IpInterestRate = new System.Windows.Forms.TextBox();
            this.IpBankFee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Interest Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Bank Fees";
            // 
            // IpInterestRate
            // 
            this.IpInterestRate.Location = new System.Drawing.Point(443, 238);
            this.IpInterestRate.Name = "IpInterestRate";
            this.IpInterestRate.Size = new System.Drawing.Size(147, 22);
            this.IpInterestRate.TabIndex = 40;
            // 
            // IpBankFee
            // 
            this.IpBankFee.Location = new System.Drawing.Point(214, 238);
            this.IpBankFee.Name = "IpBankFee";
            this.IpBankFee.Size = new System.Drawing.Size(147, 22);
            this.IpBankFee.TabIndex = 39;
            // 
            // InterestRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpInterestRate);
            this.Controls.Add(this.IpBankFee);
            this.Name = "InterestRates";
            this.Text = "InterestRates";
            this.Load += new System.EventHandler(this.InterestRates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpInterestRate;
        private System.Windows.Forms.TextBox IpBankFee;
    }
}