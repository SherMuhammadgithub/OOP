namespace BMS
{
    partial class SignUp
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
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputPass = new System.Windows.Forms.TextBox();
            this.InputRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(329, 308);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(110, 42);
            this.SignUpBtn.TabIndex = 0;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(308, 86);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(159, 22);
            this.InputName.TabIndex = 1;
            // 
            // InputPass
            // 
            this.InputPass.Location = new System.Drawing.Point(308, 165);
            this.InputPass.Name = "InputPass";
            this.InputPass.Size = new System.Drawing.Size(159, 22);
            this.InputPass.TabIndex = 2;
            // 
            // InputRole
            // 
            this.InputRole.Location = new System.Drawing.Point(308, 251);
            this.InputRole.Name = "InputRole";
            this.InputRole.Size = new System.Drawing.Size(159, 22);
            this.InputRole.TabIndex = 3;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 440);
            this.Controls.Add(this.InputRole);
            this.Controls.Add(this.InputPass);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.SignUpBtn);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputPass;
        private System.Windows.Forms.TextBox InputRole;
    }
}

