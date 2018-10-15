using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOneGame
{
    public class Player
    {
        // Properties of player
        public string Name { get; set; }
        public List<Card> PlayerCards { get; set; }

        // Constructor
        public Player()
        {
            Name = "unnamed"; // default name if none provided
            PlayerCards = new List<Card>();
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.Append($"-----------{Name}'s cards are: -----------</br>");
            foreach (var card in PlayerCards)
            {
                Sb.Append($"Kind: {card.Kind}, Suit: {card.Suit} </br>");
            }
            Sb.Append(calcCards());

            return Sb.ToString();
        }

        private int calcCards()
        {
            int total = 0;
            foreach (var card in PlayerCards)
            {
                total += (int)card.Kind;
            }
            return total;
        }
    }
}