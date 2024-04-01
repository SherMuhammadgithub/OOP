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

namespace BMS.UI.Accounts
{
    public partial class AccountzDet : Form
    {
        public AccountzDet()
        {
            InitializeComponent();
            LoadAccountInfo();
        }

        private void AccountzDet_Load(object sender, EventArgs e)
        {

        }
        private void LoadAccountInfo()
        {
           Customer customer =  CustomerDL.GetCurrentCustomer(); 
           Account currentAccount =  customer.GetAccount();
            
            
            if (currentAccount == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            IpName.Text = currentAccount.GetAccountHolder();
            IpDOB.Text = currentAccount.GetDateOfBirth();
            IpAddress.Text = currentAccount.GetAddress();
            IpPhone.Text = currentAccount.GetPhone().ToString();
            IpSSN.Text = currentAccount.GetSocialSecurityNumber();
            IpMontlySalary.Text = currentAccount.GetMonthlyIncome().ToString();
            IpIntialDeposite.Text = currentAccount.GetIntialDeposit().ToString();
            IpAccountNum.Text = currentAccount.GetAccountNumber().ToString();
        }
    }
}
