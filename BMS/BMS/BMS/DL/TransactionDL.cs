using BMS.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL
{
    internal class TransactionDL
    {
        public static List<Transactions> transactions = new List<Transactions>();
        public static void AddTransaction(Transactions transaction)
        {
            transactions.Add(transaction);
        }
        public static List<Transactions> GetTransactions()
        {
            return transactions;
            
        }
        public static void LoadTransactionData() // bool will be made
        {
            string Query = "SELECT * FROM Transactions";
            DataTable dataTable = Function.GetData(Query);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Transactions transaction = new Transactions(row["TransactionType"].ToString(),
                                               Convert.ToInt32(row["Amount"]), row["AccountHolder"].ToString());
                    transaction.SetDate(Convert.ToDateTime(row["Date"]));
                    AddTransaction(transaction);

            }                }
        }
        public static bool SaveToDatabase(Transactions transaction)
        {
           string Query = "INSERT INTO Transactions (TransactionType, Amount, Date, AccountHolder) VALUES ('{0}',{1},'{2}','{3}')";
            Query = string.Format(Query, transaction.GetTransactionType(), transaction.GetAmount(), transaction.GetDate(), transaction.GetAccountHolder());
            int AffectedRows = Function.SetData(Query);
            if (AffectedRows > 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
