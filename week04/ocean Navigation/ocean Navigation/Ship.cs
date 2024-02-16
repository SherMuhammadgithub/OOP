using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean_Navigation
{
    internal class Ship
    {
        public string longitude  { get; set; }
        public string latitude { get; set; }
        public string number { get; set; }

        public Ship(string longitude, string latitude, string number)
        {
             this.longitude = longitude;            
            this.latitude = latitude;
            this.number = number;
           
        }

    }
}
