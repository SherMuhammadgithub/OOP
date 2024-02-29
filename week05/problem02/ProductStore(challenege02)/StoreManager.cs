<<<<<<< HEAD
﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class StoreManager
    {
      public MUserDL User;
      public ProductDL Product;
      public CustomerDL Customer;
      
        public StoreManager()
        {
            User = new MUserDL();
            Product = new ProductDL();
            Customer = new CustomerDL();
        }
        public void AddProduct(Product product)
        {
            Product.AddProduct(product);
        }
        public void ViewProducts()
        {
            Product.ViewProducts();
        }
        public Product FindProductByHighPrice()
        {
            return Product.FindProductByHighPrice();
        }
        public double SaleTax()
        {
           return Product.SaleTax();
        }
        public List<Product> ProductsToBeReordered()
        {
          return Product.ProductsToBeOredered();
        }
        public void ViewProfile(MUser user)
        {
            User.ViewProfile(user);
        }

        // 
        public bool SignUp(MUser user)
        {
           return User.SignUp(user);
        }
        public MUser Login(MUser user)
        {
            return User.Login(user.Name, user.Password);
        }
        public bool SignUpForCustomer(Customer customer)
        {
            return Customer.SignUp(customer);
        }
        public Customer LoginForCustomer(Customer customer)
        {
            return Customer.Login(customer.Username, customer.Password);
        }
        public void BuyProduct(Product product, int qty,string customerName)
        {
            Customer.BuyProduct(product, qty, customerName);
        }
        public double GenerateBill(string customerName)
        {
            return Customer.GenerateBill(customerName);
        }
        public void ViewProfile(Customer customer)
        {
            Customer.ViewProfile(customer);
        }
        public Product IsProductExists(string productName)
        {
            return Product.IsProductExists(productName);
        }
    }
}
=======
﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class StoreManager
    {
      public MUserDL User;
      public ProductDL Product;
      public CustomerDL Customer;
      
        public StoreManager()
        {
            User = new MUserDL();
            Product = new ProductDL();
            Customer = new CustomerDL();
        }
        public void AddProduct(Product product)
        {
            Product.AddProduct(product);
        }
        public void ViewProducts()
        {
            Product.ViewProducts();
        }
        public Product FindProductByHighPrice()
        {
            return Product.FindProductByHighPrice();
        }
        public double SaleTax()
        {
           return Product.SaleTax();
        }
        public List<Product> ProductsToBeReordered()
        {
          return Product.ProductsToBeOredered();
        }
        public void ViewProfile(MUser user)
        {
            User.ViewProfile(user);
        }

        // 
        public bool SignUp(MUser user)
        {
           return User.SignUp(user);
        }
        public MUser Login(MUser user)
        {
            return User.Login(user.Name, user.Password);
        }
        public bool SignUpForCustomer(Customer customer)
        {
            return Customer.SignUp(customer);
        }
        public Customer LoginForCustomer(Customer customer)
        {
            return Customer.Login(customer.Username, customer.Password);
        }
        public void BuyProduct(Product product, int qty,string customerName)
        {
            Customer.BuyProduct(product, qty, customerName);
        }
        public double GenerateBill(string customerName)
        {
            return Customer.GenerateBill(customerName);
        }
        public void ViewProfile(Customer customer)
        {
            Customer.ViewProfile(customer);
        }
        public Product IsProductExists(string productName)
        {
            return Product.IsProductExists(productName);
        }
    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
