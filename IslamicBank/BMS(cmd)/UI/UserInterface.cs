using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_cmd_.UI
{

    internal class UserInterface
    {
       public enum MainMenu
        {
            login = 1,
            register = 2,
            exit = 3
        }
        public enum UserMenu
        {
            CreateAccount = 1,
            withdraw = 2,
            transfer = 3,
            deposit = 4,
            UpdateAccount = 5,
            ApplyForLoan = 6,
            logout = 7
        }
        public enum AdminMenu
        {
            ViewAllAccounts = 1,
            ViewSingleAccount = 2,
            ReportAccount = 3,
            UnReportAccount = 4,
            GiveLoan = 5,
            logout = 6
        }
        public static MainMenu ShowMainMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            return (MainMenu)option;
        }
        public static UserMenu ShowUserMenu()
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Transfer");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Update Account");
            Console.WriteLine("6. Apply For Loan");
            Console.WriteLine("7. Logout");
            int option = Convert.ToInt32(Console.ReadLine());
            return (UserMenu)option;
        }
        public static AdminMenu ShowAdminMenu()
        {
            Console.WriteLine("1. View All Accounts");
            Console.WriteLine("2. View Single Account");
            Console.WriteLine("3. Report Account");
            Console.WriteLine("4. UnReport Account");
            Console.WriteLine("5. Give Loan");
            Console.WriteLine("6. Logout");
            int option = Convert.ToInt32(Console.ReadLine());
            return (AdminMenu)option;
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static MUser TakeInputForSignUp()
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role");
            string role = Console.ReadLine();
            MUser user = new MUser(username, password, role);
            return user;
        }
        public static MUser TakeInputForLogin()
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            MUser user = new MUser(username, password);
            return user;
        }
        public static bool IsAdmin(MUser user)
        {
            if(user.GetUsername() == "admin" && user.GetUsername() == "admin")
            {
                return true;
            }
            return false;
        }
        public static bool StoreCurrentInfo(MUser user)
        {
            ObjectHandler.GetUserDL().StoreCurrentUser(user);
            // setting current customer Account
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();

            Account account = ObjectHandler.GetAccountDL().isAccountExists(currentUser.GetUsername());
            if(account != null)
            {
                ReportedAccount reportedAccount = ObjectHandler.GetReportedAccountDL().isReported(account.GetAccountHolder());
                if (reportedAccount != null)
                {
                    return false;
                }
                currentUser.SetCurrentAccount(account); // setting the current account
                                                        // setting the loan for the account
                Loan loan = ObjectHandler.GetLoanDL().isLoanExists(account.GetAccountHolder());
                if (loan != null)
                {
                    account.SetLoan(loan);
                }
                else
                {
                    account.SetLoan(null);
                }
                // setting transactions for the account
                account.SetTransactions(ObjectHandler.GetTransactionDL().GetTransactionsForSpecificAccount(account.GetAccountHolder()));
                return true;
            }
            currentUser.SetCurrentAccount(null);
            return true;
        }
    }
}
