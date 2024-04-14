using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BMS_cmd_.UI
{
    internal class UserUI
    {
        public static bool CreateAccount()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            
            string accountHolder = currentUser.GetUsername();

            Console.Write("Enter date of birth (YYYY-MM-DD): ");
            string dateOfBirth = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter phone number: ");
            int phone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter social security number (for illustration only): ");
            string socialSecurityNumber = Console.ReadLine();  // Avoid storing in practice

            Console.Write("Enter monthly income: ");
            int monthlyIncome = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter initial deposit amount: ");
            int initialDeposit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter account type (e.g., Savings, Checking): ");
            string accountType = Console.ReadLine();

            // Create account object (replace with actual logic)
                 currentUser.CreateAccount(dateOfBirth, address, phone,
                socialSecurityNumber, monthlyIncome, initialDeposit, 
                accountHolder, accountType);
            // generating account number for the user as user can't input it
            currentUser.GetAccount().GenerateAccountNumber();
            // saving account to db
            bool isSavedAndCreatd = ObjectHandler.GetAccountDL().SaveAccountInfo(currentUser.GetAccount());
            return isSavedAndCreatd;
        }
        public static bool UpdateAccount()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            string prevAccountHolder = currentAccount.GetAccountHolder();
            Console.WriteLine("Enter the new account holder: ");
            string accountHolder = Console.ReadLine();
            currentAccount.SetAccountHolder(accountHolder);
            currentUser.SetUsername(accountHolder);
            Console.WriteLine("Enter the new address: ");
            string address = Console.ReadLine();
            currentAccount.SetAddress(address);
            Console.WriteLine("Enter the new phone number: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            currentAccount.SetPhone(phone);
            Console.WriteLine("Enter the new monthly income: ");
            int monthlyIncome = Convert.ToInt32(Console.ReadLine());
            currentAccount.SetMonthlyIncome(monthlyIncome);
            bool isAccountUpdated,isUserUpdated = false;
            isAccountUpdated= ObjectHandler.GetAccountDL().UpdateAccountInfo(currentAccount, prevAccountHolder);
            // update accounthloder in loan, user, transactions and reported accounts
            isUserUpdated = ObjectHandler.GetUserDL().UpdateUserInfo(currentUser, prevAccountHolder);
             UpdateAccountHolder(prevAccountHolder, accountHolder);
            return isUserUpdated && isAccountUpdated;
        }
        public static void UpdateAccountHolder(string prevAccountHolder, string newAccountHolder)
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            ITransactionDL transactionDL = ObjectHandler.GetTransactionDL();
            // check if the transactions for the current acccount exists
            if (currentAccount.GetTransactions().Count > 0) // if transactions exists
            {
                transactionDL.UpdtateAccountHolder(prevAccountHolder, newAccountHolder);
            }

            if (currentAccount.GetLoan() != null)
            {
                currentAccount.GetLoan().SetAccountHolder(newAccountHolder);
                 ObjectHandler.GetLoanDL().UpdateLoanInfo(newAccountHolder, prevAccountHolder);
            }
        }
        public static bool isAccountAlreadyExist()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();

            Account account = ObjectHandler.GetAccountDL().isAccountExists(currentUser.GetUsername());
            if (account != null)
            {
                return true;
            }
            return false;
        }

    }
}
