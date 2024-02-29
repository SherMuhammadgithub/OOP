using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectileGame
{
    internal class Boundary
    {
        public Point TopLeft { get; set; }
        public Point TopRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public Boundary()
        {
            TopLeft = new Point(0, 0);
            TopRight = new Point(0, 90);
            BottomLeft = new Point(90, 0);
            BottomRight = new Point(90, 90);
        }

        public Boundary(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            TopRight = topRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
        }

    }
}
