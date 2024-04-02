
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void IpFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOginBtn_Click(object sender, EventArgs e)
        {
            
          if(IpEmail.Text == "admin" && IPPass.Text == "admin")
            {
                this.Hide();
              //  new FormMainMenu().Show();
            }
            else
            {
                MessageBox.Show($"{IpEmail.Text} and {IPPass.Text}");
                MessageBox.Show("Invalid Email or Password");
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
