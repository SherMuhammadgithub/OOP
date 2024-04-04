using BMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.BL
{
    internal abstract class Account
    {
        protected string DateOfBirth;
        protected string Address;
        protected int Phone;
        protected string SocialSecurityNumber;
        protected int MonthlyIncome;
        protected int IntialDeposit;
        protected int AccountNumber;
        protected string AccountHolder;   // name for account holder foreign key****
        protected List<Transactions> transactions;
        protected string AccountType;
        public Account( string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit,string AccountHolder, string AccountType)
        {
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Phone = Phone;
            this.SocialSecurityNumber = SocialSecurityNumber;
            this.MonthlyIncome = MonthlyIncome;
            this.IntialDeposit = IntialDeposit;
            this.AccountHolder = AccountHolder;
            this.AccountType = AccountType;
            transactions = new List<Transactions>();
        }
        public string GetAccountType()
        {
            return AccountType;
        }
        public string GetAccountHolder() 
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
        public void GenerateAccountNumber()
        {
            Random random = new Random();
            AccountNumber = random.Next(10000000, 99999999);
        }
        public int GetAccountNumber()
        {
           return AccountNumber;
        }
        public void SetAccountNumber(int accNo)
        {
            AccountNumber = accNo;
        }

        public void SetAccountHolder(string AccountHolder)
        {
            this.AccountHolder = AccountHolder;
        }
        public void SetDateOfBirth(string DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
        }
        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public void SetPhone(int Phone)
        {
            this.Phone = Phone;
        }
        public void SetSocialSecurityNumber(string SocialSecurityNumber)
        {
            this.SocialSecurityNumber = SocialSecurityNumber;
        }
        public void SetMonthlyIncome(int MonthlyIncome)
        {
            this.MonthlyIncome = MonthlyIncome;
        }
        public void SetIntialDeposit(int IntialDeposit)
        {
            this.IntialDeposit = IntialDeposit;
        }
        private void SetBalance(int amount)
        {
            IntialDeposit = amount;
        }

        public void Deposit(int amount)
        {
            if(amount > 0)
            {
                IntialDeposit += amount;
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
        public void Transfer(int amount, Account accountToTransfer,Account currentAccount)
        {
            int Balance = currentAccount.GetIntialDeposit();
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                currentAccount.SetBalance(Balance);
                accountToTransfer.Deposit(amount, accountToTransfer); // deposit to other account

                Transactions transaction = new Transactions("Transfer", amount, currentAccount.GetAccountHolder());
                transactions.Add(transaction);
                bool isSaved = TransactionDL.SaveToDatabase(transaction);
                if(isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    AccountDL.UpdateBalanceOnTransactions(Balance, currentAccount.GetAccountHolder());
                }
            }
        }
       
       //polymorphic method
        private void Deposit(int amount,Account account)
        {
            int Balance = account.GetIntialDeposit();
            if (amount > 0)
            {
                Balance += amount;
                account.SetBalance(Balance);
                // Add to transaction
                Transactions transaction = new Transactions("Deposit", amount, account.GetAccountHolder());
                bool isSaved = TransactionDL.SaveToDatabase(transaction);
                transactions.Add(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    AccountDL.UpdateBalanceOnTransactions(Balance, account.GetAccountHolder());
                }
            }
        }
        // abstract methods
        public abstract int MonthlyFee();
        public abstract int InterestRate();
    }
}
