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
    internal class TransactionFH : ITransactionDL
    {
        public static List<Transactions> transactions = new List<Transactions>();
        public bool SaveTransactionInfo(Transactions transaction)
        {
            transactions.Add(transaction);
            // saving to file
            SaveDataToFile(transaction);
            return true;
        }
        public List<Transactions> GetTransactions()
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
                            Transactions transaction = new Transactions(
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
                            Console.WriteLine($"Error parsing data on line: {line} ({ex.Message})");
                        }
                        catch (Exception ex) // Catch other potential exceptions
                        {
                            Console.WriteLine($"Error loading transaction: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error loading transactions: {ex.Message}");
            }
        }

         // saving to file
        public void SaveDataToFile(Transactions transaction)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("transactions.txt", true))
                {
                    writer.WriteLine(transaction.GetTransactionType() + "," + transaction.GetAmount() + "," + transaction.GetAccountHolder() + "," + transaction.GetDate());
                    MessageBox.Show("Transaction Saved in the file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Transactions> GetTransactionsForSpecificAccount(string AccountHolder)
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
           // updating account holder when account holder is changed
        public void UpdtateAccountHolder(string AccountHolder, string NewAccountHolder)
        {
            foreach (Transactions transaction in transactions)
            {
                if (transaction.GetAccountHolder().Trim().Equals(AccountHolder.Trim()))
                {
                    transaction.SetAccountHolder(NewAccountHolder);
                    // update in file
                    UpdateAccountHolderInFile(AccountHolder, NewAccountHolder);
                }
            }
        }
          // updating account holder in file
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
