using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalGames = 0;
            int totalScroe = 0;
            while(true)
            {
                Console.WriteLine("Welcome to the Card Game!");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    totalGames++;
                    Deck deck = new Deck();
                    deck.Shuffle();
                    int score = 0;
                    while (deck.CardsLeft() > 0)
                    {
                        Console.WriteLine("Cards left: " + deck.CardsLeft());
                        Card card = deck.DealCard();
                        Console.WriteLine("Card: " + card.GetSuitAsString() + " " + card.GetValueAsString());
                        Console.Write("Higher or Lower (H/L): ");
                        string higherOrLower = Console.ReadLine();
                        Card nextCard = deck.DealCard();
                        Console.WriteLine("Next Card: " + nextCard.GetSuitAsString() + " " + nextCard.GetValueAsString());
                        if (higherOrLower == "H" && nextCard.value > card.value)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else if (higherOrLower == "L" && nextCard.value < card.value)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                            break;
                        }
                    }
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Score: " + score);
                    totalScroe += score;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Total Games: " + totalGames);
                    Console.WriteLine("Total Score: " + totalScroe);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            }
        }
    }
}
