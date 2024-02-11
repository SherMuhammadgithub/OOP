using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Vehicle> vehicles = new List <Vehicle> ();
            while(true)
            {
                Console.Clear();
                int op = Print_Menu();
                if(op == 1)
                {
                    vehicles.Add(Take_Info());
                }
                if(op == 2)
                {
                    Console.Write("Enter Model of Vehicle: ");
                    string model = Console.ReadLine();
                    
                }

            }
        }
        static int Print_Menu()
        {

            Console.WriteLine("1.Add Vehicle");
            Console.WriteLine("View Vehicle");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static Vehicle Take_Info()
        {
            Console.Write("1.Enter model");
            string model = Console.ReadLine();
            Console.Write("2.Enter make: ");
            string make = Console.ReadLine();
            Console.Write("3.Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("4.Enter mileAge: ");
            int mileage = int.Parse(Console.ReadLine());
            Vehicle vehicle = new Vehicle(make, model, year, mileage);
            return vehicle;

        }
    }
}
