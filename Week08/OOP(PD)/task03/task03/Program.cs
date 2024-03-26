using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadKey();
            Console.Clear();
            Deck deck = new Deck();
            deck.Shuffle();
            BlackjackHand playerHand = new BlackjackHand();
            BlackjackHand dealerHand = new BlackjackHand();
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            Console.WriteLine("Player's hand:");
            playerHand.PrintHand();
            Console.WriteLine("Dealer's hand:");
            dealerHand.PrintHand();
            if(playerHand.IsBlackjack() && dealerHand.IsBlackjack())
            {
                Console.WriteLine("Both player and dealer have blackjack! It's a tie!");
                return;
            }
            else if (playerHand.IsBlackjack())
            {
                Console.WriteLine("Player has blackjack! Player wins!");
                return;
            }
            else if (dealerHand.IsBlackjack())
            {
                Console.WriteLine("Dealer has blackjack! Dealer wins!");
                return;
            }
            while (playerHand.Score() < 21)
            {
                Console.WriteLine("Do you want to hit or stand? (h/s)");
                string input = Console.ReadLine();
                if (input == "h")
                {
                    playerHand.AddCard(deck.DealCard());
                    Console.WriteLine("Player's hand:");
                    playerHand.PrintHand();
                    if (playerHand.IsBusted())
                    {
                        Console.WriteLine("Player is busted! Dealer wins!");
                        return;
                    }
                }
                else if (input == "s")
                {
                    break;
                }
            }
            while (dealerHand.Score() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
                Console.WriteLine("Dealer's hand:");
                dealerHand.PrintHand();
                if (dealerHand.IsBusted())
                {
                    Console.WriteLine("Dealer is busted! Player wins!");
                    return;
                }
            }
            Console.WriteLine("Player's hand:");
            playerHand.PrintHand();
            Console.WriteLine("Dealer's hand:");
            dealerHand.PrintHand();
            if (playerHand.Score() > dealerHand.Score())
            {
                Console.WriteLine("Player wins!");
                Console.WriteLine("Player's score: " + playerHand.Score());
                Console.WriteLine("Dealer's score: " + dealerHand.Score());
            }
            else if (playerHand.Score() < dealerHand.Score())
            {
                Console.WriteLine("Dealer wins!");
                Console.WriteLine("Player's score: " + playerHand.Score());
                Console.WriteLine("Dealer's score: " + dealerHand.Score());
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Player's score: " + playerHand.Score());
                Console.WriteLine("Dealer's score: " + dealerHand.Score());
            }
        }
    }
}
