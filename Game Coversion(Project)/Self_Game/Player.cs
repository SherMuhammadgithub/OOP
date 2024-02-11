using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Game
{
    internal class Player
    {
        public char DisplayChar { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public Player(char displayChar, int x, int y)
        {
            DisplayChar = displayChar;
            X = x;
            Y = y;
        }
    }
}
