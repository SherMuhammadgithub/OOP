using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace Credentials01
{
    internal class Program
    {
       

        static int Main(string[] args)
        {
            string path = "C:\\Users\\dell\\Pictures\\MyBank_data\\my.txt";
            UserManager UserManager = new UserManager();
            UserInterface UserInterface = new UserInterface();
            UserManager.readData(path);
            while (true)
            {
                Console.Clear();
                UserInterface.MainMenuOption select = UserInterface.PrintMenu();
                if (select == UserInterface.MainMenuOption.register)
                {
                    Console.Clear();
                    string new_name = UserInterface.ReadString("Enter name");
                    string new_pass = UserInterface.ReadString("Enter password");
                    string new_Role = UserInterface.ReadString("Enter Role");

                    bool is_unique = UserManager.SignUp(new_name, new_pass, new_Role);
                    if (is_unique)
                    {
                        UserInterface.DisplayMessage("Account created");
                    } else
                    {
                        UserInterface.DisplayMessage("A user with this name already exists.......");
                    }
                }
                else if (select == UserInterface.MainMenuOption.login)
                {
                    Console.Clear();
                    string name = UserInterface.ReadString("Enter name");
                    string pass = UserInterface.ReadString("Enter password");
                    bool is_matched = UserManager.login(name, pass);
                    if (is_matched)
                    {
                        UserInterface.DisplayMessage("Logged In");
                        if (UserManager.IsAdmin(name))
                        {
                            while (true)
                            {

                                UserInterface.AdminMenuOption chose = UserInterface.AdminMenu();
                                if (chose == UserInterface.AdminMenuOption.view)
                                {
                                    Console.Clear();
                                    UserManager.ViewUser();
                                }
                                else if(chose == UserInterface.AdminMenuOption.delete)
                                {
                                    Console.Clear();
                                    string user_to_delete = UserInterface.ReadString("Enter user name");
                                    bool isDeleted = UserManager.DeleteUser(user_to_delete);
                                    if (isDeleted)
                                    {
                                        UserInterface.DisplayMessage("User deleted......");
                                    }else
                                    {
                                        UserInterface.DisplayMessage("User Not found.....");
                                    }
                                }
                                else { break; }
                                Console.ReadKey();
                        }
                        }
                        else
                        {

                            // this will take user to user_dashboard

                        }
                    }
                    else
                    {
                        UserInterface.DisplayMessage("Invalid Credentials.....");
                    }
                }
                else if (select == UserInterface.MainMenuOption.exit)
                {
                    UserManager.saveData(path);
                    return 0;
                }
                Console.ReadKey();

            }
          
        }

    }
}
