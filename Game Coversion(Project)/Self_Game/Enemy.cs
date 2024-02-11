using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Game
{
    internal class Enemy
    {
        public char DisplayChar { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public Enemy(char displayChar, int x, int y)
        {
            DisplayChar = displayChar;
            X = x;
            Y = y;
        }

        public void Move(string enemy_direction)
        {
            if(enemy_direction == "r")
            {
                X++;
            }
            else if(enemy_direction == "l")
            {
               X--;
            }
            Console.SetCursorPosition(X, Y);
        }
    }
}
