using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public class MUser
    {
        private string username;
        private string password;
        private string role;
        private Account account;
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
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
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public void SetRole(string role)
        {
            this.role = role;
        }
        // create account
      public void CreateAccount(string DateOfBirth, string Address, int Phone, string SocialSecurityNumber,
                     int MonthlyIncome, int IntialDeposit, string AccountHolder, string AccountType)
        {
            if (AccountType.ToLower() == "checking")
            {
                account = new Checking(DateOfBirth, Address, Phone, SocialSecurityNumber,
                                   MonthlyIncome, IntialDeposit, AccountHolder, AccountType);
            }
            else if (AccountType.ToLower() == "savings")
            {
                account = new Savings(DateOfBirth, Address, Phone, SocialSecurityNumber,
                                   MonthlyIncome, IntialDeposit, AccountHolder, AccountType);
            }
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
    
       

    }
}
