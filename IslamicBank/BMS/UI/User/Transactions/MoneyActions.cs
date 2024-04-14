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
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser(); // get current user
            Account account = currentUser.GetAccount(); // get current account
            int amount = Convert.ToInt32(IpAmount.Text);
            bool isDeposited = account.Deposit(amount);
            if (isDeposited)
            {
                MessageBox.Show("Deposite successful");


            }
            else
            {
                MessageBox.Show("Deposite was not successful.....");
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser(); // get current user
            Account account = currentUser.GetAccount(); // get current account
            int amount = Convert.ToInt32(IpAmount.Text);
            bool isWithdrawed = account.Withdraw(amount);
            if (isWithdrawed)
            {
                MessageBox.Show("Withdraw successful");

            }
            else
            {
                MessageBox.Show("Withdraw was not successful");
            }
        }

        private void SignUpPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Transfer transfer = new Transfer();
            transfer.Show();
        }
    }
}
