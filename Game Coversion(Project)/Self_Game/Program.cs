using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Self_Game
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Game game = new Game('P', 2, 10);
            string direction = "r";
            string player_direction = null; // initially direction is null


            // Add eneimies
            game.AddEnemy('E', 4, 2);
            game.AddEnemy('W', 5, 3);
            game.AddEnemy('O', 6, 6);
            game.AddEnemy('K', 7, 8);
            game.AddEnemy('J', 8, 7);
            game.AddEnemy('S', 9, 5);

            while (true)
            {
                game.DisplayState();
                direction = game.DirectionControl(direction);
                game.MoveEnemies(direction);
                // moving  playre functions
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    player_direction = "right";
                    game.MovePlayer(player_direction);
                }
                else if(Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player_direction = "left";
                    game.MovePlayer(player_direction);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    player_direction = "up";
                    game.MovePlayer(player_direction);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    player_direction = "down";
                    game.MovePlayer(player_direction);
                }
                Thread.Sleep(100);
            }
        }
    }
}
