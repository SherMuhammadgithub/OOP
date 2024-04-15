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
using System.Text.RegularExpressions;
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
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidPass = ValidatePassword();
            if (!isValidPass)
            {
                return;
            }
            bool isValidUser = ValidateUsername();
            if (!isValidUser)
            {
                return;
            }
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
                this.Close();
                LoginForm signIn = new LoginForm();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }
        // validate the input fields
        private bool ValidateInput()
        {
            if (InputName.Text == "" || InputPass.Text == "" || InputRole.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            return true;
        }
        private bool ValidatePassword()
        {
            if (InputPass.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return false;
            }
            return true;
        }
      private bool ValidateUsername()
        {
            //write regex to validate username only contains letters and numbers
            string regex = @"^[a-zA-Z]+$";
            if(!Regex.IsMatch(InputName.Text, regex))
            {
                MessageBox.Show("Username must only contain letters");
                return false;
            }
            return true;

        }
        private void LoginPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
