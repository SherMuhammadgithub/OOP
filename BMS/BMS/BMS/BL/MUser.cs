using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class MUser
    {
        private string username;
        private string password;
        private string role;
        private Account account;

        // for sign up
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUser(string username)
        {
            this.username = username;
        }
        // for sign in
        public MUser(string uesr, string password)
        {
             username = uesr;
            this.password = password;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetRole()
        {
            return role;
        }
        // setter methods 
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        // checking if the user is admin or not
        public void CreateSavingsAccount(
          string DateOfBirth, string Address, int Phone,
          string SocialSecurityNumber, int MonthlyIncome, int IntialDeposit, string AccountHolder, string AccountType)
        {
            account = new Account(DateOfBirth, Address,
                Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder, AccountType);
        }
        public void CreateCheckingAccount(
            string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
            int MonthlyIncome, int IntialDeposit, string AccountHolder, string AccountType)
        {
            account = new Account(DateOfBirth, Address, Phone,
                SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder, AccountType);
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
        public bool IsAdmin()
        {
            // ignore the upper and lower case
            if (role.ToLower() == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
