using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT4
{
    internal class Savings : Account
    {
        private double interestRate;

        public Savings(string accountNumber, string accountHolder, double balance, double interestRate) : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }
        public void AddInterest()
        {
            balance += balance * interestRate;
        }
        public void CalculateInterest(int months)
        {
            double interest = balance * interestRate * months;
            Console.WriteLine($"Interest for {months} months is {interest}");
        }
    }
}
