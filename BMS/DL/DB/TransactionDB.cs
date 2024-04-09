using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BMS.DL
{
    internal class TransactionDB : ITransactionDL
    {
        public static List<trans> transactions = new List<trans>();
        public  void AddTransaction(trans transaction)
        {
            transactions.Add(transaction);
        }
        public  List<trans> GetTransactions()
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
                    trans transaction = new trans(row["TransactionType"].ToString(),
                                               Convert.ToInt32(row["Amount"]), row["AccountHolder"].ToString());
                    transaction.SetDate(Convert.ToDateTime(row["Date"]));
                    AddTransaction(transaction);

            }  
            }
        }
        public  bool SaveTransactionInfo(trans transaction)
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
        public  List<trans> GetTransactionsForSpecificAccount(string AccountHolder)
        {
            List<trans> transactionsForAccountHolder = new List<trans>();
            foreach (trans transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transactionsForAccountHolder.Add(transaction);
                }
            }
            return transactionsForAccountHolder;
        }
        public bool UpdtateAccountHolderInList(string AccountHolder, string NewAccountHolder)
        {
            foreach (trans transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transaction.SetAccountHolder(NewAccountHolder);
                    return true;
                }
            }
            return false;
        }
        public bool UpdtateAccountHolder(string AccountHolder, string NewAccountHolder)
        {
            string Query = $"UPDATE Transactions SET AccountHolder = '{NewAccountHolder}' WHERE AccountHolder = '{AccountHolder}'";
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
               
                UpdtateAccountHolderInList(AccountHolder, NewAccountHolder);
                return true;
            }
            return false;
        }
        // delete transaction from list
        public bool DeleteTransaction(string AccountHolder)
        {
            // delete  from all occurences
            transactions.RemoveAll(transaction => transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim())); // remove all transactions with the account holder
            // update in file
            bool isDeletedInDb = DeleteTransactionInDb(AccountHolder);
            return isDeletedInDb;
        }
        // delete transaction from database
        public bool DeleteTransactionInDb(string AccountHolder)
        {
            string Query = "Delete FROM Transactions WHERE AccountHolder = '{0}'";
            Query = string.Format(Query, AccountHolder);
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
