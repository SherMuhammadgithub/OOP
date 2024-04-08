using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    internal interface ITransactionDL
    {
        List<Transactions> GetTransactions();
        void LoadTransactionData();
        bool SaveTransactionInfo(Transactions transaction);
        List<Transactions> GetTransactionsForSpecificAccount(string AccountHolder);
         void UpdtateAccountHolder(string AccountHolder, string NewAccountHolder);
    }
}
