
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savings savings = new Savings("123", "Sher", 1000, 0.02);
            savings.AddInterest();
            savings.CalculateInterest(6); // interest for 6 months
            Console.WriteLine($"Savings balance is {savings.GetBalance()}");

            // Account ----2
            Current current = new Current("456", "John", 1000, 500);
            current.AddInterest();
            current.CalculateInterest(6); // interest for 6 months
            Console.WriteLine($"Current balance is {current.GetBalance()}");
            current.Overdraft(1500);
            Console.WriteLine($"Current balance is {current.GetBalance()}");

        }
    }
}
