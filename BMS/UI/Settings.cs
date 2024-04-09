using BMS.BL;
using BMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class Settings : Form
    {
           MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
        public Settings()
        {
            InitializeComponent();
            LoadData();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                    //allow jppg, png and gif files
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image image = Image.FromFile(filePath);
                    Image1.Image = image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            IpPass.Text = currentUser.GetPassword();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // updating password only 
            currentUser.SetPassword(IpPass.Text);
           bool isUserUpdated = ObjectHandler.GetUserDL().UpdateUserInfo(currentUser, currentUser.GetUsername());
            if(isUserUpdated)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("not Updated");
            }
        }

        private void IpPass_TextChanged(object sender, EventArgs e)
        {
            EditBtn.Enabled = !string.IsNullOrEmpty(IpPass.Text);

        }
    }
}
