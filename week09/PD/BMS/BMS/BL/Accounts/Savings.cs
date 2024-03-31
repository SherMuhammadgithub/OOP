using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class Savings : Account
    {
        // private string AccountType = "Savings"; will be set in future
        public Savings( string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit, string AccountHolder) : base(  DateOfBirth, Address, Phone, SocialSecurityNumber,
                MonthlyIncome, IntialDeposit, AccountHolder)
        {
        }

        public int MonthlyFee()
        {
            // if the monthly income is less than 1000, the monthly fee is 10
            if (MonthlyIncome < 1000)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        public int InterestRate()
        {
            // if the initial deposit is less than 1000, the interest rate is 1%
            if (IntialDeposit < 1000)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
