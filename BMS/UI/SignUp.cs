using BMS.BL;
using BMS.DL;
using BMS.DLInterfaces;
using BMS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class SignUp : Form
    {
        public SignUp()
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
                SignIn signIn = new SignIn();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }
    }
}
