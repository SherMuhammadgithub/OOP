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
           MUser currentUser = MUserDL.GetCurrentUser();
            List<Transactions> transactions = currentUser.GetAccount().GetTransactions();
            foreach (Transactions transaction in transactions)
            {
                TransactionDataGrid.Rows.Add(transaction.GetTransactionType(), transaction.GetAmount(), transaction.GetDate());
            }

        }
        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}
