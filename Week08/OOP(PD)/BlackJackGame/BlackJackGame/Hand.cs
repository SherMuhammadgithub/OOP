using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Hand
    {
        public List<Card> cards;
        public Hand()
        {
            cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public void PrintHand()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.GetSuitAsString() + " " + card.GetValueAsString());
            }
        }
        public string Score()
        {
            int score = 0;
            int aces = 0;
            foreach (Card card in cards)
            {
                if (card.value == 1) // Ace
                {
                    aces++;
                    score += 11;
                }
                else if (card.value <= 10) // 2-10
                {
                    score += card.value;
                }
                else
                {
                    score += 10;
                }
            }
            return score.ToString() + "," + aces.ToString(); // Return the score and the number of aces in the hand
        }
    }
}
