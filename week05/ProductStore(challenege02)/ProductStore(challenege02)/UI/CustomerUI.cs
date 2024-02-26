<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_.DL
{
    internal class CustomerUI
    {
        public static int CustomerMenu()
        {
            Console.WriteLine("1.View all Products");
            Console.WriteLine("2.View Profile");
            Console.WriteLine("3.Buy Products");
            Console.WriteLine("4.Generate Bill");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static Customer TakeInput()
        {
            Console.WriteLine("Enter User Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();
            Customer customer = new Customer(username, password, email, address, contactNumber);
            return customer;
        }
        public static string BuyProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Quantity:");
            string qty = Console.ReadLine();
            string concat = name + "," + qty;
            return concat;
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_.DL
{
    internal class CustomerUI
    {
        public static int CustomerMenu()
        {
            Console.WriteLine("1.View all Products");
            Console.WriteLine("2.View Profile");
            Console.WriteLine("3.Buy Products");
            Console.WriteLine("4.Generate Bill");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static Customer TakeInput()
        {
            Console.WriteLine("Enter User Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();
            Customer customer = new Customer(username, password, email, address, contactNumber);
            return customer;
        }
        public static string BuyProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Quantity:");
            string qty = Console.ReadLine();
            string concat = name + "," + qty;
            return concat;
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
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
