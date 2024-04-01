using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class Customer
    {
        private MUser user;
        private Account account;
        public Customer(MUser user)
        {
            this.user = user;
        }
        public void CreateSavingsAccount(
            string DateOfBirth, string Address, int Phone,
            string SocialSecurityNumber, int MonthlyIncome, int IntialDeposit,string AccountHolder,string AccountType)
        {
            account = new Savings(DateOfBirth, Address,
                Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit,AccountHolder, AccountType);
        }
        public void CreateCheckingAccount(
            string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit, string AccountHolder,string AccountType)
        {
            account = new Checking(DateOfBirth, Address, Phone,
                SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder,AccountType);
        }

        public Account GetAccount()
        {
            if (account != null) return account;
            return null;
        }
        public bool SetCurrentAccount(Account ac)
        {
            if (ac != null)
            {
                this.account = ac;
                return true;
            }
            return false;
        }
        public string GetCustomerName()
        {
            return user.GetUsername();
        }
    }
}
