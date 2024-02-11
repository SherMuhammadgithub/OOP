using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        public Vehicle(string make, string model, int year, int mileage)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
        }
        public string make;
        public string model;
        public int year;
        public int mileage;
        public bool Car_Detail(string Model, List<Vehicle> vehicle)
        {
           foreach (var v in vehicle) {
                if(v.model == Model)
                {
                    Console.WriteLine($"{v.make}\t{v.model}\t{v.year}\t{v.mileage}");
                    return true;
                }
            }
            return false;
        }
    }
}
