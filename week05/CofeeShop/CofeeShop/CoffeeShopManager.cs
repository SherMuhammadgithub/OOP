
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.DL
{
    internal class CoffeeShopManager
    {
        public CofeeShopDL CofeeShop;
        public MenuItemDL Menu;
        public CoffeeShopManager()
        {
            CofeeShop = new CofeeShopDL();
            Menu = new MenuItemDL();
        }
        public bool AddOrder(string coffeeShopName, string order)
        {
            CoffeeShop coffeeShop = CofeeShop.cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            MenuItem menuItem = Menu.MenuItems.FirstOrDefault(x => x.Name == order);
            if (coffeeShop != null && menuItem != null)
            {
                Array.Resize(ref coffeeShop.Orders, coffeeShop.Orders.Length + 1);
                coffeeShop.Orders[coffeeShop.Orders.Length - 1] = order;
                return true;
            }
            return false;
        }
        public bool AddMenuItemInCoffeeShop(string coffeeShopName, string menuItemName)
        {
            CoffeeShop coffeeShop = CofeeShop.cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            MenuItem menuItem = Menu.MenuItems.FirstOrDefault(x => x.Name == menuItemName);
            if (coffeeShop != null && menuItem != null)
            {
                coffeeShop.MenuItems.Add(menuItem);
                return true;
            }
            return false;
        }
        public bool AddCoffeeShop(CoffeeShop coffeeShop)
        {
            return CofeeShop.AddCoffeeShop(coffeeShop);
        }
        public bool AddMenuItem(MenuItem menuItem)
        {
            return Menu.AddMenuItem(menuItem);
        }
        public string CheapestItem(string coffeshopName)
        {
            return CofeeShop.CheapestItem(coffeshopName);
        }
        public List<MenuItem> ViewDrinkItems(string coffeeShopName)
        {
            return CofeeShop.ViewDrinkItems(coffeeShopName);
        }
        public List<MenuItem> ViewFoodItems(string coffeeShopName)
        {
            return CofeeShop.ViewFoodItems(coffeeShopName);
        }
        public void ViewOrders(string coffeeShopName)
        {
            CofeeShop.ViewOrders(coffeeShopName);
        }
        public double TotalIncome(string coffeeShopName)
        {
            return CofeeShop.TotalSales(coffeeShopName);
        }
        public bool FulFillOrder(string coffeeShopName, string order)
        {
            CoffeeShop coffeeShop = CofeeShop.cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            if (coffeeShop != null)
            {
                if (coffeeShop.Orders.Contains(order))
                {
                    MenuItem menuItem = Menu.MenuItems.FirstOrDefault(x => x.Name == order);
                    if (menuItem != null)
                    {
                        coffeeShop.TotalSales += menuItem.Price;
                    }

                    coffeeShop.Orders = coffeeShop.Orders.Where(x => x != order).ToArray(); // filter out the order
                    return true;
                }
            }
            return false;
        }

    }
}
