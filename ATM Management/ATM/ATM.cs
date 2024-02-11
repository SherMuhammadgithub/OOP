using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public  int Balance;
        public ATM(int ba)
        {
            Balance = ba;
        }
      
       List <string> transactions = new List<string> ();
        public void Deposit(int money)
        {
             Balance += money;
            setHistory(money, "deposit");
        }
        public void WithDraw(int money)
        {
             Balance -= money;
            setHistory(money, "withdraw");
        }
        public void CheckBalance()
        {

            Console.WriteLine($"Current Balance: {Balance}");
        }
        public void setHistory(int money, string type)
        {
            string his = money.ToString();
            string go = his + " " + type;
            transactions.Add(go);
        }
        public void showHistory()
        {
            Console.WriteLine("History of Transactions");
            foreach(var history in transactions)
            {
                Console.WriteLine(history);
            }
        }
    }
}
