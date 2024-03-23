using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Card;

namespace CardGame
{
    internal class Card
    {
        public enum Suit { Clubs = 1, Diamonds = 2, Spades = 3, Hearts = 4 }
        public enum Value { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 }
        public Suit suit;
        public int value;
        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public string GetSuitAsString()
        {
            switch (suit)
            {
                case Suit.Clubs:
                    return "Clubs";
                case Suit.Diamonds:
                    return "Diamonds";
                case Suit.Spades:
                    return "Spades";
                case Suit.Hearts:
                    return "Hearts";
                default:
                    return "Invalid Suit";
            }
        }

        public string GetValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value <= 10)
            {
                return value.ToString();
            }
            else
            {
                switch (value)
                {
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return "Invalid Value";
                }
            }
        }
        public string GetCardAsString()
        {
            return GetValueAsString() + " of " + GetSuitAsString();
        }

    }
}
