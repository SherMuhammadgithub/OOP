using CofeeShop.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class MenuItemDL
    {
        public List<MenuItem> MenuItems;

        public MenuItemDL()
        {
            MenuItems = new List<MenuItem>();
        }

        public bool AddMenuItem(MenuItem menuItem)
        {
            if(menuItem != null)
            {
            MenuItems.Add(menuItem);
            return true;
            }
            return false;
        }

      
    }
}
