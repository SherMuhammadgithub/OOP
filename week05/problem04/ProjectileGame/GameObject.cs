using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectileGame
{
    internal class GameObject
    {
        public char[,] Shape { get; set; }
        public Point StartingPoint { get; set; }
        public Boundary Premises { get; set; }
        public string Direction { get; set; }

        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }

        public GameObject(char[,] shape, Point startingPoint, Boundary premises, string direction = "LeftToRight")
        {
            Shape = shape;
            StartingPoint = startingPoint;
            Premises = premises;
            Direction = direction;
        }

        public void Move()
        {
            switch (Direction)
            {
                case "LeftToRight":
                    if (StartingPoint.X < Premises.BottomRight.X)
                    {
                        StartingPoint.X++;
                    }
                    break;
                case "RightToLeft":
                    if (StartingPoint.X > Premises.TopLeft.X)
                    {
                        StartingPoint.X--;
                    }
                    break;
                case "Patrol":
                    if (StartingPoint.X < Premises.BottomRight.X && StartingPoint.X > Premises.BottomLeft.X)
                    {
                        StartingPoint.X--;
                    }
                    else if (StartingPoint.X == Premises.BottomLeft.X)
                    {
                        Direction = "RightToLeft";
                        StartingPoint.X++;
                    }
                    else if (StartingPoint.X == Premises.BottomRight.X)
                    {
                        Direction = "LeftToRight";
                        StartingPoint.X--;
                    }
                    break;
                case "Projectile":
                    if (StartingPoint.X + 5 <= Premises.BottomRight.X && StartingPoint.Y - 5 >= Premises.TopRight.Y)
                    {
                        StartingPoint.X += 5;
                        StartingPoint.Y -= 5;
                    }
                    else if (StartingPoint.X + 7 <= Premises.BottomRight.X)
                    {
                        StartingPoint.X += 2;
                    }
                    else if (StartingPoint.X + 7 > Premises.BottomRight.X && StartingPoint.Y + 4 <= Premises.BottomRight.Y)
                    {
                        StartingPoint.Y += 4;
                    }
                    break;
                case "Diagonal":
                    if (StartingPoint.X + 5 <= Premises.BottomRight.X && StartingPoint.Y + 5 <= Premises.BottomRight.Y)
                    {
                        StartingPoint.X += 5;
                        StartingPoint.Y += 5;
                    }
                    break;
            }
        }

        public void Erase()
        {
            Console.SetCursorPosition(StartingPoint.X, StartingPoint.Y);
            Console.Write("   ");
        }

        public void Draw()
        {
            Console.SetCursorPosition(StartingPoint.X, StartingPoint.Y);
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(Shape[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
