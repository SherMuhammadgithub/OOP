namespace BMS.UI
{
    partial class MainFrom
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
            this.LoginPage = new System.Windows.Forms.Button();
            this.SignUpPage = new System.Windows.Forms.Button();
            this.adminPg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginPage
            // 
            this.LoginPage.Location = new System.Drawing.Point(235, 124);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(75, 23);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = true;
            this.LoginPage.Click += new System.EventHandler(this.LoginPage_Click);
            // 
            // SignUpPage
            // 
            this.SignUpPage.Location = new System.Drawing.Point(492, 124);
            this.SignUpPage.Name = "SignUpPage";
            this.SignUpPage.Size = new System.Drawing.Size(75, 23);
            this.SignUpPage.TabIndex = 2;
            this.SignUpPage.Text = "Sign Up";
            this.SignUpPage.UseVisualStyleBackColor = true;
            this.SignUpPage.Click += new System.EventHandler(this.SignUpPage_Click);
            // 
            // adminPg
            // 
            this.adminPg.Location = new System.Drawing.Point(330, 320);
            this.adminPg.Name = "adminPg";
            this.adminPg.Size = new System.Drawing.Size(75, 23);
            this.adminPg.TabIndex = 3;
            this.adminPg.Text = "AdminPannel";
            this.adminPg.UseVisualStyleBackColor = true;
            this.adminPg.Click += new System.EventHandler(this.adminPg_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPg);
            this.Controls.Add(this.SignUpPage);
            this.Controls.Add(this.LoginPage);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginPage;
        private System.Windows.Forms.Button SignUpPage;
        private System.Windows.Forms.Button adminPg;
    }
}