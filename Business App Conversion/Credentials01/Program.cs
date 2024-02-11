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
            Credentials credentials = new Credentials();
            credentials.readData();
            while (true)
            {
                Console.Clear();
                int op = printMenu();
                if(op == 2)
                {
                Console.Clear();
                    Console.Write("Enter name: ");
                    string new_name = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string new_pass = Console.ReadLine();
                    Console.Write("Enter Role: ");
                    string new_Role = Console.ReadLine();

                    bool is_unique = credentials.SignUp(new_name, new_pass, new_Role);
                    if(is_unique)
                    {
                        Console.Write("Account created");
                    }else
                    {
                        Console.Write("A user with this name already exists.");
                    }
                }
                else if(op == 1)
                {
                    Console.Clear();
                    string name, pass;
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    pass = Console.ReadLine();

                    bool is_matched = credentials.login(name, pass);
                    if(is_matched)
                    {
                        Console.WriteLine("Logged In!!!");
                        if (credentials.IsAdmin(name))
                        {
                            while (true)
                            {
                                int AdminOption = AdminMenu();
                                if (AdminOption == 1)
                                {
                                    credentials.ViewUsers();
                                }
                                else if (AdminOption == 2)
                                {
                                    Console.Write("Enter user to delete");
                                    string user_to_delete = Console.ReadLine();
                                    bool is_user_exists = credentials.UserExists(user_to_delete);
                                    if (is_user_exists)
                                    {
                                        bool is_deleted = credentials.DeleteUser(user_to_delete);
                                        if (is_deleted)
                                        {
                                            Console.WriteLine("User deleted successfully......");
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is an error deleting this user......");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("User not found");
                                    }

                                }
                                else if (AdminOption == 3)
                                {
                                    Console.Write("Enter user to update");
                                    string user_to_update = Console.ReadLine();
                                    bool is_user_exists = credentials.UserExists(user_to_update);
                                    if (is_user_exists)
                                    {
                                        bool is_updated = credentials.UpdateUser(user_to_update);
                                        if (is_updated)
                                        {
                                            Console.WriteLine("User updated successfully.....");
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is an error updating this user....");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("User not found");
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
                        Console.WriteLine("Invalid Credentials.....");
                    }

                }
                else if(op == 3)
                {
                    credentials.saveData();
                    return 0;
                }
                Console.ReadKey();

            }
          
        }
        static int printMenu()
        {
            Console.WriteLine("1.Login");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static int AdminMenu()
        {
            Console.WriteLine("1.View Users");
            Console.WriteLine("2.Delete User");
            Console.WriteLine("3.Update User");
            Console.WriteLine("Enter Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

    }
}
