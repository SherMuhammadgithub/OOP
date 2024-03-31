using BMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.BL
{
    internal class Account
    {
        protected string DateOfBirth;
        protected string Address;
        protected int Phone;
        protected string SocialSecurityNumber;
        protected int MonthlyIncome;
        protected int IntialDeposit;
        protected int AccountNumber; // name for account holder foreign key****
        protected string AccountHolder;
        protected List<Transactions> transactions;
        public Account( string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit,string AccountHolder)
        {
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Phone = Phone;
            this.SocialSecurityNumber = SocialSecurityNumber;
            this.MonthlyIncome = MonthlyIncome;
            this.IntialDeposit = IntialDeposit;
            this.AccountHolder = AccountHolder;
            transactions = new List<Transactions>();
        }
        public string GetAccountHolder() // get account holder name
        {
           return AccountHolder;
        }
        public string GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public string GetAddress() { 
            return Address;
        }
        public int GetPhone()
        {
            return Phone;
        }
        public string GetSocialSecurityNumber()
        {
            return SocialSecurityNumber;
        }
        public int GetMonthlyIncome()
        {
            return MonthlyIncome;
        }
        public int GetIntialDeposit()
        {
            return IntialDeposit;
        }
        // generate account number for the user
        public int GetAccountNumber()
        {
            Random random = new Random();
            AccountNumber = random.Next(10000000, 99999999);
            return AccountNumber;
        }
        // in case when account number is already generated and stored in the database
        public void SetAccountNumber(int accNo)
        {
            AccountNumber = accNo;
        }
        public void Deposit(int amount)
        {
            if(amount > 0)
            {
                IntialDeposit += amount;
                // Add to transaction
                Transactions transaction = new Transactions("Deposit",amount,AccountHolder);
                bool isSaved = TransactionDL.SaveToDatabase(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    AccountDL.UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
                }
                transactions.Add(transaction);
            }
        }
        public void Withdraw(int amount)
        {
           if(IntialDeposit - amount >= 0)
            {
                IntialDeposit -= amount;
                // Add to transaction
                Transactions transaction = new Transactions("Withdraw", amount, AccountHolder);
                bool isSaved = TransactionDL.SaveToDatabase(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    AccountDL.UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
                }
                transactions.Add(transaction);
            }
           else
            {
                 MessageBox.Show("Insufficient balance");
            }
        }
        // transfer money to another account
        // 
        public void Transfer(int amount, Account account)
        {
            if(IntialDeposit - amount >= 0)
            {
                IntialDeposit -= amount;
                account.Deposit(amount); // deposit to the other account
                // Add to transaction
                Transactions transaction = new Transactions("Transfer", amount, AccountHolder);
                bool isSaved = TransactionDL.SaveToDatabase(transaction);
                if(isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    AccountDL.UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
                }
                transactions.Add(transaction);
            }
        }
    }
}
