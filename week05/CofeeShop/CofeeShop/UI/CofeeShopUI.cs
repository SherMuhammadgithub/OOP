using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class CofeeShopUI
    {
        public static string TakeNameAndOrder()
        {
            Console.WriteLine("Enter the name of the menu item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the oreder name: ");
            string order = Console.ReadLine();
            string concat = name + "," + order;
            return concat;
        }
        public static string TakeInput()
        {
            Console.WriteLine("Enter the name of the coffee shop: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
