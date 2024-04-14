using BMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public class trans
    {
        private string TransactionType;
        private int Amount;
        private DateTime Date;
        private string AccountHolder; // name for account holder foreign key****
        public trans(string TransactionType, int Amount, string accountHolder)
        {
            this.TransactionType = TransactionType;
            this.Amount = Amount;
            Date = DateTime.Now;
            AccountHolder = accountHolder;
        }
        public string GetTransactionType()
        {
            return TransactionType;
        }
        public int GetAmount()
        {
            return Amount;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public void SetAccountHolder(string accountHolder)
        {
            AccountHolder = accountHolder;
        }
        public string GetAccountHolder()
        {
            return AccountHolder;
        }

    }
}
