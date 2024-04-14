using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL.FH
{
    public class TransactionFH : ITransactionDL
    {
        public static List<trans> transactions = new List<trans>();
        public bool SaveTransactionInfo(trans transaction)
        {
            transactions.Add(transaction);
            // saving to file
            SaveDataToFile(transaction);
            return true;
        }
        public List<trans> GetTransactions()
        {
            return transactions;

        }
          // loading from file
        public void LoadTransactionData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("transactions.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        try
                        {
                            trans transaction = new trans(
                                data[0],
                                Convert.ToInt32(data[1]),
                                data[2]
                            );
                            transaction.SetDate(Convert.ToDateTime(data[3]));
                            // add to list
                            transactions.Add(transaction);
                        }
                        catch (FormatException ex)
                        {
                           // Console.WriteLine($"Error parsing data on line: {line} ({ex.Message})");
                        }
                        catch (Exception ex) // Catch other potential exceptions
                        {
                            //Console.WriteLine($"Error loading transaction: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"General error loading transactions: {ex.Message}");
            }
        }

         // saving to file
        public bool SaveDataToFile(trans transaction)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("transactions.txt", true))
                {
                    writer.WriteLine(transaction.GetTransactionType() + "," + transaction.GetAmount() + "," + transaction.GetAccountHolder() + "," + transaction.GetDate());
                    return true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<trans> GetTransactionsForSpecificAccount(string AccountHolder)
        {
            //MessageBox.Show(AccountHolder);
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
           // updating account holder when account holder is changed
        public bool UpdtateAccountHolder(string AccountHolder, string NewAccountHolder)
        {
            foreach (trans transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transaction.SetAccountHolder(NewAccountHolder);
                    // update in file
                    UpdateAccountHolderInFile(AccountHolder, NewAccountHolder);
                    return true;
                }
            }
            return false;
        }
          // updating account holder in file (bool)
        public void UpdateAccountHolderInFile(string AccountHolder, string NewAccountHolder)
        {
            try
            {
                string[] lines = File.ReadAllLines("transactions.txt");
                using (StreamWriter writer = new StreamWriter("transactions.txt"))
                {
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data[2].Trim().Equals(AccountHolder.Trim()))
                        {
                            writer.WriteLine(data[0] + "," + data[1] + "," + NewAccountHolder + "," + data[3]);
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        // delete transaction from list
        public bool DeleteTransaction(string AccountHolder)
        {
            // delete  from all occurences
            transactions.RemoveAll(transaction => transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim())); // remove all transactions with the account holder
            // update in file
            bool isDeletedInFIle = UpdateFileAfterDelete(AccountHolder);
            return isDeletedInFIle;
        }
        // delete transaction from file
        public bool UpdateFileAfterDelete(string AccountHolder)
        {
            try
            {
                string[] lines = File.ReadAllLines("transactions.txt");
                using (StreamWriter writer = new StreamWriter("transactions.txt"))
                {
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (!data[2].Trim().Equals(AccountHolder.Trim()))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
