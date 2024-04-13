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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            // create column for the data grid view
            TransactionDataGrid.ColumnCount = 3;
            TransactionDataGrid.Columns[0].Name = "Transaction Type";
            TransactionDataGrid.Columns[1].Name = "Amount";
            TransactionDataGrid.Columns[2].Name = "Date";
            OnLoad();
        }
        private void OnLoad()
        {
           MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            List<trans> transactions = currentUser.GetAccount().GetTransactions();
            foreach (trans transaction in transactions)
            {
                TransactionDataGrid.Rows.Add(transaction.GetTransactionType(), transaction.GetAmount(), transaction.GetDate());
            }
            // Assuming your chart series are named "Amount"
            var amountSeries = chart1.Series["Amount"];

            // Check if there are transactions
            if (transactions.Count > 0)
            {
                int Deposit = 0;
                int Transfer = 0;
                int Withdraw = 0;
                foreach (trans trasnsaction in transactions)
                {
                    if (trasnsaction.GetTransactionType() == "Deposit")
                    {
                        Deposit++;
                    }
                    else if (trasnsaction.GetTransactionType() == "Transfer")
                    {
                        Transfer++;
                    }
                    {
                        Withdraw++;
                    }
                }
                amountSeries.Points.AddXY("Transfer", Transfer);
                amountSeries.Points.AddXY("Withdraw", Withdraw);
                amountSeries.Points.AddXY("Deposit", Deposit);
                noTransactionsLabel.Visible = false;
            }
            else
            {
                // Show the "No Transactions" label
                noTransactionsLabel.Visible = true;

                // Optionally, clear the chart series (optional)
                amountSeries.Points.Clear();
            }

        }
        private void Transactions_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
