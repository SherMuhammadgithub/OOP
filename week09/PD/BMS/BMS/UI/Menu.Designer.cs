namespace BMS.UI
{
    partial class Menu
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
            this.AddAccount = new System.Windows.Forms.Button();
            this.FormDetPage = new System.Windows.Forms.Button();
            this.MoneyActBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(330, 244);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(141, 23);
            this.AddAccount.TabIndex = 5;
            this.AddAccount.Text = "AddAccount";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // FormDetPage
            // 
            this.FormDetPage.Location = new System.Drawing.Point(330, 183);
            this.FormDetPage.Name = "FormDetPage";
            this.FormDetPage.Size = new System.Drawing.Size(141, 23);
            this.FormDetPage.TabIndex = 4;
            this.FormDetPage.Text = "Form Details";
            this.FormDetPage.UseVisualStyleBackColor = true;
            this.FormDetPage.Click += new System.EventHandler(this.FormDetPage_Click);
            // 
            // MoneyActBtn
            // 
            this.MoneyActBtn.Location = new System.Drawing.Point(330, 119);
            this.MoneyActBtn.Name = "MoneyActBtn";
            this.MoneyActBtn.Size = new System.Drawing.Size(141, 23);
            this.MoneyActBtn.TabIndex = 6;
            this.MoneyActBtn.Text = "Money Actions";
            this.MoneyActBtn.UseVisualStyleBackColor = true;
            this.MoneyActBtn.Click += new System.EventHandler(this.DepositeBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyActBtn);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.FormDetPage);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.Button FormDetPage;
        private System.Windows.Forms.Button MoneyActBtn;
    }
}