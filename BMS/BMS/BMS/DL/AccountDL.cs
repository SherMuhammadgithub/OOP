using BMS.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.DL
{
    internal class AccountDL
    {
        public static List<Account> accounts = new List<Account>();
        public static void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public static List<Account> GetAccounts()
        {
            return accounts;
        }
        public static void LoadAccounts() // try catch has been used
        {
            string Query = "SELECT * FROM Accounts";
            DataTable dt = Function.GetData(Query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Account account = new Account(row["DOB"].ToString(),
                        row["Address"].ToString(), Convert.ToInt32(row["Phone"]),
                        row["SSN"].ToString(), Convert.ToInt32(row["Income"]),
                        Convert.ToInt32(row["Balance"]), row["AccountHolder"].ToString(), row["AccountType"].ToString());
                    account.SetAccountNumber(Convert.ToInt32(row["AccountNumber"]));
                    AddAccount(account);
                }
            }

        }
        public static Account isAccountExists(string CurrentCustomerName)
        {
            // check if the user is in the list
            foreach (Account account in accounts)
            {
                MessageBox.Show(CurrentCustomerName + "" + account.GetAccountHolder());
                // check if the account holder name is in the list and trim spaces
                if (account.GetAccountHolder().Trim().Equals(CurrentCustomerName.Trim()))
                {
                    return account;
                }
            }
                return null;
        }
        public static void SaveAccountToDataBase(Account account)
        {
            string Query = "INSERT INTO Accounts (DOB, Address, Phone, SSN, Income, Balance, AccountHolder,AccountType,AccountNumber) VALUES ('{0}','{1}',{2},'{3}',{4},{5},'{6}','{7}',{8})";
            MessageBox.Show(account.GetAccountNumber().ToString());
            Query = string.Format(Query, account.GetDateOfBirth(), account.GetAddress(), account.GetPhone(), account.GetSocialSecurityNumber(), account.GetMonthlyIncome(), account.GetIntialDeposit(), account.GetAccountHolder(),account.GetType(),account.GetAccountNumber());
            Function.SetData(Query);
        }
        public static void UpdateBalanceOnTransactions(int newBalance, string AccountHolder)
        {
            string Query = $"UPDATE Accounts SET Balance = {newBalance} WHERE AccountHolder = '{AccountHolder}'";
            int rowsAffected = Function.SetData(Query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Balance updated");
            }
        }
        public static void UpdateAccountInfo(Account account, string prevAccountHolder)
        {
            string Query = $"UPDATE Accounts SET AccountHolder = '{account.GetAccountHolder()}', DOB = '{account.GetDateOfBirth()}', Address = '{account.GetAddress()}', Phone = {account.GetPhone()}, SSN = '{account.GetSocialSecurityNumber()}', Income = {account.GetMonthlyIncome()}, Balance = {account.GetIntialDeposit()} WHERE AccountHolder = '{prevAccountHolder}'";
            int rowsAffected = Function.SetData(Query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Account updated");
            }
        }
        // update account in the list when the account holder name is updated
        public static void UpdateAccountInList(Account account, string prevAccountHolder)
        {
            foreach (Account acc in accounts)
            {
                if (acc.GetAccountHolder().Equals(prevAccountHolder))
                {
                    acc.SetAccountHolder(account.GetAccountHolder());
                    acc.SetDateOfBirth(account.GetDateOfBirth());
                    acc.SetAddress(account.GetAddress());
                    acc.SetPhone(account.GetPhone());
                    acc.SetSocialSecurityNumber(account.GetSocialSecurityNumber());
                    acc.SetMonthlyIncome(account.GetMonthlyIncome());
                    acc.SetIntialDeposit(account.GetIntialDeposit());
                }
            }
        }
       
    }
}
