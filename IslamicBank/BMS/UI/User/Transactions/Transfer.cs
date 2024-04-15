using BMS.BL;
using BMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
            LoadAccount();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
        private void LoadAccount()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();

            foreach (Account account in accounts)
            {
                // skip the current account
                if (account.GetAccountHolder() == ObjectHandler.GetUserDL().GetCurrentUser().GetUsername())
                {
                    continue;
                }
                AccountCb.Items.Add(account.GetAccountHolder());
            }
        }

        private void AccountCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void TransferBtn_Click_1(object sender, EventArgs e)
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
            Account currectAccount = ObjectHandler.GetUserDL().GetCurrentUser().GetAccount();
            string accountHolder = AccountCb.SelectedItem.ToString();
            int amount = Convert.ToInt32(IpAmount.Text);
            Account accountToTransfer = ObjectHandler.GetAccountDL().isAccountExists(accountHolder);
            if (accountToTransfer == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            bool isTransferred = currectAccount.Transfer(amount); // -- 
            if (isTransferred)
            {
                trans transaction1 = new trans("Transfer", amount, currectAccount.GetAccountHolder());
                bool isTransac = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction1);
                bool isBalanceUpdated  = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(currectAccount.GetIntialDeposit(), currectAccount.GetAccountHolder());
                if (isTransac && isBalanceUpdated)
                {
                    currectAccount.SetTransactions(transaction1);
                }
                bool isDeposited = accountToTransfer.Deposit(amount);
                if (isDeposited)
                {
                    trans transaction2 = new trans("Deposit", amount, accountToTransfer.GetAccountHolder());
                    bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction2);
                    bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(accountToTransfer.GetIntialDeposit(), accountToTransfer.GetAccountHolder());
                    if (isSaved && isUpdated)
                    {
                        accountToTransfer.SetTransactions(transaction2);
                    }
                    MessageBox.Show("Transfer successful");
                }
                else
                {
                    MessageBox.Show("Trnsaction wwas not successful......");
                }
            }
        }
        private bool ValidateInput()
        {
            if (IpAmount.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            return true;
        }
        private bool ValidateAmount()
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(IpAmount.Text, regex))
            {
                return false;
            }
            return true;
        }
    }
}
