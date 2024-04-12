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
        private void TransferBtn_Click(object sender, EventArgs e)
        {
   
             Account currectAccount = ObjectHandler.GetUserDL().GetCurrentUser().GetAccount();
            string accountHolder = AccountCb.SelectedItem.ToString();
            int amount = Convert.ToInt32(IpAmount.Text);
            Account account = ObjectHandler.GetAccountDL().isAccountExists(accountHolder);
            if (account == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            bool isTransferred =  account.Transfer(amount, account, currectAccount); // deposit money
            if (isTransferred)
            {

            MessageBox.Show("Transfer successful");
            }
            else
            {
             MessageBox.Show("Trnsaction wwas not successful......");
            }
        }

        private void AccountCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
