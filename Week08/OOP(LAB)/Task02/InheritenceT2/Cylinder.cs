using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT2
{
    internal class Cylinder: Circle
    {
        private double height;

        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double r):base(r)
        {
            height = 1.0;
        }
       public Cylinder(double r, double h):base(r)
        {
            height = h;
        }
        public Cylinder(double r, double h, string c):base(r, c)
        {
            height = h;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double h)
        {
            height = h;
        }
        public double GetVolume()
        {
            return GetArea() * height;
        }
        }

    }

