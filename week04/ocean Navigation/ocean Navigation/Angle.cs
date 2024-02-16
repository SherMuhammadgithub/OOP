using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean_Navigation
{
    internal class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;
        public Angle( int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
        public string ShipInfo(int degree, float minutes, char direction)
        {
            string ship_info = degree.ToString() + minutes.ToString() + direction;
            return ship_info;
        }
    }
}
