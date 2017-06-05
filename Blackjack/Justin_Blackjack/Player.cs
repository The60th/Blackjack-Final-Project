using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justin_Blackjack
{
    class Player
    {
     // private static const int endValue = 21;
        private string name;
        private int count;
        private My_Cards[] hand = new My_Cards[5];
        private int handIterator=0;
        private List<PictureBox> handImages = new  List<PictureBox>();
        private Dealer _Dealer; 


        //Default constructors.
        //to create a player object we need to pass it a dealer and each picture box that will function as its hand.
        public Player() { }
        public Player(PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4, PictureBox box5, Dealer dealer){
            this.handImages.Add(box1);
            this.handImages.Add(box2);
            this.handImages.Add(box3);
            this.handImages.Add(box4);
            this.handImages.Add(box5);
            this._Dealer = dealer;
        }
        //set the hand image to that of a cards image. 
        public virtual void setHandImage(My_Cards card) {
            this.handImages[handIterator - 1].Image = card.Image;
        }
        //add a card to your hand and make sure your hand is not over filled.
        public virtual void addToHand(My_Cards newCard) {
            if (this.handIterator > 4)
            {
                System.Windows.Forms.MessageBox.Show("Warning!" + Environment.NewLine +
                        "The player hand is already full, it is now the dealers turn!",
                        "Full Hand!",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
                //Need more stuffhere to control turn flow. 
            }
            this.hand[handIterator] = newCard;
            this.handIterator++;
          //  if (calculateHand() > endValue) {
               // whoWins(this, this._Dealer);
            //}
        }
        //get the value of the hand.
        public virtual int getHandValue() {
            return calculateHand();
        }
        //use calculateHand() to find the hand value by taking the raw value of it and promoting the user to enter a value for aces.
        //this is smaller then the dealers function because the player can pick the value of the ace rather then the code.
        private int calculateHand() {
            count = 0;
            for (int i = 0; i < hand.Count(); i++) {
                if (hand[i] != null) { 
                    count = count + hand[i].getNumaricValue(new Player()); 
                }

            }
            return count;
        }
        //get the latest card added to the players hand.
        public virtual My_Cards getNewestCard() {
            return this.hand[handIterator-1];
        }
        //get the object of a card at a certain spot in the players hand.
        public My_Cards getCardAt(int index) {
            if (index > 5 || index < 0) {
                System.Windows.Forms.MessageBox.Show("Warning!" + Environment.NewLine +
                         "Invalid call on getCardAt method in Player.cs index out of bounds.",
                         "Error!",
                         System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return null;
            }
            return this.hand[index];

        }
       
    }
}
