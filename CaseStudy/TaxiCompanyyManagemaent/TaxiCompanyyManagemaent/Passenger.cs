using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyyManagemaent
{
    internal class Passenger
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PickupAddress { get; set; }

        public Passenger(string name, string phoneNumber, string pickupAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PickupAddress = pickupAddress;
        }
        public Taxi CallTaxiCompany(TaxiCompany taxiCompany)
            
        {
            int Random = new Random().Next(0, taxiCompany.taxis.Count);
            Taxi taxi = taxiCompany.taxis[Random]; // assign random taxi if exists
            if (taxi != null)
            {
                 taxi.PickPassenger(this); 
                return taxi;
                
            }
            return null;
        }

    }
}
