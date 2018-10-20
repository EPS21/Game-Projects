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
        /**
         * TODO: Handle Ace card logic somewhere
         */

        //Deck thedeck = new Deck();

        // why tf does this work if its static?
        static Game Game;

        protected void Page_Load(object sender, EventArgs e)
        {
            //resultLabel.Text = thedeck.ToString();
            hideButtons();
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            showButtons();
            Game = new Game("Player", "Dealer");
            Game.GameOver = false;
            resultLabel.Text = Game.Play();
        }

        protected void hitButton_Click(object sender, EventArgs e)
        {            
            if (Game.GameOver == true)
            {
                hideButtons();
            }
            else
            {
                showButtons();
                resultLabel.Text += Game.Hit();
            }
            
        }

        protected void stayButton_Click(object sender, EventArgs e)
        {
            if (Game.GameOver == true)
            {
                //resultLabel.Text = "";
                hideButtons();
            }                
            else
            {
                showButtons();
                resultLabel.Text += Game.Stay();
            }                          
        }


        // because webforms is dumb
        private void showButtons()
        {
            hitButton.Visible = true;
            stayButton.Visible = true;
        }

        // because I'm dumb
        public void hideButtons()
        {
            hitButton.Visible = false;
            stayButton.Visible = false;
        }
    }
}