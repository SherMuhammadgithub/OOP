using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class SquareMovement : IMovement
    {
        private int speed;
        private Point boundary;
        GameConfigurations.Direction direction;
        private int offset = 10;
        public SquareMovement(int speed, Point boundary, GameConfigurations.Direction direction)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
        }
        public Point move(Point location)
        {

            // Check if a boundary exists
            if (boundary != null)
            {
                // Move in zig-zag pattern respecting boundaries
                if (direction == GameConfigurations.Direction.Up)
                {
                    if (location.Y - offset - 100 >= 0) // Check if move up is within boundary
                    {
                        location.Y -= speed;
                    }
                    else
                    {
                        direction = GameConfigurations.Direction.Left; // Change direction to left if hitting top boundary
                    }
                }
                else if (direction == GameConfigurations.Direction.Left)
                {
                    if (location.X + offset + 100 <= boundary.X) // Check if move left is within boundary
                    {
                        location.X += speed;
                    }
                    else
                    {
                        direction = GameConfigurations.Direction.Down; // Change direction to down if hitting left boundary
                    }
                }
                else if (direction == GameConfigurations.Direction.Down)
                {
                    if (location.Y + offset <= boundary.Y) // Check if move down is within boundary
                    {
                        location.Y += speed;
                    }
                    else
                    {
                        direction = GameConfigurations.Direction.Right; // Change direction to right if hitting bottom boundary
                    }
                }
                else if (direction == GameConfigurations.Direction.Right)
                {
                    if (location.X - offset - 300 >= 0) // Check if move right is within boundary
                    {
                        location.X -= speed;
                    }
                    else
                    {
                        direction = GameConfigurations.Direction.Up; // Change direction to up if hitting right boundary
                    }
                }
            }
            else
            {
                if (direction == GameConfigurations.Direction.Up)
                {
                    location.Y -= speed;
                    direction = GameConfigurations.Direction.Left;
                }
                else if (direction == GameConfigurations.Direction.Left)
                {
                    location.X += speed;
                    direction = GameConfigurations.Direction.Down;
                }
                else if (direction == GameConfigurations.Direction.Down)
                {
                    location.Y += speed;
                    direction = GameConfigurations.Direction.Right;
                }
                else if (direction == GameConfigurations.Direction.Right)
                {
                    location.X -= speed;
                    direction = GameConfigurations.Direction.Up;
                }
            }

            return location;
        }
    }


}

