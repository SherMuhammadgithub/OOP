using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        
        public void BuyProduct(Product product, int qty)
        {
            if (product.StockQty >= qty)
            {
                product.StockQty -= qty;
                Console.WriteLine("Product bought successfully");
                Customer.AddProductsInCart(product);
            }
            else
            {
                Console.WriteLine("Product out of stock");
            }
        }

    }
}
