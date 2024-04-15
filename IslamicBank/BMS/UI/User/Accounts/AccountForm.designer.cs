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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.IpName = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.IpDOB = new System.Windows.Forms.TextBox();
            this.IpPhone = new System.Windows.Forms.TextBox();
            this.IpSSN = new System.Windows.Forms.TextBox();
            this.IpMontlySalary = new System.Windows.Forms.TextBox();
            this.IpIntialDeposite = new System.Windows.Forms.TextBox();
            this.AccountTypeCb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Students = new FontAwesome.Sharp.IconButton();
            this.validateDOB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validatePhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateSSN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.validateDep = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IpName
            // 
            this.IpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpName.CausesValidation = false;
            this.IpName.Location = new System.Drawing.Point(116, 185);
            this.IpName.Name = "IpName";
            this.IpName.ReadOnly = true;
            this.IpName.Size = new System.Drawing.Size(147, 22);
            this.IpName.TabIndex = 0;
            this.IpName.TextChanged += new System.EventHandler(this.IpName_TextChanged);
            // 
            // IpAddress
            // 
            this.IpAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpAddress.CausesValidation = false;
            this.IpAddress.Location = new System.Drawing.Point(567, 185);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(147, 22);
            this.IpAddress.TabIndex = 1;
            // 
            // IpDOB
            // 
            this.IpDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpDOB.CausesValidation = false;
            this.IpDOB.Location = new System.Drawing.Point(345, 185);
            this.IpDOB.Name = "IpDOB";
            this.IpDOB.Size = new System.Drawing.Size(147, 22);
            this.IpDOB.TabIndex = 2;
            this.IpDOB.TextChanged += new System.EventHandler(this.IpDOB_TextChanged);
            // 
            // IpPhone
            // 
            this.IpPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpPhone.CausesValidation = false;
            this.IpPhone.Location = new System.Drawing.Point(116, 301);
            this.IpPhone.Name = "IpPhone";
            this.IpPhone.Size = new System.Drawing.Size(147, 22);
            this.IpPhone.TabIndex = 3;
            this.IpPhone.TextChanged += new System.EventHandler(this.IpPhone_TextChanged);
            // 
            // IpSSN
            // 
            this.IpSSN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpSSN.CausesValidation = false;
            this.IpSSN.Location = new System.Drawing.Point(345, 301);
            this.IpSSN.Name = "IpSSN";
            this.IpSSN.Size = new System.Drawing.Size(147, 22);
            this.IpSSN.TabIndex = 4;
            this.IpSSN.TextChanged += new System.EventHandler(this.IpSSN_TextChanged);
            // 
            // IpMontlySalary
            // 
            this.IpMontlySalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpMontlySalary.CausesValidation = false;
            this.IpMontlySalary.Location = new System.Drawing.Point(567, 301);
            this.IpMontlySalary.Name = "IpMontlySalary";
            this.IpMontlySalary.Size = new System.Drawing.Size(147, 22);
            this.IpMontlySalary.TabIndex = 5;
            // 
            // IpIntialDeposite
            // 
            this.IpIntialDeposite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpIntialDeposite.CausesValidation = false;
            this.IpIntialDeposite.Location = new System.Drawing.Point(223, 412);
            this.IpIntialDeposite.Name = "IpIntialDeposite";
            this.IpIntialDeposite.Size = new System.Drawing.Size(147, 22);
            this.IpIntialDeposite.TabIndex = 6;
            // 
            // AccountTypeCb
            // 
            this.AccountTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountTypeCb.CausesValidation = false;
            this.AccountTypeCb.FormattingEnabled = true;
            this.AccountTypeCb.Items.AddRange(new object[] {
            "savings",
            "checking"});
            this.AccountTypeCb.Location = new System.Drawing.Point(469, 410);
            this.AccountTypeCb.Name = "AccountTypeCb";
            this.AccountTypeCb.Size = new System.Drawing.Size(150, 24);
            this.AccountTypeCb.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.validateDep);
            this.panel1.Controls.Add(this.validateSalary);
            this.panel1.Controls.Add(this.validateSSN);
            this.panel1.Controls.Add(this.validatePhone);
            this.panel1.Controls.Add(this.validateDOB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.AccountTypeCb);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.IpIntialDeposite);
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.IpMontlySalary);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.IpSSN);
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.IpPhone);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.IpDOB);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.IpAddress);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.IpName);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Students);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 555);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(345, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(127, 29);
            this.guna2HtmlLabel3.TabIndex = 62;
            this.guna2HtmlLabel3.Text = "Add an Account";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.AddBtn.IconColor = System.Drawing.Color.White;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.Location = new System.Drawing.Point(268, 476);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddBtn.Size = new System.Drawing.Size(251, 36);
            this.AddBtn.TabIndex = 61;
            this.AddBtn.Text = "ADD Account";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseMnemonic = false;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(450, 359);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.Size = new System.Drawing.Size(186, 47);
            this.iconButton7.TabIndex = 60;
            this.iconButton7.Text = "Account Type";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(204, 359);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Size = new System.Drawing.Size(188, 47);
            this.iconButton6.TabIndex = 58;
            this.iconButton6.Text = "Intial Deposite";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(554, 248);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(185, 47);
            this.iconButton5.TabIndex = 58;
            this.iconButton5.Text = "Monthly Salary";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(332, 248);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(139, 47);
            this.iconButton4.TabIndex = 58;
            this.iconButton4.Text = "SSN";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(103, 248);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(139, 47);
            this.iconButton3.TabIndex = 58;
            this.iconButton3.Text = "Phone";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(554, 143);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(139, 47);
            this.iconButton2.TabIndex = 59;
            this.iconButton2.Text = "Address";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(322, 143);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(139, 47);
            this.iconButton1.TabIndex = 58;
            this.iconButton1.Text = "DOB";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Students
            // 
            this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.Students.FlatAppearance.BorderSize = 0;
            this.Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Students.IconColor = System.Drawing.Color.White;
            this.Students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Students.IconSize = 32;
            this.Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.Location = new System.Drawing.Point(103, 143);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(139, 47);
            this.Students.TabIndex = 57;
            this.Students.Text = "Name";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = false;
            // 
            // validateDOB
            // 
            this.validateDOB.BackColor = System.Drawing.Color.Transparent;
            this.validateDOB.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateDOB.ForeColor = System.Drawing.Color.Red;
            this.validateDOB.Location = new System.Drawing.Point(345, 217);
            this.validateDOB.Name = "validateDOB";
            this.validateDOB.Size = new System.Drawing.Size(83, 25);
            this.validateDOB.TabIndex = 66;
            this.validateDOB.Text = "DD/MM/YY";
            this.validateDOB.Visible = false;
            // 
            // validatePhone
            // 
            this.validatePhone.BackColor = System.Drawing.Color.Transparent;
            this.validatePhone.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatePhone.ForeColor = System.Drawing.Color.Red;
            this.validatePhone.Location = new System.Drawing.Point(116, 328);
            this.validatePhone.Name = "validatePhone";
            this.validatePhone.Size = new System.Drawing.Size(175, 25);
            this.validatePhone.TabIndex = 67;
            this.validatePhone.Text = "Must Contain 11 numbers!";
            this.validatePhone.Visible = false;
            // 
            // validateSSN
            // 
            this.validateSSN.BackColor = System.Drawing.Color.Transparent;
            this.validateSSN.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateSSN.ForeColor = System.Drawing.Color.Red;
            this.validateSSN.Location = new System.Drawing.Point(336, 328);
            this.validateSSN.Name = "validateSSN";
            this.validateSSN.Size = new System.Drawing.Size(100, 25);
            this.validateSSN.TabIndex = 68;
            this.validateSSN.Text = "Only Numbers";
            this.validateSSN.Visible = false;
            // 
            // validateSalary
            // 
            this.validateSalary.BackColor = System.Drawing.Color.Transparent;
            this.validateSalary.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateSalary.ForeColor = System.Drawing.Color.Red;
            this.validateSalary.Location = new System.Drawing.Point(567, 328);
            this.validateSalary.Name = "validateSalary";
            this.validateSalary.Size = new System.Drawing.Size(100, 25);
            this.validateSalary.TabIndex = 69;
            this.validateSalary.Text = "Only Numbers";
            this.validateSalary.Visible = false;
            // 
            // validateDep
            // 
            this.validateDep.BackColor = System.Drawing.Color.Transparent;
            this.validateDep.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateDep.ForeColor = System.Drawing.Color.Red;
            this.validateDep.Location = new System.Drawing.Point(223, 440);
            this.validateDep.Name = "validateDep";
            this.validateDep.Size = new System.Drawing.Size(100, 25);
            this.validateDep.TabIndex = 70;
            this.validateDep.Text = "Only Numbers";
            this.validateDep.Visible = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 575);
            this.Controls.Add(this.panel1);
            this.Name = "AccountForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPannel";
            this.Load += new System.EventHandler(this.UserPannel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IpName;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.TextBox IpDOB;
        private System.Windows.Forms.TextBox IpPhone;
        private System.Windows.Forms.TextBox IpSSN;
        private System.Windows.Forms.TextBox IpMontlySalary;
        private System.Windows.Forms.TextBox IpIntialDeposite;
        private System.Windows.Forms.ComboBox AccountTypeCb;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton AddBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateDOB;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateSSN;
        private Guna.UI2.WinForms.Guna2HtmlLabel validatePhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateDep;
        private Guna.UI2.WinForms.Guna2HtmlLabel validateSalary;
    }
}