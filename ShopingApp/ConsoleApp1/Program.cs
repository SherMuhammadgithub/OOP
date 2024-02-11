using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Main(string[] args)
        {
          //  List <Product> products = new List <Product> ();
            Product product = new Product ();
            while(true)
            {
                Console.Clear();
                int op = printMenu();
                if(op == 1)
                {
                    Console.Clear();
                    product.takeInput();
                }
                else if (op == 2) {
                    Console.Clear();
                    product.showProducts();
                }
                else if (op == 3) {
                    Console.Clear();
                    int Total = product.totalSales();
                    Console.WriteLine($"Total Net worth is {Total}"); 
                }
                else if(op == 4) {product.topPrice();}
                else if (op == 5) { return 1; }
                Console.ReadKey ();
            }
        }
        static int printMenu()
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Show Product");
            Console.WriteLine("3.Total Stroe Worth");
            Console.WriteLine("3.See Top Price ");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
       
    }
}
