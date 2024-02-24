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
        public List<Product> products;
        public Customer(string username, string password, string email, string address, string contactNumber)
        {
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            products = new List<Product>();
        }
       
     
    }
}
