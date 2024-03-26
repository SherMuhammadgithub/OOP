using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT2
{
    internal class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }
        public double GetRadius()
        {
            return radius;
        }
        public string GetColor()
        {
            return color;
        }
         public void SetRadius(double r)
        {
            radius = r;

        }
        public void SetColor(string c)
        {
            color = c;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public string toString()
        {
            return "Circle[radius=" + radius + ",color=" + color + "]";
        }

    }
}
