using ProductStore_challenege02_.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProductStore_challenege02_
{
    internal class CustomerDL
    {
        public List<Customer> customers;

        public CustomerDL()
        {
               customers = new List<Customer>();
        }
        public bool SignUp(Customer customer)
        {

            if (customer != null)
            {
                if (customers.Exists(c => c.Username == customer.Username))
                {
                    return false;
                }
                else
                {
                    customers.Add(customer);
                    return true;
                }
            }
            return false;
        }
        public Customer Login(string username, string password)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Username.Equals(username) && customer.Password.Equals(password))
                {
                    return customer;
                }
            }
            return null;
        }
        public void ViewProfile(Customer customer)
        {
            Console.WriteLine("Name: " + customer.Username);
            Console.WriteLine("Password: " + customer.Password);
            Console.WriteLine("Email: " + customer.Email);
        }
        // adding products in customer's cart
        public void BuyProduct(Product product, int qty, string customerName)
        {
          Customer customer = customers.Find(c => c.Username == customerName);
            if(customer != null)
            {
                if(qty <= product.StockQty)
                {
                customer.products.Add(product);
                    product.StockQty -= qty;
                }
                else
                {
                    Console.WriteLine("Product is out of stock");
                }

            }
        }
        public double GenerateBill(string customerName)
        {
            int totalBill = 0;
            Customer customer = customers.Find(c => c.Username == customerName);
            if(customer != null)
            {
               foreach(Product product in customer.products)
                {
                    totalBill += product.Price;
                }
            }
            return totalBill;
        }
    }
}
