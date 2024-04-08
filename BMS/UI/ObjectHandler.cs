using BMS.DL;
using BMS.DL.FH;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.UI
{
    internal class ObjectHandler
    {
        /* private static IAccountDL accountDL = new AccountDB();
          private static IMUserDL userDL = new MUserDB();
          private static ITransactionDL transactionDL = new TransactionDB();*/

        private static IAccountDL accountDL = new AccountFH();
        private static IMUserDL userDL = new MUserFH();
        private static ITransactionDL transactionDL = new TransactionFH();

        public static IAccountDL GetAccountDL()
        {
            return accountDL;
        }

        public static IMUserDL GetUserDL()
        {
            return userDL;
        }

        public static ITransactionDL GetTransactionDL()
        {
            return transactionDL;
        }
    }
}
