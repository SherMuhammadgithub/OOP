using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT4
{
    internal class Current : Account
    {
        private double overdraftLimit;
        private double Interest;
        public Current(string accountNumber, string accountHolder, double balance, double overdraftLimit) : base(accountNumber, accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public void AddInterest()
        {
            balance += 2*(balance * Interest); // current has more interest than savings
        }
        public void CalculateInterest(int months)
        {
            double interest = balance * Interest * months;
            Console.WriteLine($"Interest for {months} months is {interest}");
        }
        public void Overdraft(double amount)
        {
            if (amount > overdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
            else
            {
                balance -= amount;
            }
        }
        

    }
}
