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
    public partial class MoneyActions : Form
    {
            static MUser currentUser = MUserDL.GetCurrentUser(); // get current user
            static Account account = currentUser.GetAccount(); // get current account
        public MoneyActions()
        {
            InitializeComponent();
            CheckIfAccountExists();
        }
        private void CheckIfAccountExists()
        {
            if (account == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(IpAmount.Text);
            account.Deposit(amount);
            MessageBox.Show("Deposite successful");
        }

        private void WithDrawBtn_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(IpAmount.Text);
            account.Withdraw(amount);
            MessageBox.Show("Withdraw successful");
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
        }

        private void AccountLbl_Click(object sender, EventArgs e)
        {

           
        }

        private void GoToTransferPgBtn_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();



        }
    }
}
