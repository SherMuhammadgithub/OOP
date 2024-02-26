<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            bool flag = false;
            foreach(var shop in CofeeShop.cofeeShops)
            {
                MenuItem menuItem = shop.MenuItems.FirstOrDefault(x => x.Name == order);
                if (menuItem != null)
                {
                    flag = true;
                }
            }
            if (coffeeShop != null && flag)
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
            MenuItem menuItem = MenuItemDL.MenuItems.FirstOrDefault(x => x.Name == menuItemName);
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
                    MenuItem menuItem = MenuItemDL.MenuItems.FirstOrDefault(x => x.Name == order);
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
        public void StoreCoffeeShops(string path, CoffeeShop coffeeShop, string name)
        {
            CofeeShop.StoreCoffeeShops(path, coffeeShop, name);
        }

        //for loading CoffeeShop data
        public  void LoadCoffeeShopData(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] splittedString = line.Split(',');
                string coffeeShopName = splittedString[0];
                double totalSales = Convert.ToDouble(splittedString[1]);
                string[] menuItems = splittedString[2].Split(';');
                  CofeeShop.cofeeShops.Add(new CoffeeShop(coffeeShopName));
                foreach(var item in menuItems)
                {
                    foreach(var menu in MenuItemDL.MenuItems)
                    {
                        if(item == menu.Name)
                        {
                            if (CofeeShop.cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName) != null)
                            {
                            MenuItem menuItem = new MenuItem(menu.Name, menu.Type, menu.Price);
                                CofeeShop.cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName).MenuItems.Add(menuItem);
                            }

                            break;
                        }
                    }    
                }
               
            }
                streamReader.Close();
        }

    }
}
=======
﻿
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
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
