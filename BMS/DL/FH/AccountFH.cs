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
    internal class AccountFH : IAccountDL
    {
        public static List<Account> accounts = new List<Account>();
        public bool SaveAccountInfo(Account account)
        {
            accounts.Add(account);
            // saving to file
           bool isSavedInFile = SaveAccountInfoInFile(account);
            if(isSavedInFile)
            {
                return true;
            }
            return false;
        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
        public void LoadAccounts()
        {
            try
            {
                using (StreamReader reader = new StreamReader("accounts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        // Ensure enough data for account columns
                        if (data.Length >= 9) 
                        {
                            string accountType = data[0];
                            string dob = data[1];
                            string address = data[2];
                            int phone = int.Parse(data[3]);
                            string ssn = data[4];
                            int income = int.Parse(data[5]);
                            int balance = int.Parse(data[6]);
                            string accountHolder = data[7];
                            int accountNumber = int.Parse(data[8]);
                            if (accountType.Equals("savings"))
                            {
                              Savings  account = new Savings(dob, address, phone, ssn, income, balance, accountHolder,accountType);
                                account.SetAccountNumber(accountNumber);
                                // Add account to list
                                accounts.Add(account);
                            }
                            else if (accountType.Equals("checking"))
                            {
                              Checking  account = new Checking(dob, address, phone, ssn, income, balance, accountHolder, accountType);
                                account.SetAccountNumber(accountNumber);
                                // Add account to list
                                accounts.Add(account);
                            }

                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading accounts from file: " + ex.Message);
            }
        }
        // checking if account exists
        public Account isAccountExists(string CurrentCustomerName)
        {
            foreach (Account account in accounts)
            {
                MessageBox.Show(CurrentCustomerName + "" + account.GetAccountHolder());

                if (account.GetAccountHolder().Trim().Equals(CurrentCustomerName.Trim()))
                {
                    return account;
                }
            }
            return null;
        }
        // saving to file
        public bool SaveAccountInfoInFile(Account account)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("accounts.txt", true)) // Append mode
                {
                    string accountData = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                      account.GetAccountType(),
                      account.GetDateOfBirth(),
                      account.GetAddress(),
                      account.GetPhone(),
                      account.GetSocialSecurityNumber(), // bcrpyt this data before saving in future
                      account.GetMonthlyIncome(),
                      account.GetIntialDeposit(),
                      account.GetAccountHolder(),
                      account.GetAccountNumber()
                    );
                    writer.WriteLine(accountData);
                }
                return true;
            }
            catch (Exception ex)
            {
             
                Console.WriteLine("Error saving account to file: " + ex.Message);
                return false;
            }
        }
        // updating balance in file
        public bool UpdateBalanceOnTransactions(int newBalance,  string AccountHolder)
        {
            
            try
            {
                string tempFile = Path.GetTempFileName();
                using (StreamReader reader = new StreamReader("accounts.txt"))
                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        // Ensure enough data for account columns
                        if (data.Length >= 9) 
                        {
                            string accountType = data[0];
                            string dob = data[1];
                            string address = data[2];
                            int phone = int.Parse(data[3]);
                            string ssn = data[4];
                            int income = int.Parse(data[5]);
                            int balance = int.Parse(data[6]);
                            string accountHolder = data[7];
                            int accountNumber = int.Parse(data[8]);
                            if (accountHolder.Equals(AccountHolder))
                            {
                                // Update balance
                                balance = newBalance;
                            }
                            string accountData = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                                                                                            accountType,
                                                                                                                                                                                     dob,
                                                                                                                                                                                                                                                                                                           address,
                                                                                                                                                                                                                                                                                                                                                                                                                                                              phone,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ssn,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           income,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     balance,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            accountHolder,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                accountNumber
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     );
                            writer.WriteLine(accountData);
                        }
                    }
                }
                File.Delete("accounts.txt");
                File.Move(tempFile, "accounts.txt");
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error updating balance in file: " + ex.Message);
                return false;
            }
        }

        //  updating in file
        public bool UpdateAccountInfo(Account account, string prevAccountHolder)
        {
            string accountsFile = "accounts.txt"; 

            try
            {
                List<string> updatedLines = new List<string>();

                // Read all lines from the file
                using (StreamReader reader = new StreamReader(accountsFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 9)
                        {
                            string accountHolder = data[7];
                            // Check if account holder matches
                            if (accountHolder.Equals(prevAccountHolder))
                            {
                                // Update account information
                                string updatedLine = string.Join(",",
                                    data[0],  // Assuming accountType at index 0
                                    account.GetDateOfBirth(),  
                                    account.GetAddress(),  
                                    account.GetPhone(),
                                    data[4],  // Assuming ssn at index 4 , this will not be updated
                                    account.GetMonthlyIncome(),
                                    account.GetIntialDeposit(),
                                    account.GetAccountHolder(),
                                    data[8]); // Assuming accountNumber at index 8, this will not be updated
                                updatedLines.Add(updatedLine);
                            }
                            else
                            {
                                // Add original line if not updated
                                updatedLines.Add(line);  
                            }
                        }
                    }
                }

                // Write all lines back to the file
                using (StreamWriter writer = new StreamWriter(accountsFile))
                {
                    foreach (string line in updatedLines)
                    {
                        writer.WriteLine(line);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating account information: " + ex.Message);
                return false;
            }
        }
        // delete account in list
        public bool DeleteAccount(Account accountToDelete)
        {
            // Use RemoveAll to remove matching accounts while iterating
            accounts.RemoveAll(account => account.GetAccountHolder().Trim().Equals(accountToDelete.GetAccountHolder().Trim()));

            bool isDeletedFromDb = DeleteAccountInFile(accountToDelete);
            if (isDeletedFromDb)
            {
                MessageBox.Show("d    Accccount");
                return true;
            }
            MessageBox.Show("i am not runned");
            return false;
        }

        // delete account in file
        public bool DeleteAccountInFile(Account account)
        {
            try
            {
                // Create a temporary file
                string tempFile = Path.GetTempFileName();
                // Read all lines from the file
                using (StreamReader reader = new StreamReader("accounts.txt"))
                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 9)
                        {
                            string accountHolder = data[7];

                            // Check if account holder does NOT match 
                            if (!accountHolder.Equals(account.GetAccountHolder()))
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }

                // Delete original file
                File.Delete("accounts.txt");
                // Rename temporary file to original file
                File.Move(tempFile, "accounts.txt");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting account from file: " + ex.Message);
                return false;
            }
        }
    }
}
