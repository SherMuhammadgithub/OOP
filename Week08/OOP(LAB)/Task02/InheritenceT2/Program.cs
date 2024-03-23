using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Create a new object of the derived class
            Cylinder c1 = new Cylinder();
            Console.WriteLine("Cylinder:" + " radius=" + c1.GetRadius()  + " height=" + c1.GetHeight() + " base area=" + c1.GetArea()
            + " volume=" + c1.GetVolume());
            // Create a new object of the derived class
            Cylinder c2 = new Cylinder(5.0, 2.0);
            Console.WriteLine("Cylinder:"   + " radius=" + c2.GetRadius() + " height=" + c2.GetHeight()
           + " base area=" + c2.GetArea()   + " volume=" + c2.GetVolume());
            // Create a new object of the derived class
            Cylinder c3 = new Cylinder(5.0, 2.0, "blue");
            Console.WriteLine("Cylinder:"
                               + " radius=" + c3.GetRadius()
                                              + " height=" + c3.GetHeight()
                                                             + " base area=" + c3.GetArea()
                                                                            + " volume=" + c3.GetVolume());
        }
    }
}
