using BMS.BL;
using BMS.DL;
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
            MUser newUser = new MUser(InputName.Text, InputPass.Text, InputRole.Text);
            if (MUserDL.SignUp(newUser))
            {
                MessageBox.Show("User added successfully");
                string Query = "INSERT INTO BMSUsers (Name, Password, Role) VALUES ('{0}','{1}','{2}')";
                Query = string.Format(Query, newUser.GetUsername(), newUser.GetPassword(), newUser.GetRole());
                int isStored = Function.SetData(Query);
                if(isStored > 0) // rowsAffected
                {
                    MessageBox.Show("User added to the database");
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
