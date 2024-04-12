using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    internal interface ILoanDL
    {
        bool SaveLoan(Loan loan);
         bool LoadLoanData();
        Loan isLoanExists(string AccountHolder);
        bool UpdateLoanInfo(string newName, string prevAccountHolder);
        bool DeleteLoan(Loan loan);
    }
}
