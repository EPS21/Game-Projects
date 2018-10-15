using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TwentyOneGame
{
    public class Deck
    {
        private List<Card> _Deck;
        private StringBuilder Sb = new StringBuilder();

        /* Constructor loops through different suits and kinds in double for loop to 
         * create a deck of 52 cards
         */
        public Deck()
        {
            _Deck = new List<Card>();
            string[] suits = new string[] { "Clubs", "Hearts", "Diamonds", "Spades" };
            //string[] kinds = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10",
            //                                "Jack", "Queen", "King", "Ace" };
            Card.CardValue[] kinds = new Card.CardValue[] { Card.CardValue.TWO, Card.CardValue.THREE, Card.CardValue.ACE };            

            foreach (var kind in kinds)
            {
                foreach (var suit in suits)
                {
                    _Deck.Add(new Card() { Kind = kind, Suit = suit });
                }
            }
        }

        /// <summary>
        /// This method will shuffle all the cards and deal each one out 
        /// to each player until there are no cards left.
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public void DealCards(Player player1, Player player2)
        {
            shuffle();            
            while (_Deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
        }

        // helper method to deal one card to player and remove it from deck
        private void dealCard(Player player)
        {
            Card card = _Deck.ElementAt(_Deck.Count - 1);
            player.PlayerCards.Add(card);
            _Deck.Remove(card);
        }

        // helper Shuffle the cards in random order method
        private void shuffle()
        {
            List<Card> tempCards = new List<Card>();
            Random random = new Random();
            while (_Deck.Count > 0)
            {
                Card card = _Deck.ElementAt(random.Next(_Deck.Count));
                tempCards.Add(card);
                _Deck.Remove(card);
            }
            _Deck = tempCards;
        }

        // returns the deck of cards in a string format (overrides default ToString method)
        public override string ToString()
        {
            foreach (var card in _Deck)
            {
                Sb.Append($"Kind: {card.Kind}, Suit: {card.Suit} </br>");
            }
            return Sb.ToString();
        }

    }
}