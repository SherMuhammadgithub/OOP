﻿namespace BMS.UI
{
    partial class SingleUser
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.IpAccountNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IpIntialDeposite = new System.Windows.Forms.TextBox();
            this.IpMontlySalary = new System.Windows.Forms.TextBox();
            this.IpSSN = new System.Windows.Forms.TextBox();
            this.IpPhone = new System.Windows.Forms.TextBox();
            this.IpDOB = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.IpName = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.noTransactionsLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Location = new System.Drawing.Point(12, 21);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(87, 18);
            this.BalanceLbl.TabIndex = 83;
            this.BalanceLbl.Text = "Total Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Account Number";
            // 
            // IpAccountNum
            // 
            this.IpAccountNum.Location = new System.Drawing.Point(221, 221);
            this.IpAccountNum.Name = "IpAccountNum";
            this.IpAccountNum.ReadOnly = true;
            this.IpAccountNum.Size = new System.Drawing.Size(147, 22);
            this.IpAccountNum.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = " Intial Deposite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = " MonthlySalary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = " SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = " Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = " Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = " DOB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Full Name";
            // 
            // IpIntialDeposite
            // 
            this.IpIntialDeposite.Location = new System.Drawing.Point(37, 221);
            this.IpIntialDeposite.Name = "IpIntialDeposite";
            this.IpIntialDeposite.Size = new System.Drawing.Size(147, 22);
            this.IpIntialDeposite.TabIndex = 72;
            // 
            // IpMontlySalary
            // 
            this.IpMontlySalary.Location = new System.Drawing.Point(221, 413);
            this.IpMontlySalary.Name = "IpMontlySalary";
            this.IpMontlySalary.Size = new System.Drawing.Size(147, 22);
            this.IpMontlySalary.TabIndex = 71;
            // 
            // IpSSN
            // 
            this.IpSSN.Location = new System.Drawing.Point(37, 413);
            this.IpSSN.Name = "IpSSN";
            this.IpSSN.ReadOnly = true;
            this.IpSSN.Size = new System.Drawing.Size(147, 22);
            this.IpSSN.TabIndex = 70;
            // 
            // IpPhone
            // 
            this.IpPhone.Location = new System.Drawing.Point(221, 129);
            this.IpPhone.Name = "IpPhone";
            this.IpPhone.Size = new System.Drawing.Size(147, 22);
            this.IpPhone.TabIndex = 69;
            // 
            // IpDOB
            // 
            this.IpDOB.Location = new System.Drawing.Point(37, 318);
            this.IpDOB.Name = "IpDOB";
            this.IpDOB.Size = new System.Drawing.Size(147, 22);
            this.IpDOB.TabIndex = 68;
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(221, 318);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(147, 22);
            this.IpAddress.TabIndex = 67;
            // 
            // IpName
            // 
            this.IpName.Location = new System.Drawing.Point(37, 126);
            this.IpName.Name = "IpName";
            this.IpName.Size = new System.Drawing.Size(147, 22);
            this.IpName.TabIndex = 66;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(404, 79);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Amount";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(416, 300);
            this.chart1.TabIndex = 84;
            this.chart1.Text = " ";
            // 
            // noTransactionsLabel
            // 
            this.noTransactionsLabel.AutoSize = true;
            this.noTransactionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.noTransactionsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTransactionsLabel.Location = new System.Drawing.Point(433, 222);
            this.noTransactionsLabel.Name = "noTransactionsLabel";
            this.noTransactionsLabel.Size = new System.Drawing.Size(282, 21);
            this.noTransactionsLabel.TabIndex = 85;
            this.noTransactionsLabel.Text = "No Transactions History";
            this.noTransactionsLabel.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeleteBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.Location = new System.Drawing.Point(529, 427);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 23);
            this.DeleteBtn.TabIndex = 86;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SingleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 510);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.noTransactionsLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BalanceLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IpAccountNum);
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
            this.Name = "SingleUser";
            this.Text = "SingleUser";
            this.Load += new System.EventHandler(this.SingleUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox IpAccountNum;
        public System.Windows.Forms.TextBox IpIntialDeposite;
        public System.Windows.Forms.TextBox IpMontlySalary;
        public System.Windows.Forms.TextBox IpSSN;
        public System.Windows.Forms.TextBox IpPhone;
        public System.Windows.Forms.TextBox IpDOB;
        public System.Windows.Forms.TextBox IpAddress;
        public System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private System.Windows.Forms.Label noTransactionsLabel;
        private FontAwesome.Sharp.IconButton DeleteBtn;
    }
}