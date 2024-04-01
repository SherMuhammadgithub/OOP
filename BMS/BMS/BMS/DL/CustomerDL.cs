using BMS.BL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL
{
    internal class CustomerDL
    {
      public static  List<Customer> customers = new List<Customer>();
        public static Customer currentCustomer;
        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public static List<Customer> GetCustomers() // jsut for data grid view
        {
            return customers;
        }
// store current customer
          public static bool SetCurrentCustomer(MUser user)
        {
             currentCustomer = new Customer(user);
            return true;
          }
          public static Customer GetCurrentCustomer()
        {
                return currentCustomer;
          }
    }
}
