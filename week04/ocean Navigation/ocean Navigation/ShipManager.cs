using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ocean_Navigation
{
    internal class ShipManager
    {
        List<Ship> ships;
        public ShipManager()
        {
            ships = new List<Ship>();
        }
        public bool AddShip(Ship ship_info)
        {
            if(ship_info != null)
            {
            ships.Add(ship_info);
            return true;

            }
            return false;
        }
        public Ship FindShip(string ship_num)
        {
            Ship ship_to_find = ships.Find(ship => ship.number == ship_num);
if(ship_to_find != null)
            {
                return ship_to_find;
            }
            return null;
        }
        public Ship FindByLocation(string logitude, string latitude)
        {
            Ship ship_to_find = ships.Find(ship => ship.latitude == latitude && ship.longitude
             == logitude);
            if(ship_to_find != null)
            {
                return ship_to_find;
            }
            return null;
        }
    }
}
