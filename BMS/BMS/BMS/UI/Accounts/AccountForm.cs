using BMS.BL;
using BMS.DL;
using BMS.UI.Accounts;
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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            IpName.Text = MUserDL.GetCurrentUser().GetUsername().ToString();
        }

        private void UserPannel_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
          MUser currentUser = MUserDL.GetCurrentUser();
            string AccountHolder = IpName.Text.ToString();
            string DateOfBirth = IpDOB.Text.ToString();
            string Address = IpAddress.Text.ToString();
            int Phone = Convert.ToInt32(IpPhone.Text.ToString());
            string SocialSecurityNumber = IpSSN.Text.ToString();
            int MonthlyIncome = Convert.ToInt32(IpMontlySalary.Text.ToString());
            int IntialDeposit = Convert.ToInt32(IpIntialDeposite.Text.ToString());
            // check if there is savings or checkings
            string type = AccountTypeCb.SelectedItem.ToString();

            //check if account type is checkings
            currentUser.CreateCheckingAccount(DateOfBirth, Address, Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder, type);
            currentUser.GetAccount().GenerateAccountNumber(); // generate account number
                                                                  // store in the database
            AccountDL.SaveAccountToDataBase(currentUser.GetAccount());
            // store in the List
            AccountDL.AddAccount(currentUser.GetAccount());
            MessageBox.Show("Account created successfully");
            this.Hide();
            AccountzDet accountzDet = new AccountzDet();
            accountzDet.Show();
            
        }

        private void IpName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IpDOB_TextChanged(object sender, EventArgs e)
        {
            AddBtn.Enabled = !string.IsNullOrEmpty(IpDOB.Text); 
        }
    }
}
