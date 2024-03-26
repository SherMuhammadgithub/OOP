using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class BlackjackHand : Hand
    {
        public new int  Score() // Returns the score of the hand
        {
            string scoreString = base.Score(); // Get the score and the number of aces in the hand
            int score = int.Parse(scoreString.Split(',')[0]); // Get the score
            int aces = int.Parse(scoreString.Split(',')[1]); // Get the number of aces
             
            while (score > 21 && aces > 0) // If the score is over 21 and there are aces in the hand, change the value of the aces from 11 to 1
            {
                score -= 10;
                aces--;
            }
            return score;
        }
        public bool IsBusted()
        {
            return Score() > 21;
        }
        public bool IsBlackjack()
        {
            return Score() == 21 && cards.Count == 2; // If the score is 21 and there are 2 cards in the hand, it is a blackjack
        }
        public bool Is21()
        {
            return Score() == 21;
        }
     
    }
}
