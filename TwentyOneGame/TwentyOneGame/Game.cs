using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;



namespace TwentyOneGame
{
    public class Game
    {
        // Fields
        private Player Dealer;
        private Player Player;
        private int DealerScore;
        private int PlayerScore;
        private string GameOverString;
        private Deck Deck;
        public bool GameOver { get; set; }
        //private StringBuilder Sb = new StringBuilder();

        // Constructor
        public Game(string playerName, string dealerName)
        {
            Player = new Player() { Name = playerName };
            Dealer = new Player() { Name = dealerName };
        }

        // This will be the play method when deal is hit
        // It will create a new deck of cards
        // It will deal two cards to each player, and we want to display these cards for now
        public string Play()
        {
            Deck = new Deck();
            Deck.DealCards(Player, Dealer);
            return hitStayString();
        }

        // when you click 'Hit' button
        public string Hit()
        {
            Deck.DealCard(Player);

            if (Dealer.CountCards() < 17)
                Deck.DealCard(Dealer);

            checkWinner();

            if (GameOver == true)
                return GameOverString;

            return hitStayString();
        }

        // when you click 'Stay' button
        // dealer keeps drawing cards until condition
        public string Stay()
        {
            PlayerScore = Player.CountCards();
            DealerScore = Dealer.CountCards();

            while (Dealer.CountCards() < 17)
                Deck.DealCard(Dealer);
            checkWinner();

            if (PlayerScore <= 21 && PlayerScore > DealerScore)
            {
                GameOver = true;
                GameOverString = $"You win! Your beat {Dealer.Name}'s hand of {Dealer.CountCards()}";
                GameOverString += "</br>" + Player.ToString() + Dealer.ToString();
            }
            else if (DealerScore <= 21 && DealerScore > PlayerScore)
            {
                GameOver = true;
                GameOverString = $"You lose! {Dealer.Name} beat you with a hand of {Dealer.CountCards()}";
                GameOverString += "</br>" + Player.ToString() + Dealer.ToString();
            }
            else if (PlayerScore == DealerScore)
            {
                GameOver = true;
                GameOverString = "It's a tie game!";
                GameOverString += "</br>" + Player.ToString() + Dealer.ToString();
            }

            return GameOverString;
        }

        private void checkWinner()
        {
            PlayerScore = Player.CountCards();
            DealerScore = Dealer.CountCards();
            if (PlayerScore > 21)
            {
                GameOver = true;
                GameOverString = $"You lose! {Player.Name} busts with a hand of {Player.CountCards()}";
                GameOverString += "</br>" + Player.ToString() + Dealer.ToString();
            }
            else if (DealerScore > 21)
            {
                GameOver = true;
                GameOverString = $"You win! {Dealer.Name} busts with a hand of {Dealer.CountCards()}";
                GameOverString += "</br>" + Player.ToString() + Dealer.ToString();
            }
            
        }        

        private string hitStayString()
        {
            return $"Will you Hit or Stay?</br>" +
                   $"{Player.ToString()}" +
                   //$"{Dealer.ToString(Dealer)}" +
                   $"{Dealer.ToString()}" +
                   $"{Deck.ToString()}";
        }

    }
}