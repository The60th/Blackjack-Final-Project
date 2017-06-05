using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Justin_Blackjack
{
    //Backbone of the project the card class allows us to easily create objects of a card and give it all the values a real card would have.
    //we can easily control suit, value picture all with one object and its methods.
    public enum CardSuit
    { //Public enums to hold values that will be used in the below card class to keep track of card suit. 
        Clubs,
        Diamonds,
        Hearts,
        Spades
    };
    public enum CardValue
    { //Public enums to hold values that will be used in the below card class to keep track of card value. 
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }
    //Custom card class to create instances of a card to interact with it

    class My_Cards
    {
        //Class variables

        private CardSuit suit;
        private CardValue value;
        private Image image;
        //Class constructors. 
        public My_Cards() { }
        public My_Cards(CardSuit suit, CardValue value, Image image)
        {
            this.suit = suit;
            this.value = value;
            this.image = image;
        }
        //Instances of Image, CardSuit and CardValue to control how they can be interacted with from the outside.
        public Image Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
        public CardSuit Suit
        {
            get { return this.suit; }
            set { this.suit = value; }
        }
        public CardValue Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        //Function to calulate the numaric value of a card from its suit and value enums.

        //Added method to support dealer logic!
        public int getNumaricValue(Player player)
        {
            //Create an instance of my custom messageBox class.
            My_MsgBox_Prompt myBox = new My_MsgBox_Prompt();
            //Use a switch case on this classes instance of value, till it finds the correct one and returns a numaric value equal
            //to its current enum value.
            switch (this.value)
            {
                //Added method to support dealer logic.
                case CardValue.Ace:
                    //To start the dealer will be always return a 1, more logic checks should be done within the dealer class. 
                    if (player is Dealer) {
                        return 1;
                    }
                    int x = -1;
                    //A check to allow the user to set the value of the ace to what ever they want.
                    while (x != 1 && x != 11)
                    {
                        try
                        {
                            //Call myBox.show(); Which is a custom function it is NOT the same as myBox.Show()
                            x = myBox.show();
                        }
                        catch (Exception)
                        {
                            //Full System path needed to call messageBox because this class does not include it by default. 
                            System.Windows.Forms.MessageBox.Show("Please make sure to only input 1 or 11! ");
                        }

                    }
                    //Return the value of the card based on its suit and face value.
                    return x;
                case CardValue.King:
                    return 10;
                case CardValue.Queen:
                    return 10;
                case CardValue.Jack:
                    return 10;
                case CardValue.Ten:
                    return 10;
                case CardValue.Nine:
                    return 9;
                case CardValue.Eight:
                    return 8;
                case CardValue.Seven:
                    return 7;
                case CardValue.Six:
                    return 6;
                case CardValue.Five:
                    return 5;
                case CardValue.Four:
                    return 4;
                case CardValue.Three:
                    return 3;
                case CardValue.Two:
                    return 2;
                default:
                    return -1;
            }
        }
        //Static method to generate a list that contains a full set of cards. 
        //This method is static because it should return a list of cards and should only be called to return that deck not used normmaly.
        public static List<My_Cards> createDeck()
        {
            return new List<My_Cards>
            {

            new My_Cards(CardSuit.Clubs, CardValue.Ace, Properties.Resources.A_C), new My_Cards(CardSuit.Diamonds, CardValue.Ace, Properties.Resources.A_D),
            new My_Cards(CardSuit.Hearts, CardValue.Ace, Properties.Resources.A_H), new My_Cards(CardSuit.Spades, CardValue.Ace, Properties.Resources.A_S),

            new My_Cards(CardSuit.Clubs, CardValue.King, Properties.Resources.K_C), new My_Cards(CardSuit.Diamonds, CardValue.King, Properties.Resources.K_D),
            new My_Cards(CardSuit.Hearts, CardValue.King, Properties.Resources.K_H), new My_Cards(CardSuit.Spades, CardValue.King, Properties.Resources.K_S),

            new My_Cards(CardSuit.Clubs, CardValue.Queen, Properties.Resources.Q_C), new My_Cards(CardSuit.Diamonds, CardValue.Queen, Properties.Resources.Q_D),
            new My_Cards(CardSuit.Hearts, CardValue.Queen, Properties.Resources.Q_H), new My_Cards(CardSuit.Spades, CardValue.Queen, Properties.Resources.Q_S),

            new My_Cards(CardSuit.Clubs, CardValue.Jack, Properties.Resources.J_C), new My_Cards(CardSuit.Diamonds, CardValue.Jack, Properties.Resources.J_D),
            new My_Cards(CardSuit.Hearts, CardValue.Jack, Properties.Resources.J_H), new My_Cards(CardSuit.Spades, CardValue.Jack, Properties.Resources.J_S),

            new My_Cards(CardSuit.Clubs, CardValue.Ten, Properties.Resources._10C), new My_Cards(CardSuit.Diamonds, CardValue.Ten, Properties.Resources._10D),
            new My_Cards(CardSuit.Hearts, CardValue.Ten, Properties.Resources._10H), new My_Cards(CardSuit.Spades, CardValue.Ten, Properties.Resources._10S),

            new My_Cards(CardSuit.Clubs, CardValue.Nine, Properties.Resources._9C), new My_Cards(CardSuit.Diamonds, CardValue.Nine, Properties.Resources._9D),
            new My_Cards(CardSuit.Hearts, CardValue.Nine, Properties.Resources._9H), new My_Cards(CardSuit.Spades, CardValue.Nine, Properties.Resources._9S),

            new My_Cards(CardSuit.Clubs, CardValue.Eight, Properties.Resources._8C), new My_Cards(CardSuit.Diamonds, CardValue.Eight, Properties.Resources._8D),
            new My_Cards(CardSuit.Hearts, CardValue.Eight, Properties.Resources._8H), new My_Cards(CardSuit.Spades, CardValue.Eight, Properties.Resources._8S),

            new My_Cards(CardSuit.Clubs, CardValue.Seven, Properties.Resources._7C), new My_Cards(CardSuit.Diamonds, CardValue.Seven, Properties.Resources._7D),
            new My_Cards(CardSuit.Hearts, CardValue.Seven, Properties.Resources._7H), new My_Cards(CardSuit.Spades, CardValue.Seven, Properties.Resources._7S),

            new My_Cards(CardSuit.Clubs, CardValue.Six, Properties.Resources._6C), new My_Cards(CardSuit.Diamonds, CardValue.Six, Properties.Resources._6D),
            new My_Cards(CardSuit.Hearts, CardValue.Six, Properties.Resources._6H), new My_Cards(CardSuit.Spades, CardValue.Six, Properties.Resources._6S),

            new My_Cards(CardSuit.Clubs, CardValue.Five, Properties.Resources._5C), new My_Cards(CardSuit.Diamonds, CardValue.Five, Properties.Resources._5D),
            new My_Cards(CardSuit.Hearts, CardValue.Five, Properties.Resources._5H), new My_Cards(CardSuit.Spades, CardValue.Five, Properties.Resources._5S),

            new My_Cards(CardSuit.Clubs, CardValue.Four, Properties.Resources._4C), new My_Cards(CardSuit.Diamonds, CardValue.Four, Properties.Resources._4D),
            new My_Cards(CardSuit.Hearts, CardValue.Four, Properties.Resources._4H), new My_Cards(CardSuit.Spades, CardValue.Four, Properties.Resources._4S),

            new My_Cards(CardSuit.Clubs, CardValue.Three, Properties.Resources._3C), new My_Cards(CardSuit.Diamonds, CardValue.Three, Properties.Resources._3D),
            new My_Cards(CardSuit.Hearts, CardValue.Three, Properties.Resources._3H), new My_Cards(CardSuit.Spades, CardValue.Three, Properties.Resources._3S),

            new My_Cards(CardSuit.Clubs, CardValue.Two, Properties.Resources._2C), new My_Cards(CardSuit.Diamonds, CardValue.Two, Properties.Resources._2D),
            new My_Cards(CardSuit.Hearts, CardValue.Two, Properties.Resources._2H), new My_Cards(CardSuit.Spades, CardValue.Two, Properties.Resources._2S)

            };

        }

    }
}
