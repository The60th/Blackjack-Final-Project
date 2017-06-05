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
    public partial class Login_Form : Form
    {
        //Windows form to handle the login system and start the gaming. 
        Form game_form = new Game_Form();
        public static String userName;
        public static int userID;

        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
        }

        private void btnNewUsr_Click(object sender, EventArgs e)
        {
            //If the user is new show them the rules of black jack. 
            MessageBox.Show("Welcome to black jack!" + System.Environment.NewLine + 
                "The goal of the game is for the player to get as close to 21 as they can without going over.");
            MessageBox.Show("If the player is closer to 21 than the dealer and not over 21 the player wins win. " +
               System.Environment.NewLine + "But if the dealer is closer to 21, or the player busts (Goes over 21) the dealer wins.");

            MessageBox.Show("The game starts with the dealer being dealt one face up card and one face down card, while the player is given two card's that they may view."
                + System.Environment.NewLine + "Each cards worth is that of the number on it with all face cards being worth 10."
                + System.Environment.NewLine + "An ace may be worth either 11 or 1 and this can be controlled by clicking on the card and giving the desired value in the popup.");

            MessageBox.Show("During the player's turn they may draw up to 3 more cards for a total of 5 but if at any time they go over a total of 21 points the game will skip to the dealers turn automatically."
            + System.Environment.NewLine + "To draw another card the player hits the 'hit' button, and if they wish to no longer draw and end their turn they press the 'stay' button.");


            game_form.Show();
            this.Hide();

        }

        private void btnOldUsr_Click(object sender, EventArgs e)
        {
            //If the user is returning just go right to the game and not give them the rules. 
            MessageBox.Show("Welcome to black jack!");
            game_form.Show();
            this.Hide();
        }


    }
}
