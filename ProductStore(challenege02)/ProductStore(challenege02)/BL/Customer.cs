using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class Customer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public static List<Product> products = new List<Product>();
        public Customer(string username, string password, string email, string address, string contactNumber)
        {
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
        }
        // for addding products in customer's cart
        // it will run when customer will buy products
        public static void AddProductsInCart(Product product)
        {
             Customer.products.Add(product);
        }
       
        public static double GenerateBill()
        {
            double total = 0;
            foreach (Product product in Customer.products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
