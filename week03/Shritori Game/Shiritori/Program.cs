using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while(true)
            {
                start:
                int op = print_M();
                if(op == 1)
                {
                    while(true) {
                       
                        Console.WriteLine("Enter word: ");
                        string word = Console.ReadLine();
                       string ans= game.play(word);
                        if(!game.game_over)
                        {
                       game.words.Add(ans);
                        Console.WriteLine("List of words:");
                            foreach(string w in game.words)
                            {
                                Console.Write($"{w},");
                            }
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine(ans);
                            goto start;
                        }

                    }
                    
                }
                else if(op == 2)
                {
                   string res = game.restart();
                    Console.WriteLine(res);
                    goto start;
                }
            }
        }
        static int print_M()
        {
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Restart");
            Console.WriteLine("Enter choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
