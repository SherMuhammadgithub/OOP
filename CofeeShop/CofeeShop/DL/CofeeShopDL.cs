using CofeeShop.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class CofeeShopDL
    {
        public List<CoffeeShop> cofeeShops;
        public CofeeShopDL()
        {
            cofeeShops = new List<CoffeeShop>();
        }
        public  bool AddCoffeeShop(CoffeeShop coffeeShop)
        {
            if(coffeeShop != null)
            {
            cofeeShops.Add(coffeeShop);
            return true;
            }
            return false;
        }
        public string CheapestItem(string coffeshopName)
        {
            string cheapestItem = "";
            double cheapestPrice = double.MaxValue;
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeshopName);
            if(coffeeShop != null)
            {
                foreach (var menuItem in coffeeShop.MenuItems)
                {
                    if (menuItem.Price < cheapestPrice)
                    {
                        cheapestPrice = menuItem.Price;
                        cheapestItem = menuItem.Name;
                    }
                }
            return cheapestItem;
            }   
            return "No such coffee shop";
        }
        public List<MenuItem> ViewDrinkItems(string coffeeShopName)
        {
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            if(coffeeShop != null)
            {
                return coffeeShop.MenuItems.Where(x => x.Type == "Drink").ToList();
            }
            return null;
        }
        public List<MenuItem> ViewFoodItems(string coffeeShopName)
        {
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            if(coffeeShop != null)
            {
                return coffeeShop.MenuItems.Where(x => x.Type == "Food").ToList();
            }
            return null;
        }
        
        public bool FulFillOrder(string coffeeShopName, string order)
        {
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            if(coffeeShop != null)
            {
                if(coffeeShop.Orders.Contains(order))
                {
                    coffeeShop.Orders = coffeeShop.Orders.Where(x => x != order).ToArray(); // filter out the order
                    return true;
                }
            }
            return false;
        }
        public void ViewOrders(string coffeeShopName)
        {
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName); // returns the first element of the sequence that satisfies a condition or a default value if no such element is found.
            if(coffeeShop != null)
            {
                foreach (var order in coffeeShop.Orders)
                {
                    Console.WriteLine(order);
                }
            }
        }
        public double TotalSales(string coffeeShopName)
        {
            CoffeeShop coffeeShop = cofeeShops.FirstOrDefault(x => x.Name == coffeeShopName);
            if(coffeeShop != null)
            {
                double totalSales = 0;
                foreach (var menuItem in coffeeShop.MenuItems)
                {
                    totalSales += menuItem.Price;
                }
                return totalSales;
            }
            return 0;
        }

    }
}
