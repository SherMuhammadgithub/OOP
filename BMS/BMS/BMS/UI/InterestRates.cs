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

namespace BMS
{
    public partial class InterestRates : Form
    {
        public InterestRates()
        {
            InitializeComponent();
            OnLoad();
        }
        private void OnLoad()
        {
            
            Account account =MUserDL.GetCurrentUser().GetAccount();
            string type = account.GetType();
            if (type == "Savings")
            {
              MessageBox.Show("Account type is Savings");
                Savings savingsAccount = (Savings)account;
                IpBankFee.Text = savingsAccount.MonthlyFee().ToString();
                IpInterestRate.Text = savingsAccount.InterestRate().ToString();
            }
            else
            {
                MessageBox.Show("Account type is Current");
                Checking checkingAccount = account as Checking;
                MessageBox.Show(checkingAccount.MonthlyFee().ToString());
                IpInterestRate.Text = checkingAccount.InterestRate().ToString();
                IpInterestRate.Text = checkingAccount.InterestRate().ToString();
            }
        }
        private void InterestRates_Load(object sender, EventArgs e)
        {

        }
    }
}
