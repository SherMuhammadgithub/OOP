using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT4
{
    internal class Account
    {
        protected string accountNumber;
        protected string accountHolder;
        protected double balance;

        public Account(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public string GetAccountHolder()
        {
            return accountHolder;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
    
    }
}
