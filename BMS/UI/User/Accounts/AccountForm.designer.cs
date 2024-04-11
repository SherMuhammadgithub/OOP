using BMS.BL;
using BMS.DL;

namespace BMS.UI
{
    partial class AccountForm
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
            this.IpName = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.IpDOB = new System.Windows.Forms.TextBox();
            this.IpPhone = new System.Windows.Forms.TextBox();
            this.IpSSN = new System.Windows.Forms.TextBox();
            this.IpMontlySalary = new System.Windows.Forms.TextBox();
            this.IpIntialDeposite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AccountTypeCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpName
            // 
            this.IpName.Location = new System.Drawing.Point(126, 113);
            this.IpName.Name = "IpName";
            this.IpName.ReadOnly = true;
            this.IpName.Size = new System.Drawing.Size(147, 22);
            this.IpName.TabIndex = 0;
            this.IpName.TextChanged += new System.EventHandler(this.IpName_TextChanged);
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(606, 113);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(147, 22);
            this.IpAddress.TabIndex = 1;
            // 
            // IpDOB
            // 
            this.IpDOB.Location = new System.Drawing.Point(355, 113);
            this.IpDOB.Name = "IpDOB";
            this.IpDOB.Size = new System.Drawing.Size(147, 22);
            this.IpDOB.TabIndex = 2;
            this.IpDOB.TextChanged += new System.EventHandler(this.IpDOB_TextChanged);
            // 
            // IpPhone
            // 
            this.IpPhone.Location = new System.Drawing.Point(126, 223);
            this.IpPhone.Name = "IpPhone";
            this.IpPhone.Size = new System.Drawing.Size(147, 22);
            this.IpPhone.TabIndex = 3;
            // 
            // IpSSN
            // 
            this.IpSSN.Location = new System.Drawing.Point(355, 223);
            this.IpSSN.Name = "IpSSN";
            this.IpSSN.Size = new System.Drawing.Size(147, 22);
            this.IpSSN.TabIndex = 4;
            // 
            // IpMontlySalary
            // 
            this.IpMontlySalary.Location = new System.Drawing.Point(606, 223);
            this.IpMontlySalary.Name = "IpMontlySalary";
            this.IpMontlySalary.Size = new System.Drawing.Size(147, 22);
            this.IpMontlySalary.TabIndex = 5;
            // 
            // IpIntialDeposite
            // 
            this.IpIntialDeposite.Location = new System.Drawing.Point(227, 340);
            this.IpIntialDeposite.Name = "IpIntialDeposite";
            this.IpIntialDeposite.Size = new System.Drawing.Size(147, 22);
            this.IpIntialDeposite.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = " DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = " Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = " Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = " SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = " MonthlySalary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = " Intial Deposite";
            // 
            // AddBtn
            // 
            this.AddBtn.Enabled = false;
            this.AddBtn.Location = new System.Drawing.Point(264, 458);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(301, 29);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = " Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AccountTypeCb
            // 
            this.AccountTypeCb.FormattingEnabled = true;
            this.AccountTypeCb.Items.AddRange(new object[] {
            "savings",
            "checking"});
            this.AccountTypeCb.Location = new System.Drawing.Point(473, 338);
            this.AccountTypeCb.Name = "AccountTypeCb";
            this.AccountTypeCb.Size = new System.Drawing.Size(121, 24);
            this.AccountTypeCb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Account Type";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 575);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AccountTypeCb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpIntialDeposite);
            this.Controls.Add(this.IpMontlySalary);
            this.Controls.Add(this.IpSSN);
            this.Controls.Add(this.IpPhone);
            this.Controls.Add(this.IpDOB);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.IpName);
            this.Name = "AccountForm";
            this.Text = "UserPannel";
            this.Load += new System.EventHandler(this.UserPannel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.TextBox IpDOB;
        private System.Windows.Forms.TextBox IpPhone;
        private System.Windows.Forms.TextBox IpSSN;
        private System.Windows.Forms.TextBox IpMontlySalary;
        private System.Windows.Forms.TextBox IpIntialDeposite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox AccountTypeCb;
        private System.Windows.Forms.Label label8;
    }
}