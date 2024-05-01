using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class ZigZagPatrol : IMovement
    {
        private int speed;
        private Point boundary;
        GameControl.Direction direction;
        private int offset = 10;
        public ZigZagPatrol(int speed, Point boundary, GameControl.Direction direction)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
        }
        public Point move(Point location)
        {

            // Check if a boundary exists and adjust movement logic accordingly
            if (boundary != null)
            {
                // Move in zig-zag pattern respecting boundaries
                if (direction == GameControl.Direction.Up)
                {
                    if (location.Y - offset >= 0) // Check if move up is within boundary
                    {
                        location.Y -= speed;
                    }
                    else
                    {
                        direction = GameControl.Direction.Left; // Change direction to left if hitting top boundary
                    }
                }
                else if (direction == GameControl.Direction.Left)
                {
                    if (location.X + offset <= boundary.X) // Check if move left is within boundary
                    {
                        location.X += speed;
                    }
                    else
                    {
                        direction = GameControl.Direction.Down; // Change direction to down if hitting left boundary
                    }
                }
                else if (direction == GameControl.Direction.Down)
                {
                    if (location.Y + offset <= boundary.Y) // Check if move down is within boundary
                    {
                        location.Y += speed;
                    }
                    else
                    {
                        direction = GameControl.Direction.Right; // Change direction to right if hitting bottom boundary
                    }
                }
                else if (direction == GameControl.Direction.Right)
                {
                    if (location.X - offset - 400 >= 0) // Check if move right is within boundary
                    {
                        location.X -= speed;
                    }
                    else
                    {
                        direction = GameControl.Direction.Up; // Change direction to up if hitting right boundary
                    }
                }
            }
            else
            {
                if (direction == GameControl.Direction.Up)
                {
                    location.Y -= speed;
                    direction = GameControl.Direction.Left;
                }
                else if (direction == GameControl.Direction.Left)
                {
                    location.X += speed;
                    direction = GameControl.Direction.Down;
                }
                else if (direction == GameControl.Direction.Down)
                {
                    location.Y += speed;
                    direction = GameControl.Direction.Right;
                }
                else if (direction == GameControl.Direction.Right)
                {
                    location.X -= speed;
                    direction = GameControl.Direction.Up;
                }
            }

            return location;
        }
    }
}
