using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectileGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] shape = new char[1, 3] { { '0', '0', '0' } };
            Point startingPoint = new Point(10, 5);
            Boundary premises = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            Console.WriteLine("Enter the direction you want to go:");
            string direction = Console.ReadLine();
            
            GameObject gameObject = new GameObject(shape, startingPoint, premises, direction);

            while (true)
            {
                Console.Clear(); 

                gameObject.Draw();
                gameObject.Move();
                gameObject.Erase();
                System.Threading.Thread.Sleep(100); 
            }
        }
    }
}
