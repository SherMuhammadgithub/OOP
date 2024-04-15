using BMS.BL;
using BMS.DL;
using BMS.DL.FH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class MoneyActions : Form
    {
            
        public MoneyActions()
        {
            InitializeComponent();
        }

        private void GoToTransferPgBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void MoneyActions_Load(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidAmount = ValidateAmount();
            if (!isValidAmount)
            {
                validateAmount.Visible = true;
                return;
            }
            validateAmount.Visible = false;
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser(); // get current user
            Account account = currentUser.GetAccount(); // get current account
            int amount = Convert.ToInt32(IpAmount.Text);
            bool isDeposited = account.Deposit(amount);
            if (isDeposited)
            {
                trans transaction = new trans("Deposit", amount, account.GetAccountHolder());
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(account.GetIntialDeposit(), account.GetAccountHolder());
                if (isSaved && isUpdated)
                {
                    account.SetTransactions(transaction);

                   MessageBox.Show("Deposite successful");
                }


            }
            else
            {
                MessageBox.Show("Deposite was not successful.....");
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidAmount = ValidateAmount();
            if (!isValidAmount)
            {
                validateAmount.Visible = true;
                return;
            }
            validateAmount.Visible = false;
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser(); // get current user
            Account account = currentUser.GetAccount(); // get current account
            int amount = Convert.ToInt32(IpAmount.Text);
            bool isWithdrawed = account.Withdraw(amount);
            if (isWithdrawed)
            {
                trans transaction = new trans("Withdraw", amount, account.GetAccountHolder());
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(account.GetIntialDeposit(), account.GetAccountHolder());
                if (isSaved && isUpdated)
                {
                    account.SetTransactions(transaction);
                MessageBox.Show("Withdraw successful");
                }

            }
            else
            {
                MessageBox.Show("Withdraw was not successful");
            }
        }
        private bool ValidateInput()
        {
            if (IpAmount.Text == "")
            {
                MessageBox.Show("Please enter the amount");
                return false;
            }
            return true;
        }
        private bool ValidateAmount()
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(IpAmount.Text, regex))
            {
                MessageBox.Show("Please enter a valid amount");
                return false;
            }
            return true;
        }
        private void SignUpPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Transfer transfer = new Transfer();
            transfer.Show();
        }
    }
}
