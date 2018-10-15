using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwentyOneGame
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            Player dealer = new Player() { Name = "Dealer" };
            Player opponent = new Player() { Name = "Crackjack McGree" };
            var GameDeck = new Deck();

            GameDeck.DealCards(dealer, opponent);

            resultLabel.Text = dealer.ToString() + opponent.ToString();            
            
        }
    }
}