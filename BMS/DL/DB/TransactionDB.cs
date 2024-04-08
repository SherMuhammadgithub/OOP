using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL
{
    internal class TransactionDB : ITransactionDL
    {
        public static List<Transactions> transactions = new List<Transactions>();
        public  void AddTransaction(Transactions transaction)
        {
            transactions.Add(transaction);
        }
        public  List<Transactions> GetTransactions()
        {
            return transactions;
            
        }
        public  void LoadTransactionData() 
        {
            string Query = "SELECT * FROM Transactions";
            DataTable dataTable = utills.GetData(Query);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Transactions transaction = new Transactions(row["TransactionType"].ToString(),
                                               Convert.ToInt32(row["Amount"]), row["AccountHolder"].ToString());
                    transaction.SetDate(Convert.ToDateTime(row["Date"]));
                    AddTransaction(transaction);

            }  
            }
        }
        public  bool SaveTransactionInfo(Transactions transaction)
        {
           string Query = "INSERT INTO Transactions (TransactionType, Amount, Date, AccountHolder) VALUES ('{0}',{1},'{2}','{3}')";
            Query = string.Format(Query, transaction.GetTransactionType(), transaction.GetAmount(), transaction.GetDate(), transaction.GetAccountHolder());
            int AffectedRows = utills.SetData(Query);
            if (AffectedRows > 0)
            {
                AddTransaction(transaction); // add transaction to the list
                return true;
                
            }
            return false;
            
        }
        // specific Transactions for specific account holder
        public  List<Transactions> GetTransactionsForSpecificAccount(string AccountHolder)
        {
            MessageBox.Show(AccountHolder);
            List<Transactions> transactionsForAccountHolder = new List<Transactions>();
            foreach (Transactions transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transactionsForAccountHolder.Add(transaction);
                }
            }
            return transactionsForAccountHolder;
        }
        public void UpdtateAccountHolderInList(string AccountHolder, string NewAccountHolder)
        {
            foreach (Transactions transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transaction.SetAccountHolder(NewAccountHolder);
                }
            }
        }
        public void UpdtateAccountHolder(string AccountHolder, string NewAccountHolder)
        {
            string Query = $"UPDATE Transactions SET AccountHolder = '{NewAccountHolder}' WHERE AccountHolder = '{AccountHolder}'";
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Account holder updated");
                UpdtateAccountHolderInList(AccountHolder, NewAccountHolder);
            }
        }
    }
}
