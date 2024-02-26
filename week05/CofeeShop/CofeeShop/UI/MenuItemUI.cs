<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class MenuItemUI
    {
        public static MenuItem TakeInput()
        {
            Console.WriteLine("Enter the name of the item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the type of the item: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the price of the item: ");
            int price = Convert.ToInt32(Console.ReadLine());
            return new MenuItem(name, type, price);
        }
        public static int MainMenu()
        {
            Console.WriteLine("1.Add a Menu Item");
            Console.WriteLine("2.Add a Cofee Shop");
            Console.WriteLine("3.Enter Menu Item in a specific coffee shop;");
            Console.WriteLine("4.View the Cheapest Item in the menu from a specific coffee shop");
            Console.WriteLine("5.View the Drink's Menu from a specific coffee shop");
            Console.WriteLine("6.View the Food's Menu from a specific coffee shop");
            Console.WriteLine("7.Add Order in a specific coffee shop");
            Console.WriteLine("8.Fulfill the Order in a specific coffee shop");
            Console.WriteLine("9.View the orders list in the specific coffee shop");
            Console.WriteLine("10.Total Payable");
            Console.WriteLine("11.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class MenuItemUI
    {
        public static MenuItem TakeInput()
        {
            Console.WriteLine("Enter the name of the item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the type of the item: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the price of the item: ");
            int price = Convert.ToInt32(Console.ReadLine());
            return new MenuItem(name, type, price);
        }
        public static int MainMenu()
        {
            Console.WriteLine("1.Add a Menu Item");
            Console.WriteLine("2.Add a Cofee Shop");
            Console.WriteLine("3.Enter Menu Item in a specific coffee shop;");
            Console.WriteLine("4.View the Cheapest Item in the menu from a specific coffee shop");
            Console.WriteLine("5.View the Drink's Menu from a specific coffee shop");
            Console.WriteLine("6.View the Food's Menu from a specific coffee shop");
            Console.WriteLine("7.Add Order in a specific coffee shop");
            Console.WriteLine("8.Fulfill the Order in a specific coffee shop");
            Console.WriteLine("9.View the orders list in the specific coffee shop");
            Console.WriteLine("10.Total Payable");
            Console.WriteLine("11.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
