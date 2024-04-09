using BMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class SingleUser : Form
    {
        public SingleUser()
        {
            InitializeComponent();

        }
        private void LoadTransactions()
        {
            string accountHolder = IpName.Text;
            List<trans> transactions = ObjectHandler.GetTransactionDL().GetTransactionsForSpecificAccount(accountHolder);

            // Assuming your chart series are named "Amount"
            var amountSeries = chart1.Series["Amount"];

            // Check if there are transactions
            if (transactions.Count > 0)
            {
                // Loop through transactions and add data points (existing code)
                foreach (trans transaction in transactions)
                {
                    string type = transaction.GetTransactionType();
                    int amount = transaction.GetAmount();
                    amountSeries.Points.AddXY(type, amount);
                }

                // Hide the "No Transactions" label
                noTransactionsLabel.Visible = false; // Assuming your label name is "noTransactionsLabel"
            }
            else
            {
                // Show the "No Transactions" label
                noTransactionsLabel.Visible = true;

                // Optionally, clear the chart series (optional)
                amountSeries.Points.Clear();
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }



        private void SingleUser_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string accountHolder = IpName.Text;
            Account account = ObjectHandler.GetAccountDL().isAccountExists(accountHolder);
            bool isDeleted = ObjectHandler.GetAccountDL().DeleteAccount(account);
            bool isDeletedTransactions = ObjectHandler.GetTransactionDL().DeleteTransaction(accountHolder);
            bool isDeletedLoan = ObjectHandler.GetLoanDL().DeleteLoan(account.GetLoan());

            
            if (isDeleted && isDeletedTransactions && isDeletedLoan)
            {
                MessageBox.Show("Account deleted successfully");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Account not deleted");
            }
        }
    }
}
