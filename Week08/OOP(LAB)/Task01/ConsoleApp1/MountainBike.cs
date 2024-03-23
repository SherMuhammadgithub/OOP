using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MountainBike : Bicycle
    {
        private int seatHeight;

        public MountainBike(int seatHeight,int cad, int s, int gear) : base(cad, s, gear)
        {
            cedenece = cad;
            speed = s;
            this.gear = gear;
            this.seatHeight = seatHeight;
        }
        public void setHeight(int h)
        {
           this.seatHeight = h;
        }
    }
}
