using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyyManagemaent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxiCompany taxiCompany = new TaxiCompany("Taxi Company", "1234567890", "123 Main St");
            taxiCompany.AddTaxi(new Taxi("Toyota", "1234"));
            taxiCompany.AddTaxi(new Taxi("Honda", "5678"));
            taxiCompany.AddTaxi(new Taxi("Ford", "91011"));

            Passenger passenger = new Passenger("John", "1234567890", "123 Main St");
            Taxi taxiToTravel = passenger.CallTaxiCompany(taxiCompany);
            if(taxiToTravel != null)
            {
                Console.WriteLine($"{passenger.Name}, your drive is on the way! You are travelling via {taxiToTravel.Model}");
            }
            else
            {
                Console.WriteLine("Sorry, no taxis are available at the moment.");
            }
            Console.ReadLine();
        }
    }
}
