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
            Sb.Append($"{Name}'s hand total equals to {CountCards()} </br></br>");

            return Sb.ToString();
        }

        /// <summary>
        /// Overloaded ToString method takes a Player object and only displays first card they have
        /// </summary>
        /// <param name="dealer"></param>
        /// <returns></returns>
        public string ToString(Player dealer)
        {            
            string cardVal = dealer.PlayerCards.FirstOrDefault().Kind.ToString();
            string cardSuit = dealer.PlayerCards.FirstOrDefault().Suit.ToString();           
            return $"{dealer.Name} has a {cardVal} of {cardSuit}</br>";
        }

        public int CountCards()
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