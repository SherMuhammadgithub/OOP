using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public class Savings : Account
    {
        public Savings(string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit, string AccountHolder, string AccountType) : base(DateOfBirth, Address, Phone, SocialSecurityNumber,
                MonthlyIncome, IntialDeposit, AccountHolder, AccountType)
        {
        }

        public override int MonthlyFee()
        {
            if (MonthlyIncome < 1000)
            {
                return 30;
            }
            else
            {
                return 1000;
            }
        }
        public override int InterestRate()
        {
            if (IntialDeposit < 1000)
            {
                return 3;
            }
            else
            {
                return 40;
            }
        }
    }
}
