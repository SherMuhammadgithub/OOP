﻿using CofeeShop.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CofeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShopManager coffeeShopManager = new CoffeeShopManager();
            while(true)
            {
                Console.Clear();
            Console.WriteLine("Welcome to the Coffee Shop");
                int option = MenuItemUI.MainMenu();
                if(option == 1)
                {
                    Console.Clear();
                    coffeeShopManager.AddMenuItem(MenuItemUI.TakeInput());
                }
                else if(option == 2)
                {
                    Console.Clear();
                    string name = CofeeShopUI.TakeInput();
                    
                    coffeeShopManager.AddCoffeeShop(new CoffeeShop(name));
                }
                else if(option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Add Menu Items in a Coffee shop");
                    string[] splittedString = CofeeShopUI.TakeNameAndOrder().Split(',');
                    string name = splittedString[0];
                    string order = splittedString[1];
                    if (coffeeShopManager.AddMenuItemInCoffeeShop(name, order))
                    {
                        Console.WriteLine($"Menu Item added successfully");
                    }
                    else
                    {
                        Console.WriteLine("This item is currently unavailable");
                    }
                }
                else if(option == 4)
                {
                    Console.Clear();
                   string cheapestItem =  coffeeShopManager.CheapestItem(CofeeShopUI.TakeInput());
                    Console.WriteLine($"The cheapest item is {cheapestItem}");
                }
                else if(option == 5)
                {
                    Console.Clear();
                    List<MenuItem> drintItems =  coffeeShopManager.ViewDrinkItems(CofeeShopUI.TakeInput());
                    if(drintItems != null)
                    {
                    foreach (var item in drintItems)
                    {
                        Console.WriteLine(item.Name);
                    }
                    }
                    else
                    {
                        Console.WriteLine("No drink items found");
                    }
                }
                else if(option == 6)
                {
                    Console.Clear();
                    List<MenuItem> foodItems = coffeeShopManager.ViewFoodItems(CofeeShopUI.TakeInput());
                    if(foodItems != null)
                    {
                    foreach (var item in foodItems)
                    {
                        Console.WriteLine(item.Name);
                    }
                    }
                    else
                    {
                        Console.WriteLine("No food items found");
                    }
                }
                else if(option == 7)
                {
                    Console.Clear();
                    string[] splittedString = CofeeShopUI.TakeNameAndOrder().Split(',');
                    string name = splittedString[0];
                    string order = splittedString[1];
                    if (coffeeShopManager.AddOrder(name, order))
                    {
                        Console.WriteLine("Order added successfully");
                    }
                    else
                    {
                        Console.WriteLine("This item is currently unavailable");
                    }
                }
                else if(option == 8)
                {
                    Console.Clear();
                    string[] splittedString = CofeeShopUI.TakeNameAndOrder().Split(',');
                    string coffeShopName = splittedString[0];
                    string order = splittedString[1];
                    if(coffeeShopManager.FulFillOrder(coffeShopName, order))
                    {
                        Console.WriteLine($"The {order} is ready!");
                    }
                    else
                    {
                        Console.WriteLine("Order not found");
                    }
                }
                else if(option == 9)
                {
                    Console.Clear();
                    coffeeShopManager.ViewOrders(CofeeShopUI.TakeInput());
                }
                else if(option == 10)
                {
                    Console.Clear();
                    double totalIncome = coffeeShopManager.TotalIncome(CofeeShopUI.TakeInput());
                    Console.WriteLine($"Total sale at resturant is {totalIncome}");
                }
                else if(option == 11)
                {
                    Console.Clear();
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
