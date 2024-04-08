using BMS.DL;
using BMS.DLInterfaces;
using BMS.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        private Loan loan;
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
        public void SetBalance(int amount)
        {
            IntialDeposit = amount;
        }
       
        public void SetLoan(Loan loan)
        {
            this.loan = loan;
        }
        public Loan GetLoan()
        {
            return loan;
        }
        public void Deposit(int amount)
        {
            if(amount > 0)
            {
                IntialDeposit += amount;
                Transactions transaction = new Transactions("Deposit",amount,AccountHolder);
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
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
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
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
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                if(isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(Balance, currentAccount.GetAccountHolder());
                }
                currentAccount.SetTransactions(transaction); 
            }
            else
            {
               MessageBox.Show("Insufficient balance");
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
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                if (isSaved)
                {
                    MessageBox.Show("Transaction saved successfully");
                    ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(Balance, account.GetAccountHolder());
                }
                account.SetTransactions(transaction);
                
            }
        }
        public void SetTransactions(List<Transactions> transactions) // overloading method for adding list of transactions
        {
            this.transactions = transactions;
        }
        public void SetTransactions(Transactions transaction) // overloading method for adding single transaction
        {
            this.transactions.Add(transaction);
        }
        public bool CreateLoan(string AccountHolder, int LoanAmount, int MonthlyPayment)
        {
            if(loan != null)
            {
                return false;
            }
            loan = new Loan(AccountHolder, LoanAmount, MonthlyPayment);
            ObjectHandler.GetLoanDL().SaveLoan(loan); /// save loan
            return true;
        }
        public List<Transactions> GetTransactions()
        {
            return transactions;
        }
        public abstract int MonthlyFee();
        public abstract int InterestRate();
    }
}
