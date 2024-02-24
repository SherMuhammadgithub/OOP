using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_.DL
{
    internal class ProductUI
    {
        public static int AdminMenu()
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View Products");
            Console.WriteLine("3.Find Product with Highest Unit Price");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered");
            Console.WriteLine("6.View Profile");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }
        public static Product TakeInput()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Category:");
            string category = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Stock Quantity:");
            int stockQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minimum Stock Quantity:");
            int minStockQty = Convert.ToInt32(Console.ReadLine());
            Product product = new Product(name, category, price, stockQty, minStockQty);
            return product;
        }
    }
}
