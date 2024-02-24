using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credentials01
{
    internal class UserInterface
    {
       public enum MainMenuOption
        {
            login = 1,
            register,
            exit
        }
        public enum AdminMenuOption
        {
            view = 1,
            delete,
            update,
            exit
        }
        public enum UserMneuOption
        {

        }

        public MainMenuOption PrintMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return (MainMenuOption)option;
        }

        public AdminMenuOption AdminMenu()
        {
            Console.WriteLine("1. View Users");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("Enter Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return (AdminMenuOption)option;
        }

        public string ReadString(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
