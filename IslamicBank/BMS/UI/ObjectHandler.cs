using BMS.DL;
using BMS.DL.DB;
using BMS.DL.FH;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.UI
{
    internal class ObjectHandler
    {
        //private static IAccountDL accountDL = new AccountDB();
        //private static IMUserDL userDL = new MUserDB();
        //private static ITransactionDL transactionDL = new TransactionDB();
        //private static ILoanDL loanDL = new LoanDB();
        //private static IReportedAccount reportedAccountDL = new ReportedAccountDB();
        private static IAccountDL accountDL = new AccountFH();
        private static IMUserDL userDL = new MUserFH();
        private static ITransactionDL transactionDL = new TransactionFH();
        private static ILoanDL loanDL = new LoanFH();
        public static IReportedAccount reportedAccountDL = new ReportedAccountFH();
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
        public static ILoanDL GetLoanDL()
        {
            return loanDL;
        }
        public static IReportedAccount GetReportedAccountDL()
        {
            return reportedAccountDL;
        }
    }
}