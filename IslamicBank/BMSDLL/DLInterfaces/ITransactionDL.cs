using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    public interface ITransactionDL
    {
        List<trans> GetTransactions();
        void LoadTransactionData();
        bool SaveTransactionInfo(trans transaction);
        List<trans> GetTransactionsForSpecificAccount(string AccountHolder);
         bool UpdtateAccountHolder(string AccountHolder, string NewAccountHolder);
        bool DeleteTransaction(string AccountHolder);
    }
}
