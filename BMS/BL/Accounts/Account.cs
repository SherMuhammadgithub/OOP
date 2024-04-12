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
        protected int MonthlyIncome = 0;
        protected int IntialDeposit = 0;
        protected int AccountNumber;
        protected string AccountHolder;   // name for account holder foreign key****
        protected List<trans> transactions;
        private Loan loan;
        protected string AccountType;
        protected int Debt = 0; // debt for the account
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
            transactions = new List<trans>();
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
        public  int GetDebt()
        {
            // add previous debt
            return Debt;
        }
        public void SetDebt(int Debt)
        {
            this.Debt = Debt;
        }
        public bool Deposit(int amount)
        {
            if(amount > 0)
            {
                IntialDeposit += amount;
                trans transaction = new trans("Deposit",amount,AccountHolder);
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
                    if (isSaved && isUpdated)
                {
                transactions.Add(transaction);
                    return true;
                }
            }
            return false;
        }
        public bool Withdraw(int amount)
        {
           if(IntialDeposit - amount >= 0)
            {
                IntialDeposit -= amount;
                trans transaction = new trans("Withdraw", amount, AccountHolder);
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(IntialDeposit, AccountHolder);
                if (isSaved && isUpdated)
                {
                   transactions.Add(transaction);
                   return true;
                }
            }
          return false;
        }
        public bool Transfer(int amount, Account accountToTransfer,Account currentAccount)
        {
            int Balance = currentAccount.GetIntialDeposit();
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                currentAccount.SetBalance(Balance);
               bool isDespodited = accountToTransfer.Deposit(amount, accountToTransfer); // deposit to other account
                trans transaction = new trans("Transfer", amount, currentAccount.GetAccountHolder());
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(Balance, currentAccount.GetAccountHolder());
                if(isSaved && isDespodited && isUpdated)
                {
                    currentAccount.SetTransactions(transaction);
                    return true;
                }
            }
            return false;
        }
       
       //polymorphic method
        public bool Deposit(int amount,Account account)
        {
            int Balance = account.GetIntialDeposit();
            if (amount > 0)
            {
                Balance += amount;
                account.SetBalance(Balance);
                // Add to transaction
                trans transaction = new trans("Deposit", amount, account.GetAccountHolder());
                bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
                bool isUpdated = ObjectHandler.GetAccountDL().UpdateBalanceOnTransactions(Balance, account.GetAccountHolder());
                if (isSaved && isUpdated)
                {
                    account.SetTransactions(transaction);
                    return true;
                }
                
            }
                return false;
        }
        public void SetTransactions(List<trans> transactions) // overloading method for adding list of transactions
        {
            this.transactions = transactions;
        }
        public void SetTransactions(trans transaction) // overloading method for adding single transaction
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
        public List<trans> GetTransactions()
        {
            return transactions;
        }
        public abstract int MonthlyFee();
        public abstract int InterestRate();
    }
}
