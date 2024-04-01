namespace BMS.UI
{
    partial class MoneyActions
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
            this.IpAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositeBtn = new System.Windows.Forms.Button();
            this.WithDrawBtn = new System.Windows.Forms.Button();
            this.GoToTransferPgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IpAmount
            // 
            this.IpAmount.Location = new System.Drawing.Point(239, 107);
            this.IpAmount.Name = "IpAmount";
            this.IpAmount.Size = new System.Drawing.Size(219, 22);
            this.IpAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Amount";
            // 
            // DepositeBtn
            // 
            this.DepositeBtn.Location = new System.Drawing.Point(236, 191);
            this.DepositeBtn.Name = "DepositeBtn";
            this.DepositeBtn.Size = new System.Drawing.Size(92, 25);
            this.DepositeBtn.TabIndex = 7;
            this.DepositeBtn.Text = "Deposite";
            this.DepositeBtn.UseVisualStyleBackColor = true;
            this.DepositeBtn.Click += new System.EventHandler(this.DepositeBtn_Click);
            // 
            // WithDrawBtn
            // 
            this.WithDrawBtn.Location = new System.Drawing.Point(366, 191);
            this.WithDrawBtn.Name = "WithDrawBtn";
            this.WithDrawBtn.Size = new System.Drawing.Size(92, 25);
            this.WithDrawBtn.TabIndex = 8;
            this.WithDrawBtn.Text = "WithDraw";
            this.WithDrawBtn.UseVisualStyleBackColor = true;
            this.WithDrawBtn.Click += new System.EventHandler(this.WithDrawBtn_Click);
            // 
            // GoToTransferPgBtn
            // 
            this.GoToTransferPgBtn.Location = new System.Drawing.Point(470, 277);
            this.GoToTransferPgBtn.Name = "GoToTransferPgBtn";
            this.GoToTransferPgBtn.Size = new System.Drawing.Size(175, 25);
            this.GoToTransferPgBtn.TabIndex = 9;
            this.GoToTransferPgBtn.Text = "Want to trasnfer";
            this.GoToTransferPgBtn.UseVisualStyleBackColor = true;
            this.GoToTransferPgBtn.Click += new System.EventHandler(this.GoToTransferPgBtn_Click);
            // 
            // MoneyActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.GoToTransferPgBtn);
            this.Controls.Add(this.WithDrawBtn);
            this.Controls.Add(this.DepositeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpAmount);
            this.Name = "MoneyActions";
            this.Text = "MoneyActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DepositeBtn;
        private System.Windows.Forms.Button WithDrawBtn;
        private System.Windows.Forms.Button GoToTransferPgBtn;
    }
}