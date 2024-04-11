namespace BMS.UI
{
    partial class AdminPannel
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
            this.ViewBtn = new FontAwesome.Sharp.IconButton();
            this.VipUsersPg = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ViewBtn
            // 
            this.ViewBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ViewBtn.IconColor = System.Drawing.Color.Black;
            this.ViewBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewBtn.Location = new System.Drawing.Point(344, 204);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(75, 22);
            this.ViewBtn.TabIndex = 0;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // VipUsersPg
            // 
            this.VipUsersPg.IconChar = FontAwesome.Sharp.IconChar.None;
            this.VipUsersPg.IconColor = System.Drawing.Color.Black;
            this.VipUsersPg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VipUsersPg.Location = new System.Drawing.Point(344, 271);
            this.VipUsersPg.Name = "VipUsersPg";
            this.VipUsersPg.Size = new System.Drawing.Size(75, 22);
            this.VipUsersPg.TabIndex = 1;
            this.VipUsersPg.Text = "Vip Users";
            this.VipUsersPg.UseVisualStyleBackColor = true;
            this.VipUsersPg.Click += new System.EventHandler(this.VipUsersPg_Click);
            // 
            // AdminPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VipUsersPg);
            this.Controls.Add(this.ViewBtn);
            this.Name = "AdminPannel";
            this.Text = "AdminPannel";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ViewBtn;
        private FontAwesome.Sharp.IconButton VipUsersPg;
    }
}