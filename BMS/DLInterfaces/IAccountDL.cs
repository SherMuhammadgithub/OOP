using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    internal interface IAccountDL
    {
        List<Account> GetAccounts();
        void LoadAccounts();
        Account isAccountExists(string currentUserName);
        void SaveAccountInfo(Account account);
        void UpdateBalanceOnTransactions(int newBalance, string AccountHolder);
        void UpdateAccountInfo(Account account, string prevAccountHolder);
    }
}
