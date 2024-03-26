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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            NameTB.Text = "";
            PasswordTB.Text = "";
            RoleTB.Text = "";

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL(NameTB.Text, PasswordTB.Text, RoleTB.Text);
            string path = SignInSignUpApplication.path;
            UserDL.AddUser(user);
            UserDL.StoreUserToFile(user,path);
            MessageBox.Show("User added successfully");
               ClearData();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
