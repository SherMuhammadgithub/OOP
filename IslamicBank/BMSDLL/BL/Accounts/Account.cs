using BMS.DL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public abstract class Account
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
                return true;
            }
            return false;
        }
        public bool Withdraw(int amount)
        {
           if(IntialDeposit - amount >= 0)
            {
                IntialDeposit -= amount;
                return true;
            }
          return false;
        }
        public bool Transfer(int amount)
        {
           if(IntialDeposit - amount >= 0)
            {
                IntialDeposit -= amount;
                return true;
            }   
            return false;
        }
       
       //polymorphic method
        public void SetTransactions(List<trans> transactions) // overloading method for adding list of transactions
        {
            this.transactions = transactions;
        }
        public void SetTransactions(trans transaction) // overloading method for adding single transaction
        {
            this.transactions.Add(transaction);
        }
        public bool CreateLoan(Loan l)
        {
            if(loan != null)
            {
                return false;
            }
            loan = l;
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
