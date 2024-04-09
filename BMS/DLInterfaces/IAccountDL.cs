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
        bool SaveAccountInfo(Account account);
        bool UpdateBalanceOnTransactions(int newBalance, string AccountHolder);
        bool UpdateAccountInfo(Account account, string prevAccountHolder);

        bool DeleteAccount(Account accountToDelete);
    }
}
