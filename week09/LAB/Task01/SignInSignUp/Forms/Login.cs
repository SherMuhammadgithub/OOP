using SignInSignUp.BL;
using SignInSignUp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            NameTB.Text = "";
            PassTB.Text = "";
        }
        
        private void NextBtn_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL(NameTB.Text, PassTB.Text);
            UserBL validUser = UserDL.SignIn(user);
            if (validUser != null)
            {
                MessageBox.Show("User signed in successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
