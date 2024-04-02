namespace BMS.UI
{
    partial class Settings
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
            this.label8 = new System.Windows.Forms.Label();
            this.IpPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IpEmail = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Password";
            // 
            // IpPass
            // 
            this.IpPass.Location = new System.Drawing.Point(619, 150);
            this.IpPass.Name = "IpPass";
            this.IpPass.ReadOnly = true;
            this.IpPass.Size = new System.Drawing.Size(147, 22);
            this.IpPass.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "email";
            // 
            // IpEmail
            // 
            this.IpEmail.Location = new System.Drawing.Point(370, 150);
            this.IpEmail.Name = "IpEmail";
            this.IpEmail.Size = new System.Drawing.Size(147, 22);
            this.IpEmail.TabIndex = 46;
            this.IpEmail.Text = " ";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(693, 399);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 50;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image1.Location = new System.Drawing.Point(22, 34);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(207, 209);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image1.TabIndex = 51;
            this.Image1.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(87, 307);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 52;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IpPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IpEmail);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IpPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IpEmail;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.Button UploadBtn;
    }
}