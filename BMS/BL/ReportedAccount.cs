using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class ReportedAccount
    {
        private string AccountHolder;
        private string Reason;

        public ReportedAccount(string accountHolder, string reason)
        {
            AccountHolder = accountHolder;
            Reason = reason;
        }

        public string GetAccountHolder()
        {
            return AccountHolder;
        }

        public string GetReason()
        {
            return Reason;
        }
    }
}
