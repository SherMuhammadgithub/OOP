namespace BMS.UI
{
    partial class SignIn
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
            this.InputPass = new System.Windows.Forms.TextBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputPass
            // 
            this.InputPass.Location = new System.Drawing.Point(295, 198);
            this.InputPass.Name = "InputPass";
            this.InputPass.Size = new System.Drawing.Size(159, 22);
            this.InputPass.TabIndex = 6;
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(295, 119);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(159, 22);
            this.InputName.TabIndex = 5;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(320, 281);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(110, 42);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "SignIn";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputPass);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.SignInBtn);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputPass;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Button SignInBtn;
    }
}