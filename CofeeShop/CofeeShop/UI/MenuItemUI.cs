using System;
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
    }
}
