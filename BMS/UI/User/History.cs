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
