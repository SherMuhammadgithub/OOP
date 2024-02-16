using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public List<Product> product = new List<Product>();
        public int produt_id;
        public string name;
        public int price;
        public string brand_name;
        public string country;


        public void takeInput()
        {
            string name, brand, country;
            int id, price;
            Console.Write("Product Name: ");
            name = Console.ReadLine();
            Console.Write("Product ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Product Pric: ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Product Brand: ");
            brand = Console.ReadLine();
            Console.Write("Product Country: ");
            country = Console.ReadLine();
            Product products = new Product();
            products.name = name;
            products.price = price;
            products.brand_name = brand;
            products.produt_id = id;
            products.country = country;
            product.Add(products);

        }


        public void showProducts()
        {
            Console.WriteLine("All Products offered");
            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{product[i].name}");
            }
        }
        public int totalSales()
        {
            int Total = 0;
            for (int i = 0; i < product.Count; i++)
            {
                Total += product[i].price;
            }
            return Total;

        }
        public void topPrice()
        {
            Console.WriteLine("Top Price Products!!");
            var topPrice = product.OrderByDescending(p => p.price).Take(3);
            foreach (var product in topPrice)
            {
                Console.WriteLine($"{product.name} : {product.price}");
            }
        }
    }
}
