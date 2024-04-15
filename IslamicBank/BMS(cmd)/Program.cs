using BMS.BL;
using BMS.DL.FH;
using BMS.DLInterfaces;
using BMS_cmd_.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_cmd_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // loading data from db
            ObjectHandler.GetUserDL().LoadData();
            ObjectHandler.GetAccountDL().LoadAccounts();
            ObjectHandler.GetLoanDL().LoadLoanData();
            ObjectHandler.GetTransactionDL().LoadTransactionData();

            UserInterface.MainMenu mainMenuOption = 0; // Initialize to exit

            while (mainMenuOption != UserInterface.MainMenu.exit)
            {
                // Show main menu options
                mainMenuOption = UserInterface.ShowMainMenu();

                if (mainMenuOption == UserInterface.MainMenu.login)
                {
                    // Login functionality
                    MUser signedInUser = UserInterface.TakeInputForLogin();
                    if (ObjectHandler.GetUserDL().SignIn(signedInUser))
                    {
                        UserInterface.ShowMessage("Login Successful");
                        bool isAdmin = UserInterface.IsAdmin(signedInUser);

                        if (isAdmin)
                        {
                            // Admin menu loop
                            UserInterface.AdminMenu adminMenuOption = 0;
                            while (adminMenuOption != UserInterface.AdminMenu.logout)
                            {
                                adminMenuOption = UserInterface.ShowAdminMenu();
                                // Handle admin menu options here (e.g., Console.WriteLine)
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            // User menu loop
                            UserInterface.UserMenu userMenuOption = 0;
                            while (userMenuOption != UserInterface.UserMenu.logout)
                            {
                                bool isSet = UserInterface.StoreCurrentInfo(signedInUser);
                                if (!isSet)
                                {
                                    UserInterface.ShowMessage("This Account is Reported");
                                    break;
                                }
                                userMenuOption = UserInterface.ShowUserMenu();

                                if(userMenuOption == UserInterface.UserMenu.CreateAccount)
                                {
                                    bool isAccountAlreadyCreated = UserUI.isAccountAlreadyExist();
                                    if (isAccountAlreadyCreated)
                                    {
                                        UserInterface.ShowMessage("Account Already Created");
                                    }
                                    else
                                    {
                                         bool isCreated = UserUI.CreateAccount();
                                         if (isCreated)
                                         {
                                              UserInterface.ShowMessage("Account Created Successfully");
                                         }
                                         else
                                         {
                                              UserInterface.ShowMessage("Account Creation Failed");
                                         }
                                    }
                                    
                                }
                                else if(userMenuOption == UserInterface.UserMenu.UpdateAccount)
                                {
                                    bool isUpdated = UserUI.UpdateAccount();
                                    if (isUpdated)
                                    {
                                        UserInterface.ShowMessage("Account Updated Successfully");
                                    }
                                    else
                                    {
                                        UserInterface.ShowMessage("Account Updation Failed");
                                    }
                                }
                                else if(userMenuOption == UserInterface.UserMenu.deposit)
                                {
                                    bool isDeposited = UserUI.Deposit();
                                    if (isDeposited)
                                    {
                                        UserInterface.ShowMessage("Amount Deposited Successfully");
                                    }
                                    else
                                    {
                                        UserInterface.ShowMessage("Amount Deposit Failed");
                                    }
                                }
                                else if(userMenuOption == UserInterface.UserMenu.withdraw)
                                {
                                    bool isWithdrawn = UserUI.Withdraw();
                                    if (isWithdrawn)
                                    {
                                        UserInterface.ShowMessage("Amount Withdrawn Successfully");
                                    }
                                    else
                                    {
                                        UserInterface.ShowMessage("Amount Withdraw Failed");
                                    }
                                }
                                else if(userMenuOption == UserInterface.UserMenu.transfer)
                                {
                                    bool isTransfered = UserUI.Transfer();
                                    if (isTransfered)
                                    {
                                        UserInterface.ShowMessage("Amount Transfered Successfully");
                                    }
                                    else
                                    {
                                        UserInterface.ShowMessage("Amount Transfer Failed");
                                    }
                                }
                                else if(userMenuOption == UserInterface.UserMenu.ApplyForLoan)
                                {
                                    bool isLoanAlreadyApplied = UserUI.IsLoanAlreadyExist();
                                    if (isLoanAlreadyApplied)
                                    {
                                        UserInterface.ShowMessage("Loan Already Applied");
                                    }
                                    else
                                    {
                                        bool isLoanApplied = UserUI.ApplyLoan();
                                        if (isLoanApplied)
                                        {
                                            UserInterface.ShowMessage("Loan Applied Successfully");
                                        }
                                        else
                                        {
                                            UserInterface.ShowMessage("Loan Application Failed");
                                        }
                                    }
                                   

                                }
                                else if(userMenuOption == UserInterface.UserMenu.AccountInformation)
                                {
                                    UserUI.ViewAccountInfo();
                                }
                                else if(userMenuOption == UserInterface.UserMenu.logout)
                                {
                                    UserInterface.ShowMessage("Logged Out Successfully");
                                }
                                
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        UserInterface.ShowMessage("Login Failed");
                    }
                }
                else if (mainMenuOption == UserInterface.MainMenu.register)
                {
                    // Register functionality
                    MUser user = UserInterface.TakeInputForSignUp();
                    if (ObjectHandler.GetUserDL().SignUp(user))
                    {
                        UserInterface.ShowMessage("User Registered Successfully");
                        ObjectHandler.GetUserDL().SaveUserInfo(user);
                      
                    }
                    else
                    {
                        UserInterface.ShowMessage("User Registration Failed");
                    }
                }
            }

            Console.WriteLine("Exiting...");
        }

    }
}
