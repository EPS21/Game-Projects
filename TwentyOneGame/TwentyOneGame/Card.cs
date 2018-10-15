using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwentyOneGame
{
    public class Card
    {
        // Properties
        public CardValue Kind { get; set; }
        public string Suit { get; set; }

        /* Don't need a constructor 
         * (we never create a single 'Card' in our program)
         */

        public enum CardValue
        {
            TWO = 2,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        }
                
    }
}