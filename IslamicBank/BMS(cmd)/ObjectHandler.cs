using BMS.DL;
using BMS.DL.DB;
using BMS.DL.FH;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_cmd_
{
    internal class ObjectHandler
    {
       //private static IMUserDL mUserDL = new MUserFH();
       //private static IAccountDL mAccountDL = new AccountFH();
       //private static ILoanDL mLoanDL = new LoanFH();
       //private static ITransactionDL mTransactionDL = new TransactionFH();
       //private static IReportedAccount reportedAccount = new ReportedAccountFH();
       private static IMUserDL mUserDL = new MUserDB();
        private static IAccountDL mAccountDL = new AccountDB();
        private static ILoanDL mLoanDL = new LoanDB();
        private static ITransactionDL mTransactionDL = new TransactionDB();
        private static IReportedAccount reportedAccount = new ReportedAccountDB();
        public static IMUserDL GetUserDL()
        {
            return mUserDL;
        }
        public static IAccountDL GetAccountDL()
        {
            return mAccountDL;
        }
        public static ILoanDL GetLoanDL()
        {
            return mLoanDL;
        }
        public static ITransactionDL GetTransactionDL()
        {
            return mTransactionDL;
        }

        public static IReportedAccount GetReportedAccountDL()
        {
            return reportedAccount;
        }



    }
}
