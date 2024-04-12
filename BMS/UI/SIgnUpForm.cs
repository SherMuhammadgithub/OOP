using BMS.BL;
using BMS.DLInterfaces;
using DatabaseProject;
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
    public partial class SIgnUpForm : Form
    {
        public SIgnUpForm()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            IMUserDL userDL = ObjectHandler.GetUserDL(); // get user data layer
            MUser newUser = new MUser(InputName.Text, InputPass.Text, InputRole.Text);
            if (userDL.SignUp(newUser))
            {
                MessageBox.Show("User added successfully");
                bool isSaved = userDL.SaveUserInfo(newUser);
                if (isSaved)
                {
                    MessageBox.Show("User Saved  Successfully");
                }
                else
                {
                    MessageBox.Show("User not Saved....");
                }
                this.Hide();
                LoginForm signIn = new LoginForm();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }

        private void LoginPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
