using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class VerticalPatrol : IMovement
    {
        private int speed;
        private Point boundary;
        GameControl.Direction direction;
        private int offset = 10;
        public VerticalPatrol(int speed, Point boundary, GameControl.Direction direction)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
        }
        public Point move(Point location)
        {
                // i want if there is any object in the way it should change the direction
            if ((location.Y + offset + 10) > boundary.Y)
            {
                direction = GameControl.Direction.Up;
            }
            if ((location.Y - offset) <= 0)
            {
                direction = GameControl.Direction.Down;
            }
            if (direction == GameControl.Direction.Up)
            {
                location.Y -= speed;
            }
            else
            {
                location.Y += speed;
            }
            return location;
        }
    }
}
