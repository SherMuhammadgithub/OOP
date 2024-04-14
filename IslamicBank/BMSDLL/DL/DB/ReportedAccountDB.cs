using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL.DB
{
    public class ReportedAccountDB : IReportedAccount
    {
        public static List<ReportedAccount> reportedAccounts = new List<ReportedAccount>();

        public bool SaveReportedAccountInfo(ReportedAccount reportedAccount)
        {
            reportedAccounts.Add(reportedAccount);
            // saving to database
            return SaveDataToDb(reportedAccount);
        }
       
        public bool SaveDataToDb(ReportedAccount reportedAccount)
        {
            string Query = "INSERT INTO ReportedAccounts (AccountHolder, Reason) VALUES ('{0}','{1}')";
            Query = string.Format(Query, reportedAccount.GetAccountHolder(), reportedAccount.GetReason());
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        // loading data
        public void LoadReportedAccountData()
        {
            string Query = "SELECT * FROM ReportedAccounts";
            DataTable dt = utills.GetData(Query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ReportedAccount reportedAccount = new ReportedAccount(row["AccountHolder"].ToString(), row["Reason"].ToString());
                    // add to list
                    reportedAccounts.Add(reportedAccount);
                }
            }

        }
         public ReportedAccount isReported(string accountHolder)
        {
            foreach (ReportedAccount reportedAccount in reportedAccounts)
            {
                if (reportedAccount.GetAccountHolder() == accountHolder)
                {
                    return reportedAccount;
                }
            }
            return null;
        }
        public bool UnreportAccount(string accountHolder)
        {
            ReportedAccount reportedAccount = isReported(accountHolder);
            if (reportedAccount != null)
            {
                reportedAccounts.Remove(reportedAccount);
                bool isUnreported = UnreportAccountInDB(accountHolder);

                return isUnreported;
            }
            return false;
        }
        // unreporting in the database
        public bool UnreportAccountInDB(string accountHolder)
        {
            string Query = $"DELETE FROM ReportedAccounts WHERE AccountHolder = '{accountHolder}'";
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}

