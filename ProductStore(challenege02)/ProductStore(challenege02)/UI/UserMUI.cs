using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_.DL
{
    internal class UserMUI
    {
        public static int Menu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static MUser TakeInput()
        {
            Console.WriteLine("Enter User Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            MUser mUser = new MUser(username, password);
            return mUser;
        }
        public static string IfUserIsAdmin()
        {
            Console.WriteLine("Enter Role:");
            string role = Console.ReadLine();
            return role;
        }
        public static string LoginPassword()
        {
            Console.WriteLine("Enter User Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            string concat = username + "," + password;
            return concat;
        }
    }
}
