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
            string phone = Console.ReadLine();

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
            string  phone = Console.ReadLine();
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
        public static bool isAccountAlreadyExist() // current user account
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();

            Account account = ObjectHandler.GetAccountDL().isAccountExists(currentUser.GetUsername());
            if (account != null)
            {
                return true;
            }
            return false;
        }
        public static bool Deposit()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Console.WriteLine("Enter the amount to deposit: ");
            int amount = Convert.ToInt32(Console.ReadLine());
           bool isDeposited = currentAccount.Deposit(amount);
            bool isUpdated = ObjectHandler.GetAccountDL().UpdateAccountInfo(currentAccount, currentAccount.GetAccountHolder());
            bool isSaved = SaveTransaction("Deposit", amount, currentAccount.GetAccountHolder());
            return isDeposited && isSaved && isUpdated;
        }
        public static bool Withdraw()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Console.WriteLine("Enter the amount to withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            bool isWithdraw = currentAccount.Withdraw(amount);
            bool isUpdated = ObjectHandler.GetAccountDL().UpdateAccountInfo(currentAccount, currentAccount.GetAccountHolder());
            bool isSaved = SaveTransaction("Withdraw", amount, currentAccount.GetAccountHolder());
            return isWithdraw && isSaved && isUpdated;
        }
        public static bool Transfer()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Console.WriteLine("Enter the amount to transfer: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the account holder to transfer: ");
            string accountHolder = Console.ReadLine();
            Account accountToTransfer = ObjectHandler.GetAccountDL().isAccountExists(accountHolder);
            if (accountToTransfer != null)
            {
                bool isTransfered = currentAccount.Transfer(amount); // - amount from current account
                bool isSenderAccountUpdated = ObjectHandler.GetAccountDL().UpdateAccountInfo(currentAccount, currentAccount.GetAccountHolder());
                bool isTransferSaved = SaveTransaction("Transfer", amount, currentAccount.GetAccountHolder());
                // deposit amount to the account to transfer
                bool isDeposited = accountToTransfer.Deposit(amount);
                bool isReceiverAccountUpdated = ObjectHandler.GetAccountDL().UpdateAccountInfo(accountToTransfer, accountHolder);
                bool isDepositSaved = SaveTransaction("Deposit", amount, accountHolder);

                return (isTransfered && isSenderAccountUpdated && isTransferSaved)
                    && (isDeposited && isReceiverAccountUpdated && isDepositSaved);
            }
            return false;

        }
        public static bool SaveTransaction(string type, int amount, string accountHolder)
        {
            trans transaction = new trans(type, amount, accountHolder);
            bool isSaved = ObjectHandler.GetTransactionDL().SaveTransactionInfo(transaction);
            return isSaved;
        }
        public static bool ApplyLoan()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Console.WriteLine("Enter the loan amount: ");
            int loanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Monthly Payment: ");
            int monthlyPayment = Convert.ToInt32(Console.ReadLine());
            Loan loan = new Loan(currentAccount.GetAccountHolder(), loanAmount, monthlyPayment);
            bool isLoanCreated = currentAccount.CreateLoan(loan);
            bool isSaved = SaveLoan(loan);
            return isLoanCreated && isSaved;
            
        }
        public static bool SaveLoan(Loan loan)
        {
            if (loan == null)
            {
                return false;
            }
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            currentAccount.SetLoan(loan);
            bool isSaved = ObjectHandler.GetLoanDL().SaveLoan(loan);
            return isSaved;

        }
        public static void ViewAccountInfo()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Console.WriteLine("Account Holder: " + currentAccount.GetAccountHolder());
            Console.WriteLine("Account Number: " + currentAccount.GetAccountNumber());
            Console.WriteLine("Address: " + currentAccount.GetAddress());
            Console.WriteLine("Phone: " + currentAccount.GetPhone());
            Console.WriteLine("Monthly Income: " + currentAccount.GetMonthlyIncome());
            Console.WriteLine("Bank Balance: " + currentAccount.GetIntialDeposit());
            Console.WriteLine("Account Type: " + currentAccount.GetAccountType());
            Console.WriteLine("Debt: " + currentAccount.GetDebt());
            Console.WriteLine("Loan: " + currentAccount.GetLoan());
        }
        public static bool IsLoanAlreadyExist()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            Loan loan = ObjectHandler.GetLoanDL().isLoanExists(currentAccount.GetAccountHolder());
            if (loan != null)
            {
                return true;
            }
            return false;
        }
    }
}
