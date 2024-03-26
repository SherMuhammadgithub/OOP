namespace SignInSignUp
{
    partial class SignInSignUpApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.CheckBox();
            this.SignIn = new System.Windows.Forms.CheckBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Protest Riot", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "SignIn SignUp Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Location = new System.Drawing.Point(248, 228);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(77, 20);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.CheckedChanged += new System.EventHandler(this.SignUp_CheckedChanged);
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Location = new System.Drawing.Point(415, 228);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(69, 20);
            this.SignIn.TabIndex = 3;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(627, 356);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 16;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // SignInSignUpApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.label1);
            this.Name = "SignInSignUpApplication";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SignUp;
        private System.Windows.Forms.CheckBox SignIn;
        private System.Windows.Forms.Button NextBtn;
    }
}