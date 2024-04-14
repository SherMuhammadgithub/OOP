namespace BMS.UI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.IpAccountNum = new System.Windows.Forms.TextBox();
            this.IpIntialDeposite = new System.Windows.Forms.TextBox();
            this.IpMontlySalary = new System.Windows.Forms.TextBox();
            this.IpSSN = new System.Windows.Forms.TextBox();
            this.IpPhone = new System.Windows.Forms.TextBox();
            this.IpDOB = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.IpName = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.noTransactionsLabel = new System.Windows.Forms.Label();
            this.IpMonthlyPay = new System.Windows.Forms.TextBox();
            this.IpLoan = new System.Windows.Forms.TextBox();
            this.ReportedLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.IpLoanBtn = new FontAwesome.Sharp.IconButton();
            this.UnreportBtn = new FontAwesome.Sharp.IconButton();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.balance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpAccountNum
            // 
            this.IpAccountNum.Location = new System.Drawing.Point(221, 221);
            this.IpAccountNum.Name = "IpAccountNum";
            this.IpAccountNum.ReadOnly = true;
            this.IpAccountNum.Size = new System.Drawing.Size(147, 22);
            this.IpAccountNum.TabIndex = 80;
            // 
            // IpIntialDeposite
            // 
            this.IpIntialDeposite.Location = new System.Drawing.Point(37, 221);
            this.IpIntialDeposite.Name = "IpIntialDeposite";
            this.IpIntialDeposite.ReadOnly = true;
            this.IpIntialDeposite.Size = new System.Drawing.Size(147, 22);
            this.IpIntialDeposite.TabIndex = 72;
            this.IpIntialDeposite.TextChanged += new System.EventHandler(this.IpIntialDeposite_TextChanged);
            // 
            // IpMontlySalary
            // 
            this.IpMontlySalary.Location = new System.Drawing.Point(221, 413);
            this.IpMontlySalary.Name = "IpMontlySalary";
            this.IpMontlySalary.ReadOnly = true;
            this.IpMontlySalary.Size = new System.Drawing.Size(147, 22);
            this.IpMontlySalary.TabIndex = 71;
            this.IpMontlySalary.TextChanged += new System.EventHandler(this.IpMontlySalary_TextChanged);
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
            this.IpPhone.ReadOnly = true;
            this.IpPhone.Size = new System.Drawing.Size(147, 22);
            this.IpPhone.TabIndex = 69;
            this.IpPhone.TextChanged += new System.EventHandler(this.IpPhone_TextChanged);
            // 
            // IpDOB
            // 
            this.IpDOB.Location = new System.Drawing.Point(37, 318);
            this.IpDOB.Name = "IpDOB";
            this.IpDOB.ReadOnly = true;
            this.IpDOB.Size = new System.Drawing.Size(147, 22);
            this.IpDOB.TabIndex = 68;
            this.IpDOB.TextChanged += new System.EventHandler(this.IpDOB_TextChanged);
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(221, 318);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.ReadOnly = true;
            this.IpAddress.Size = new System.Drawing.Size(147, 22);
            this.IpAddress.TabIndex = 67;
            this.IpAddress.TextChanged += new System.EventHandler(this.IpAddress_TextChanged);
            // 
            // IpName
            // 
            this.IpName.Location = new System.Drawing.Point(37, 126);
            this.IpName.Name = "IpName";
            this.IpName.ReadOnly = true;
            this.IpName.Size = new System.Drawing.Size(147, 22);
            this.IpName.TabIndex = 66;
            this.IpName.TextChanged += new System.EventHandler(this.IpName_TextChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            legend2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(404, 79);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Amount";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(416, 300);
            this.chart1.TabIndex = 84;
            this.chart1.Text = " ";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // noTransactionsLabel
            // 
            this.noTransactionsLabel.AutoSize = true;
            this.noTransactionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.noTransactionsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTransactionsLabel.Location = new System.Drawing.Point(443, 232);
            this.noTransactionsLabel.Name = "noTransactionsLabel";
            this.noTransactionsLabel.Size = new System.Drawing.Size(282, 21);
            this.noTransactionsLabel.TabIndex = 85;
            this.noTransactionsLabel.Text = "No Transactions History";
            this.noTransactionsLabel.Visible = false;
            // 
            // IpMonthlyPay
            // 
            this.IpMonthlyPay.Location = new System.Drawing.Point(221, 509);
            this.IpMonthlyPay.Name = "IpMonthlyPay";
            this.IpMonthlyPay.ReadOnly = true;
            this.IpMonthlyPay.Size = new System.Drawing.Size(147, 22);
            this.IpMonthlyPay.TabIndex = 88;
            this.IpMonthlyPay.TextChanged += new System.EventHandler(this.IpMonthlyPay_TextChanged);
            // 
            // IpLoan
            // 
            this.IpLoan.Location = new System.Drawing.Point(37, 509);
            this.IpLoan.Name = "IpLoan";
            this.IpLoan.ReadOnly = true;
            this.IpLoan.Size = new System.Drawing.Size(147, 22);
            this.IpLoan.TabIndex = 87;
            // 
            // ReportedLbl
            // 
            this.ReportedLbl.AutoSize = true;
            this.ReportedLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ReportedLbl.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportedLbl.ForeColor = System.Drawing.Color.Red;
            this.ReportedLbl.Location = new System.Drawing.Point(404, 25);
            this.ReportedLbl.Name = "ReportedLbl";
            this.ReportedLbl.Size = new System.Drawing.Size(406, 21);
            this.ReportedLbl.TabIndex = 93;
            this.ReportedLbl.Text = "This Account is Currently Reported";
            this.ReportedLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.IpLoanBtn);
            this.panel1.Controls.Add(this.UnreportBtn);
            this.panel1.Controls.Add(this.ReportedLbl);
            this.panel1.Controls.Add(this.guna2HtmlLabel10);
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Controls.Add(this.guna2HtmlLabel8);
            this.panel1.Controls.Add(this.guna2HtmlLabel7);
            this.panel1.Controls.Add(this.guna2HtmlLabel6);
            this.panel1.Controls.Add(this.guna2HtmlLabel5);
            this.panel1.Controls.Add(this.guna2HtmlLabel4);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 563);
            this.panel1.TabIndex = 94;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.DeleteBtn.IconColor = System.Drawing.Color.White;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 32;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBtn.Location = new System.Drawing.Point(426, 422);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DeleteBtn.Size = new System.Drawing.Size(152, 36);
            this.DeleteBtn.TabIndex = 106;
            this.DeleteBtn.Text = "Report";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBtn.UseMnemonic = false;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // IpLoanBtn
            // 
            this.IpLoanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpLoanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.IpLoanBtn.FlatAppearance.BorderSize = 0;
            this.IpLoanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IpLoanBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpLoanBtn.ForeColor = System.Drawing.Color.White;
            this.IpLoanBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.IpLoanBtn.IconColor = System.Drawing.Color.White;
            this.IpLoanBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IpLoanBtn.IconSize = 32;
            this.IpLoanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IpLoanBtn.Location = new System.Drawing.Point(595, 422);
            this.IpLoanBtn.Name = "IpLoanBtn";
            this.IpLoanBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IpLoanBtn.Size = new System.Drawing.Size(132, 36);
            this.IpLoanBtn.TabIndex = 105;
            this.IpLoanBtn.Text = "Loan";
            this.IpLoanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IpLoanBtn.UseMnemonic = false;
            this.IpLoanBtn.UseVisualStyleBackColor = false;
            this.IpLoanBtn.Click += new System.EventHandler(this.IpLoanBtn_Click_1);
            // 
            // UnreportBtn
            // 
            this.UnreportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnreportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.UnreportBtn.FlatAppearance.BorderSize = 0;
            this.UnreportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnreportBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnreportBtn.ForeColor = System.Drawing.Color.White;
            this.UnreportBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UnreportBtn.IconColor = System.Drawing.Color.White;
            this.UnreportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UnreportBtn.IconSize = 32;
            this.UnreportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnreportBtn.Location = new System.Drawing.Point(496, 479);
            this.UnreportBtn.Name = "UnreportBtn";
            this.UnreportBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UnreportBtn.Size = new System.Drawing.Size(169, 36);
            this.UnreportBtn.TabIndex = 104;
            this.UnreportBtn.Text = "Un Report";
            this.UnreportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UnreportBtn.UseMnemonic = false;
            this.UnreportBtn.UseVisualStyleBackColor = false;
            this.UnreportBtn.Click += new System.EventHandler(this.UnreportBtn_Click_1);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(27, 450);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(36, 25);
            this.guna2HtmlLabel10.TabIndex = 95;
            this.guna2HtmlLabel10.Text = "Loan";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(27, 362);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(31, 25);
            this.guna2HtmlLabel9.TabIndex = 103;
            this.guna2HtmlLabel9.Text = "SSN";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(211, 450);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(124, 25);
            this.guna2HtmlLabel8.TabIndex = 102;
            this.guna2HtmlLabel8.Text = "Monthly Payment";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(211, 262);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(59, 25);
            this.guna2HtmlLabel7.TabIndex = 101;
            this.guna2HtmlLabel7.Text = "Address";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(211, 362);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(105, 25);
            this.guna2HtmlLabel6.TabIndex = 100;
            this.guna2HtmlLabel6.Text = "Monthly Salary";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(27, 262);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(33, 25);
            this.guna2HtmlLabel5.TabIndex = 99;
            this.guna2HtmlLabel5.Text = "DOB";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(211, 169);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(118, 25);
            this.guna2HtmlLabel4.TabIndex = 98;
            this.guna2HtmlLabel4.Text = "Account Number";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(27, 169);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 25);
            this.guna2HtmlLabel3.TabIndex = 97;
            this.guna2HtmlLabel3.Text = "Intial Deposit";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(211, 79);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(46, 25);
            this.guna2HtmlLabel1.TabIndex = 96;
            this.guna2HtmlLabel1.Text = "Phone ";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(38, 79);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(107, 25);
            this.guna2HtmlLabel2.TabIndex = 95;
            this.guna2HtmlLabel2.Text = "Account Holder";
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.White;
            this.balance.Location = new System.Drawing.Point(27, 25);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(111, 29);
            this.balance.TabIndex = 52;
            this.balance.Text = "Total Balance";
            // 
            // SingleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 583);
            this.Controls.Add(this.IpMonthlyPay);
            this.Controls.Add(this.IpLoan);
            this.Controls.Add(this.noTransactionsLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.IpAccountNum);
            this.Controls.Add(this.IpIntialDeposite);
            this.Controls.Add(this.IpMontlySalary);
            this.Controls.Add(this.IpSSN);
            this.Controls.Add(this.IpPhone);
            this.Controls.Add(this.IpDOB);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.IpName);
            this.Controls.Add(this.panel1);
            this.Name = "SingleUser";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleUser";
            this.Load += new System.EventHandler(this.SingleUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox IpAccountNum;
        public System.Windows.Forms.TextBox IpIntialDeposite;
        public System.Windows.Forms.TextBox IpMontlySalary;
        public System.Windows.Forms.TextBox IpSSN;
        public System.Windows.Forms.TextBox IpPhone;
        public System.Windows.Forms.TextBox IpDOB;
        public System.Windows.Forms.TextBox IpAddress;
        public System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label noTransactionsLabel;
        public System.Windows.Forms.TextBox IpMonthlyPay;
        public System.Windows.Forms.TextBox IpLoan;
        private System.Windows.Forms.Label ReportedLbl;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton IpLoanBtn;
        private FontAwesome.Sharp.IconButton UnreportBtn;
        public Guna.UI2.WinForms.Guna2HtmlLabel balance;
    }
}