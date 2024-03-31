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
            string SocialSecurityNumber, int MonthlyIncome, int IntialDeposit,string AccountHolder)
        {
            account = new Account(DateOfBirth, Address,
                Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit,AccountHolder);
        }
        public void CreateCheckingAccount(
            string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit, string AccountHolder)
        {
            account = new Account(DateOfBirth, Address, Phone,
                SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder);
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
        public string GetCustomerName() // get account holder name
        {
            return user.GetUsername();
        }
    }
}
