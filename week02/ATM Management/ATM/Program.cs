using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(400); // atm comments
            atm.CheckBalance();
            atm.Deposit(100);
            atm.Deposit(100);
            atm.CheckBalance();
            atm.WithDraw(50);
            atm.WithDraw(50);
            atm.CheckBalance();
            atm.showHistory();
        }
    }
}
