namespace BMS.UI.Admin
{
    partial class ReportAccountForm
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
            this.IpReason = new System.Windows.Forms.TextBox();
            this.IpRepAccountName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.report = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpReason
            // 
            this.IpReason.Location = new System.Drawing.Point(109, 226);
            this.IpReason.Multiline = true;
            this.IpReason.Name = "IpReason";
            this.IpReason.Size = new System.Drawing.Size(217, 65);
            this.IpReason.TabIndex = 0;
            // 
            // IpRepAccountName
            // 
            this.IpRepAccountName.Location = new System.Drawing.Point(109, 143);
            this.IpRepAccountName.Name = "IpRepAccountName";
            this.IpRepAccountName.ReadOnly = true;
            this.IpRepAccountName.Size = new System.Drawing.Size(217, 22);
            this.IpRepAccountName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.IpReason);
            this.panel1.Controls.Add(this.IpRepAccountName);
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 387);
            this.panel1.TabIndex = 4;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(124, 34);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(154, 29);
            this.guna2HtmlLabel9.TabIndex = 50;
            this.guna2HtmlLabel9.Text = "Report An Account";
            this.guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(109, 100);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(107, 25);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Account Holder";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(109, 185);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(53, 25);
            this.guna2HtmlLabel1.TabIndex = 56;
            this.guna2HtmlLabel1.Text = "Reason";
            // 
            // report
            // 
            this.report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.report.FlatAppearance.BorderSize = 0;
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.report.IconColor = System.Drawing.Color.White;
            this.report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.report.IconSize = 32;
            this.report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.report.Location = new System.Drawing.Point(86, 324);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.report.Size = new System.Drawing.Size(251, 36);
            this.report.TabIndex = 64;
            this.report.Text = "Report";
            this.report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.report.UseMnemonic = false;
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // ReportAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 407);
            this.Controls.Add(this.panel1);
            this.Name = "ReportAccountForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IpReason;
        public System.Windows.Forms.TextBox IpRepAccountName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private FontAwesome.Sharp.IconButton report;
    }
}