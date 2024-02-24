using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.BL
{
    internal class CoffeeShop
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems;
        public string[] Orders;

        public CoffeeShop(string name)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            Orders = new string[0];
        }
    }
}
