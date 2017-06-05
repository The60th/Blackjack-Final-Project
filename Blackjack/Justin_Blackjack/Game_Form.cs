using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justin_Blackjack
{
    //CSC Black Jack Final Project by Justin.
    //I designed and coded the project with the mind set that classes should be used well to cut down on long lines of repeating code.
   


    //Main form for the game.
    
    //Enums to control the gameState and the turns to prevent out of turn play.
    public enum gameState {PlayerTurn, DealerTurn,GameOver }
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();

        }
        //Player, deck and dealer objects.
        My_Deck deck;
        Player player;
        Dealer dealer;
        public static bool preShuffle = false;
        gameState myGameState;

        //Start Game
        private void button1_Click(object sender, EventArgs e)
        {
            renderGame();
        }

        //Shuffle Deck
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shuffling deck, please wait.");
            if (deck != null) deck.shuffleDeck();
            else
            {
                deck = new My_Deck();
                deck.shuffleDeck();
            }
            preShuffle = true;
        }

        //Clear the game field before reseting. 
        public void clearGameDisplay() {
            if (dealer1.Image != null) dealer1.Image = null;
            if (dealer2.Image != null) dealer2.Image = null;
            if (dealer3.Image != null) dealer3.Image = null;
            if (dealer4.Image != null) dealer4.Image = null;
            if (dealer5.Image != null) dealer5.Image = null;

            if (player1.Image != null) player1.Image = null;
            if (player2.Image != null) player2.Image = null;
            if (player3.Image != null) player3.Image = null;
            if (player4.Image != null) player4.Image = null;
            if (player5.Image != null) player5.Image = null;

        }

        //Load display elements. 
        public void renderGame() {
            //When Creating the game null check the deck before creating it.
            //check if that deck has already been shuffled and if shuffle it. 
            if (preShuffle)
            {
                deck.shuffleDeck();
            }
            //Create player and dealer objects and set the button status to visable and hidden. 
            MessageBox.Show("Loading game, please wait!");
            if (deck == null) { deck = new My_Deck(); }
            player = new Player(player1, player2, player3, player4, player5, dealer);
            dealer = new Dealer(dealer1, dealer2, dealer3, dealer4, dealer5);
            myGameState = gameState.PlayerTurn;
            btnShuffle.Visible = false;
            btnDeal.Visible = false;
            btnRestart.Visible = true;
            btnHit.Visible = true;
            btnStay.Visible = true;
            lblPlayerHandValue.Visible = true;

            //Deal the dealer and player their first two cards. 
            dealer1.Image = deck.FalseDeal_Card(dealer,"N/A").Image;
            deck.FalseDeal_Card(dealer, "N/A");
            dealer2.Image = Properties.Resources.b2fv;

            player1.Image = deck.FalseDeal_Card(player, "N/A").Image;
            player2.Image = deck.FalseDeal_Card(player, "N/A").Image;
            lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
        }

        //Hit button. 
        private void btnHit_Click(object sender, EventArgs e)
        {
            //Make sure its the players turn
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            //Deal a card to the player. 
            //deck.FalseDeal calls the add to hand method on the player. 
            deck.FalseDeal_Card(player, "N/A");
            //Call the setHandImage with the newest card to set the image in the correct spot.
            player.setHandImage(player.getNewestCard());
            int handValue = player.getHandValue();
            lblPlayerHandValue.Text = ("Hand Value = " + handValue);

            //Check if the player handvalue is greater then 21 and if so change the game state to the dealers turn. 
            if (handValue > 21) {
                dealersTurn();
            } 
        }


        //Stay.
        //If the player stays make sure its their turn then if so end their turn. 
        private void btnStay_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn) {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            dealersTurn();
            //Dealers turn. 
        }

        //Form load create dealer and player objects,
        private void Game_Form_Load(object sender, EventArgs e)
        {

        }

        //Dealers turn function, needs refining. 
        //On the dealers turn, tell the user its his turn.
        //Display his second hidden card.
        //then play the deals turn out, always checking if its still a valid turn.
        public void dealersTurn() {
            myGameState = gameState.DealerTurn;
            MessageBox.Show("The dealer will now play.");
            dealer2.Image = dealer.getNewestCard().Image;
           
            while (myGameState == gameState.DealerTurn) {
                if (dealer.getHandValue() <= 16) {
                //    MessageBox.Show("Dealer under 17: " + dealer.getHandValue());
                deck.FalseDeal_Card(dealer,"N/A");
                    dealer.setHandImage(dealer.getNewestCard());
                }
                else if (dealer.getHandValue() >= 17) {
                    //stay
                 //   MessageBox.Show("Dealer over 17: " + dealer.getHandValue());
                    myGameState = gameState.GameOver;
                }
            }
            whoWins();
        }

       
        //Calculate the winner of the game.
        public void whoWins() {
            //get the dealer and the players hand values then run  through all the different ways someone could win. 
            // because there can only be one option you can use it all as one "if else if else" chain rather then many "ifs"
            int playerValue = player.getHandValue();
            int dealerValue = dealer.getHandValue();
            if (dealerValue == 21)
            {
                MessageBox.Show("Dealer has won");
            }
            else if (playerValue > 21)
            {
                MessageBox.Show("Dealer has won");

                //Dealer wins
            }
            else if (playerValue > 21 && dealerValue > 21)
            {
                MessageBox.Show("Dealer has won");

                //Dealer wins
            }
            else if (playerValue == dealerValue)
            {
                MessageBox.Show("Dealer has won");

                //dealer wins.
            }
            else if (dealerValue > playerValue && dealerValue < 21)
            {
                MessageBox.Show("Dealer has won");
            }
            else if (playerValue > dealerValue && playerValue <= 21 && playerValue != dealerValue)
            {
                MessageBox.Show("Player has won");

                //player wins
            }
            else if (playerValue == 21 && dealerValue != 21)
            {
                MessageBox.Show("Player has won");

                //player wins
            }
            else if (playerValue <= 21 && dealerValue > 21) {
                MessageBox.Show("Player has won.");
            }
            else
            {
                MessageBox.Show("Error! Dealer value: " + dealerValue + " Player value " + playerValue);
            }


        }

        //Restart/Redeal button. 
        //On the restart option make sure its the players turn and if it is tell them this hand will count as a lose if they exit out.
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Use a message box and message box response methods to check what option the user selected. 
            if (myGameState == gameState.PlayerTurn) {
                //you can also use OcCancel enumeration instead of YesNo, then you should check DialogResult.OK
                DialogResult dr = MessageBox.Show("Its still your turn are you sure you want to redeal the cards?" + System.Environment.NewLine +
                    "This hand will count as a lose if you contuine", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (myGameState == gameState.PlayerTurn || myGameState == gameState.DealerTurn)
                    {
                        //Lose a turn because of early exit. 
                    }
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }

            }
            clearGameDisplay();
            renderGame();
        }

        //Listeners for the player clicking on a card this will detect if the card is an ace and allow the player to recalculate their hand total. 
        //Use this method for each card to let the playe change there values for aces on the fly. 
        private void player1_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            if (player.getCardAt(0).Image == player1.Image) {
                lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
            }
        }

        private void player2_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            if (player.getCardAt(1).Value == CardValue.Ace)
            {
                lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
            }
        }

        private void player3_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            if (player.getCardAt(2).Value == CardValue.Ace)
            {
                lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
            }
        }

        private void player4_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            if (player.getCardAt(3).Value == CardValue.Ace)
            {
                lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
            }
        }

        private void player5_Click(object sender, EventArgs e)
        {
            if (myGameState != gameState.PlayerTurn)
            {
                MessageBox.Show("Sorry its not currently your turn or the game is over!" + System.Environment.NewLine
                    + "Please deal a new hand.", "Wrong turn!", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return;
            }
            if (player.getCardAt(4).Value == CardValue.Ace)
            {
                lblPlayerHandValue.Text = ("Hand Value = " + player.getHandValue());
            }
        }


        //Exit button.
        //Exit the game button will close the game all the way to the login form.
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to exit the game?" + System.Environment.NewLine +
                "This hand will count as a lose if you have a active hand.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (myGameState == gameState.PlayerTurn || myGameState == gameState.DealerTurn) {
                    //Lose a turn because of early exit. 
                }
                preShuffle = false;
                Login_Form myLogin = new Login_Form();
                this.Hide();
                myLogin.Show();
            }
            else if (dr == DialogResult.No)
            {
                return;
            }
        }
    }
}
