using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyyManagemaent
{
    internal class TaxiCompany
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Taxi> taxis;

        public TaxiCompany(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            taxis = new List<Taxi>();
        }

        public void AddTaxi(Taxi taxi)
        {
            taxis.Add(taxi);
        }
    
    }
}
