using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyyManagemaent
{
    internal class Taxi
    {
        public string Model { get; set; }
        public string NumPlate { get; set; }

        public List<Passenger> passengers;

        public Taxi(string model, string numPlate)
        {
            Model = model;
            NumPlate = numPlate;
            passengers = new List<Passenger>();
        }

        public bool PickPassenger(Passenger passenger)
        {
            if(passenger != null)
            {
            passengers.Add(passenger);
            return true;
            }
            return false;
        }
        public bool DropPassenger(Passenger passenger)
        {
            if(passenger != null)
            {
            passengers.Remove(passenger);
            return true;
            }
            return false;
        }
  
    }
}
