using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justin_Blackjack
{
    class Dealer : Player
    {
        //Dealer class is a sub class of the player class and functions the same other then a few methods work different.
        //because the code needs to do somethings a player would normally do on their own.
        private string name;
        private int count;
        private My_Cards[] hand = new My_Cards[5];
        private int handIterator = 0;
        private bool draw = true;
        private List<PictureBox> handImages = new List<PictureBox>();

        //Default construcotors 
        public Dealer() { }
        public Dealer(PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4, PictureBox box5) {
            this.handImages.Add(box1);
            this.handImages.Add(box2);
            this.handImages.Add(box3);
            this.handImages.Add(box4);
            this.handImages.Add(box5);
        }

        //Add a card to the deals hand and check if its too large and exit out. 
        public override void addToHand(My_Cards newCard)
        {
            if (this.handIterator > 4)
            {
                System.Windows.Forms.MessageBox.Show("Warning!" + Environment.NewLine +
                        "The dealer's hand is full, the game is over!",
                        "Full Hand!",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            this.hand[handIterator] = newCard;
            this.handIterator++;
        }
        //getters to trun different values we need.
        public override My_Cards getNewestCard()
        {
            return this.hand[handIterator - 1];
        }
        //method to set a cards image. 
        public override void setHandImage(My_Cards card)
        {
            this.handImages[handIterator - 1].Image = card.Image;
        }
        //public version of calculateHand()
        public override int getHandValue()
        {
            return calculateHand();
        }
        //loop through all of the hand and add up its value as you go, ignore aces for now. 
        private int calculateHand()
        {
            count = 0;
            for (int i = 0; i < hand.Count(); i++)
            {
                if (hand[i] != null)
                {
                    count = count + hand[i].getNumaricValue(new Dealer());
                }

            }

            //Now calculate hand value as normal, with an ace always counting as one. 
            int numAces = 0;
            for (int i = 0; i < hand.Count(); i++)
            {
                if (hand[i] != null)
                {
                    if (hand[i].Value == CardValue.Ace)
                    {
                        numAces = numAces + 1;
                    }
                }
            }
            //Calculate ace value. 
            //Now try and find the best hit for aces values that can give us a good range of values and get as close to 21 as we can.
            int tempCount = count;
            for (int i = 0; i < numAces; i++) {
                if (count >= 21) return count;
                else if (tempCount + 10 <= 21) {
                    tempCount = tempCount + 10;
                }

                if (tempCount != count && !(tempCount >21)) {
                    count = tempCount;
                }
            }
                return count;
        }
    }
}
