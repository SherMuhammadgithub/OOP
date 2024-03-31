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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(InputName.Text, InputPass.Text);
            if (MUserDL.SignIn(user))
            {
                MessageBox.Show("User signed in successfully");
                MUserDL.StoreCurrentUser(user);
                // setting current customer
                bool isSet = CustomerDL.SetCurrentCustomer(user);
                if (isSet)
                {
                    MessageBox.Show("Current customer set successfully");
                }
                // setting current customer Account
                 Customer currentCustomer = CustomerDL.GetCurrentCustomer();
                Account account = AccountDL.isAccountExists(currentCustomer.GetCustomerName());
                if (account != null)
                {
                    MessageBox.Show("Account found");
                    currentCustomer.SetCurrentAccount(account);
                }
                // if account not found
                else
                {
                    MessageBox.Show("Account not found");
                    currentCustomer.SetCurrentAccount(null); // set null
                }
                this.Hide();
               Menu menu = new Menu();
                menu.Show();    
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
