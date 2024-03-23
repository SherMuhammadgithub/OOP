using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card((Card.Suit)i, j));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int randomIndex = random.Next(cards.Count); // Random index between 0 and cards.Count - 1
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        public int CardsLeft()
        {
            return cards.Count;
        }
    }
}
