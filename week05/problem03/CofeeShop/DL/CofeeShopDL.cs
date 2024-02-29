<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            return null;
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
            if (coffeeShop != null)
            {
                return coffeeShop.TotalSales;
            }
            return 0;
        }
        public  void StoreCoffeeShops(string path, CoffeeShop coffeeShop, string coffeShopName)
        {
            StreamWriter streamWriter = new StreamWriter(path, true);
            string degree = "";
            for(int i = 0; i < coffeeShop.MenuItems.Count - 1; i++)
            {
                degree += coffeeShop.MenuItems[i].Name + ";";
            }
            degree += coffeeShop.MenuItems[coffeeShop.MenuItems.Count - 1].Name;
            streamWriter.WriteLine(coffeeShop.Name +  "," + degree);

            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
=======
﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (coffeeShop != null)
            {
                return coffeeShop.TotalSales;
            }
            return 0;
        }


    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
