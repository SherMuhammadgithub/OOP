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
    public partial class SignInSignUpApplication : Form
    {
           public static string path = "Data.txt";
        public SignInSignUpApplication()
        {
            InitializeComponent();
            if (DL.UserDL.readDataFromFile(path))
            {
                MessageBox.Show("Data read successfully");
            }
            else
            {
                MessageBox.Show("Data read failed");
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            
            if(SignIn.Checked)
            {
                Form moreForm = new Login();
                moreForm.ShowDialog();
                SignIn.Checked = false; 
            }
            else if(SignUp.Checked)
            {
                Form moreForm = new SignUp();
                moreForm.ShowDialog();
                SignUp.Checked = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
