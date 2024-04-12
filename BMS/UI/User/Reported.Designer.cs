namespace BMS.UI.User
{
    partial class Reported
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
            this.IpRepAccountName = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IpReason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IpRepAccountName
            // 
            this.IpRepAccountName.Location = new System.Drawing.Point(343, 188);
            this.IpRepAccountName.Name = "IpRepAccountName";
            this.IpRepAccountName.ReadOnly = true;
            this.IpRepAccountName.Size = new System.Drawing.Size(100, 22);
            this.IpRepAccountName.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(300, 86);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(201, 18);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Your Account has been Reported";
            // 
            // IpReason
            // 
            this.IpReason.Location = new System.Drawing.Point(343, 281);
            this.IpReason.Name = "IpReason";
            this.IpReason.Size = new System.Drawing.Size(100, 22);
            this.IpReason.TabIndex = 3;
            // 
            // Reported
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IpRepAccountName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.IpReason);
            this.Name = "Reported";
            this.Text = "Reported";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox IpRepAccountName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public System.Windows.Forms.TextBox IpReason;
    }
}