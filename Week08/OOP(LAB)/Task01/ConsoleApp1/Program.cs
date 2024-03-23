using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike m1 = new MountainBike(12, 13, 19,10);
            m1.setSpeed(100);
            m1.GetAllInfo();

        }
    }
}
