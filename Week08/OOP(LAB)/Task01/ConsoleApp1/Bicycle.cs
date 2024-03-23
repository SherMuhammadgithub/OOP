using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bicycle
    {
        protected int cedenece;
        protected int gear;
        protected int speed;

        public  Bicycle(int cad, int s, int gear) {
            cedenece = cad;
            gear = s;
            speed = gear;

        }
        public void setCadence(int cadence)
        {
            this.cedenece = cadence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public void applyBrake(int decrement)
        {
            speed--;
        }
        public void speedUp(int increment) {
            speed++;
        }
        public void GetAllInfo()
        {
            Console.WriteLine($"Cedence {cedenece}");
            Console.WriteLine($"Speed {speed}");
            Console.WriteLine($"Gear {gear}");
            
        }
    }
}
