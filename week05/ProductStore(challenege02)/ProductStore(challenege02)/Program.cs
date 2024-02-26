<<<<<<< HEAD
﻿using ProductStore_challenege02_.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreManager storeManager = new StoreManager();
            Console.WriteLine("Welcome to Product Store");
            while(true)
            {
                Console.Clear();
                int choice = UserMUI.Menu();
                if(choice == 1)
                {
                    Console.Clear();
                    string role  = UserMUI.IfUserIsAdmin();
                    if(MUser.IsAdmin(role))
                    {
                       MUser loggedInAdmin =  storeManager.Login(UserMUI.TakeInput());
                        if(loggedInAdmin != null)
                        {
                            Console.WriteLine("Logged In Successfully");
                            while(true)
                            {
                                Console.Clear();
                                int option = ProductUI.AdminMenu();
                                if(option == 1)
                                {
                                    Console.Clear();
                                    storeManager.AddProduct(ProductUI.TakeInput());
                                }
                                else if(option == 2)
                                {
                                    Console.Clear();
                                    storeManager.ViewProducts();
                                }
                                else if(option == 3)
                                {
                                    Console.Clear();
                                   Product highPriceProduct = storeManager.FindProductByHighPrice();
                                    Console.WriteLine("Product with Highest Price: " + highPriceProduct.Name);
                                }
                                else if(option == 4)
                                {
                                    Console.Clear();
                                    double totalSaleTax = storeManager.SaleTax();
                                    Console.WriteLine($"Total Sale Tax is {totalSaleTax}");
                                }
                                else if(option == 5)
                                {
                                    Console.Clear();
                                    List<Product> productsToOrder = storeManager.ProductsToBeReordered();
                                    if(productsToOrder != null)
                                    {
                                        foreach (Product product in productsToOrder)
                                        {
                                            Console.WriteLine("Name: " + product.Name);
                                            Console.WriteLine("Category: " + product.Category);
                                            Console.WriteLine("Price: " + product.Price);
                                            Console.WriteLine("StockQty: " + product.StockQty);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Products to be ordered");
                                    }
                                   
                                }
                                else if(option == 6)
                                {
                                    Console.Clear();
                                    storeManager.ViewProfile(loggedInAdmin);
                                }
                                else if(option == 7)
                                {
                                    break;
                                }
                                    Console.ReadKey();

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials");
                        }
                    }
                    else
                    {
                        // login for customer here
                        Customer loggedInCustomer = storeManager.LoginForCustomer(CustomerUI.TakeInput());
                        if(loggedInCustomer != null)
                        {
                            Console.WriteLine("Logged In Successfully");
                            while(true)
                            {
                                Console.Clear();
                                int op = CustomerUI.CustomerMenu();
                                if (op == 1)
                                {
                                    Console.Clear();

                                    storeManager.ViewProducts();
                                }
                                else if (op == 2)
                                {
                                    Console.Clear();
                                    storeManager.ViewProfile(loggedInCustomer);
                                }
                                else if (op == 3)
                                {
                                    Console.Clear();
                                    string[] split = CustomerUI.BuyProduct().Split(',');
                                    string name = split[0];
                                    int qty = Convert.ToInt32(split[1]);
                                    Product product = storeManager.IsProductExists(name);
                                    if (product != null)
                                    {
                                        storeManager.BuyProduct(product, qty,loggedInCustomer.Username);
                                        Console.WriteLine($"{product.Name} bought successfully......");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Not Found");
                                    }

                                }
                                else if (op == 4)
                                {
                                    Console.Clear();
                                    double totalBill = storeManager.GenerateBill(loggedInCustomer.Username);
                                    Console.WriteLine("Total Bill: " + totalBill);
                                }
                                else if (op == 5)
                                {
                                    break;
                                }
                            Console.ReadKey();
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials");
                        }
                    }

                }
                else if(choice == 2)
                {
                    Console.Clear();
                    string role = UserMUI.IfUserIsAdmin();
                    if(MUser.IsAdmin(role))
                    {
                        // sign up as an admin here
                        if(storeManager.SignUp(UserMUI.TakeInput()))
                        {
                            Console.WriteLine("User Signed Up Successfully");
                        }
                        else
                        {
                            Console.WriteLine("User Already Exists");
                        }
                    }
                    else
                    {
                        // sign up for customer here
                        
                        if(storeManager.SignUpForCustomer(CustomerUI.TakeInput()))
                        {
                            Console.WriteLine("Customer Signed Up Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Customer Already Exists");
                        }
                    }
                }
                else if(choice == 3)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
=======
﻿using ProductStore_challenege02_.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreManager storeManager = new StoreManager();
            Console.WriteLine("Welcome to Product Store");
            while(true)
            {
                Console.Clear();
                int choice = UserMUI.Menu();
                if(choice == 1)
                {
                    Console.Clear();
                    string role  = UserMUI.IfUserIsAdmin();
                    if(MUser.IsAdmin(role))
                    {
                       MUser loggedInAdmin =  storeManager.Login(UserMUI.TakeInput());
                        if(loggedInAdmin != null)
                        {
                            Console.WriteLine("Logged In Successfully");
                            while(true)
                            {
                                Console.Clear();
                                int option = ProductUI.AdminMenu();
                                if(option == 1)
                                {
                                    Console.Clear();
                                    storeManager.AddProduct(ProductUI.TakeInput());
                                }
                                else if(option == 2)
                                {
                                    Console.Clear();
                                    storeManager.ViewProducts();
                                }
                                else if(option == 3)
                                {
                                    Console.Clear();
                                   Product highPriceProduct = storeManager.FindProductByHighPrice();
                                    Console.WriteLine("Product with Highest Price: " + highPriceProduct.Name);
                                }
                                else if(option == 4)
                                {
                                    Console.Clear();
                                    double totalSaleTax = storeManager.SaleTax();
                                    Console.WriteLine($"Total Sale Tax is {totalSaleTax}");
                                }
                                else if(option == 5)
                                {
                                    Console.Clear();
                                    List<Product> productsToOrder = storeManager.ProductsToBeReordered();
                                    if(productsToOrder != null)
                                    {
                                        foreach (Product product in productsToOrder)
                                        {
                                            Console.WriteLine("Name: " + product.Name);
                                            Console.WriteLine("Category: " + product.Category);
                                            Console.WriteLine("Price: " + product.Price);
                                            Console.WriteLine("StockQty: " + product.StockQty);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Products to be ordered");
                                    }
                                   
                                }
                                else if(option == 6)
                                {
                                    Console.Clear();
                                    storeManager.ViewProfile(loggedInAdmin);
                                }
                                else if(option == 7)
                                {
                                    break;
                                }
                                    Console.ReadKey();

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials");
                        }
                    }
                    else
                    {
                        // login for customer here
                        Customer loggedInCustomer = storeManager.LoginForCustomer(CustomerUI.TakeInput());
                        if(loggedInCustomer != null)
                        {
                            Console.WriteLine("Logged In Successfully");
                            while(true)
                            {
                                Console.Clear();
                                int op = CustomerUI.CustomerMenu();
                                if (op == 1)
                                {
                                    Console.Clear();

                                    storeManager.ViewProducts();
                                }
                                else if (op == 2)
                                {
                                    Console.Clear();
                                    storeManager.ViewProfile(loggedInCustomer);
                                }
                                else if (op == 3)
                                {
                                    Console.Clear();
                                    string[] split = CustomerUI.BuyProduct().Split(',');
                                    string name = split[0];
                                    int qty = Convert.ToInt32(split[1]);
                                    Product product = storeManager.IsProductExists(name);
                                    if (product != null)
                                    {
                                        storeManager.BuyProduct(product, qty,loggedInCustomer.Username);
                                        Console.WriteLine($"{product.Name} bought successfully......");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Not Found");
                                    }

                                }
                                else if (op == 4)
                                {
                                    Console.Clear();
                                    double totalBill = storeManager.GenerateBill(loggedInCustomer.Username);
                                    Console.WriteLine("Total Bill: " + totalBill);
                                }
                                else if (op == 5)
                                {
                                    break;
                                }
                            Console.ReadKey();
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials");
                        }
                    }

                }
                else if(choice == 2)
                {
                    Console.Clear();
                    string role = UserMUI.IfUserIsAdmin();
                    if(MUser.IsAdmin(role))
                    {
                        // sign up as an admin here
                        if(storeManager.SignUp(UserMUI.TakeInput()))
                        {
                            Console.WriteLine("User Signed Up Successfully");
                        }
                        else
                        {
                            Console.WriteLine("User Already Exists");
                        }
                    }
                    else
                    {
                        // sign up for customer here
                        
                        if(storeManager.SignUpForCustomer(CustomerUI.TakeInput()))
                        {
                            Console.WriteLine("Customer Signed Up Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Customer Already Exists");
                        }
                    }
                }
                else if(choice == 3)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
