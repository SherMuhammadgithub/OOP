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
            this.IpPass = new System.Windows.Forms.TextBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BalanceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.upload = new FontAwesome.Sharp.IconButton();
            this.edit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpPass
            // 
            this.IpPass.Location = new System.Drawing.Point(66, 167);
            this.IpPass.Name = "IpPass";
            this.IpPass.Size = new System.Drawing.Size(147, 22);
            this.IpPass.TabIndex = 48;
            this.IpPass.TextChanged += new System.EventHandler(this.IpPass_TextChanged);
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Image1.Location = new System.Drawing.Point(330, 87);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(164, 155);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image1.TabIndex = 51;
            this.Image1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.Image1);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Controls.Add(this.IpPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 367);
            this.panel1.TabIndex = 53;
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.White;
            this.BalanceLbl.Location = new System.Drawing.Point(51, 25);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(433, 29);
            this.BalanceLbl.TabIndex = 53;
            this.BalanceLbl.Text = "Change Your Password and Upload your Profile Photo";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(64, 127);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(123, 25);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Change Password";
            // 
            // upload
            // 
            this.upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.White;
            this.upload.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.upload.IconColor = System.Drawing.Color.White;
            this.upload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.upload.IconSize = 32;
            this.upload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upload.Location = new System.Drawing.Point(330, 279);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.upload.Size = new System.Drawing.Size(173, 36);
            this.upload.TabIndex = 64;
            this.upload.Text = "Upload Photo";
            this.upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.upload.UseMnemonic = false;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Dosis", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.edit.IconColor = System.Drawing.Color.White;
            this.edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit.IconSize = 32;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.Location = new System.Drawing.Point(66, 223);
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.edit.Size = new System.Drawing.Size(145, 36);
            this.edit.TabIndex = 65;
            this.edit.Text = "Edit Info";
            this.edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit.UseMnemonic = false;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 387);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IpPass;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BalanceLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private FontAwesome.Sharp.IconButton edit;
        private FontAwesome.Sharp.IconButton upload;
    }
}