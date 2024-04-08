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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IpAmount = new System.Windows.Forms.TextBox();
            this.IpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IpMonthlyPay = new System.Windows.Forms.TextBox();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Full Name";
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(448, 124);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(147, 22);
            this.IpAmount.TabIndex = 10;
            // 
            // IpName
            // 
            this.IpName.Location = new System.Drawing.Point(219, 124);
            this.IpName.Name = "IpName";
            this.IpName.ReadOnly = true;
            this.IpName.Size = new System.Drawing.Size(147, 22);
            this.IpName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Monthly Payment";
            // 
            // IpMonthlyPay
            // 
            this.IpMonthlyPay.Location = new System.Drawing.Point(311, 244);
            this.IpMonthlyPay.Name = "IpMonthlyPay";
            this.IpMonthlyPay.Size = new System.Drawing.Size(147, 22);
            this.IpMonthlyPay.TabIndex = 13;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(230, 337);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(301, 29);
            this.ApplyBtn.TabIndex = 15;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IpMonthlyPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpAmount);
            this.Controls.Add(this.IpName);
            this.Name = "LoanForm";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpAmount;
        private System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IpMonthlyPay;
        private System.Windows.Forms.Button ApplyBtn;
    }
}