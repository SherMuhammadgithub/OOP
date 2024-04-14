using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    public interface IReportedAccount
    {
        bool SaveReportedAccountInfo(ReportedAccount reportedAccount);
         void LoadReportedAccountData();
        ReportedAccount isReported(string accountHolder);
        bool UnreportAccount(string accountHolder);
    }
}
