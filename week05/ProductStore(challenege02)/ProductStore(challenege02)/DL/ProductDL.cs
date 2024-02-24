using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class ProductDL
    {
        public List<Product> Products;
        public ProductDL()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void ViewProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Category: " + product.Category);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("StockQty: " + product.StockQty);
            }
        } 
        public Product FindProductByHighPrice()
        {
            Product highPriceProduct = Products[0];
            foreach (Product product in Products)
            {
                if (product.Price > highPriceProduct.Price)
                {
                    highPriceProduct = product;
                }
            }
            return highPriceProduct;
        }
        public double SaleTax()
        {
            double totalTax = 0;
            foreach (Product product in Products)
            {
                if(product.Category.Equals("Grocery", StringComparison.OrdinalIgnoreCase))
                {
                totalTax += product.Price * 0.10;
                }
                else if (product.Category.Equals("Friuts", StringComparison.OrdinalIgnoreCase))
                {
                    totalTax += product.Price * 0.05;
                }
                else
                {
                    totalTax += product.Price * 0.15;
                }
            }
            return totalTax;
        }
        public List<Product> ProductsToBeOredered()
        {
            List<Product> productsToBeOrdered = new List<Product>();
            foreach (Product product in Products)
            {
                if (product.StockQty < product.MinStockQty)
                {
                    productsToBeOrdered.Add(product);
                }
            }
            return productsToBeOrdered;
        }
        public  Product IsProductExists(string productName)
        {
             if (Products.Exists(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)))
            {
                 return Products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
             }
             return null;
        }
    }
}