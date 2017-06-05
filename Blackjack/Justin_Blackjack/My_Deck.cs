using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Justin_Blackjack
{
    class My_Deck
    {
        private List<My_Cards> deck = My_Cards.createDeck();
        StreamWriter write;
        private int shuffleCount = 7;
        private bool hasBeenShuffled = false;
        private Random random = new Random();
        private int deck_place = -1; 
        
        //Default Const?
        public My_Deck() { }
        //Custom Const?
        //Use this method to create a deck instance with more then one deck of cards in the "deck"
        public My_Deck(int deckCount) { }

        //A few different deal methods that were meant to allow different play styles but were later removed because of 
        //issues they caused with the flow of the game and usage of the cards.

        //This will deal a card and will NOT remove it from the deck and will NOT return the caller an card instance.
        public void Deal_Card(Player player) {
            checkShuffle();
        }
        //This will deal a card and WILLremove it from the deck and WILL return the caller an instance of the card.
        public My_Cards Deal_Card(Player player, String NA) {
            checkShuffle();
            return new My_Cards();
        }
        //This will deal a card and NOT remove it from the deck and will NOT return the caller an card instance.
        public void FalseDeal_Card(Player player)
        {
            checkShuffle();
        }
        //This will deal a card and NOT remove it from the deck and will NOT return the caller and card instance.
        public My_Cards FalseDeal_Card(Player player, String NA) {
            checkShuffle();
            if (deck_place >= deck.Count()-1) { deck_place = -1; }
            deck_place++;
            player.addToHand(deck[deck_place]);
            return deck[deck_place];
        }
        //Check if this deck has been shuffled already, if not issue this warning everytime a card is drawn (this is a lot, very spamy)
        public void checkShuffle() {
            if (!this.hasBeenShuffled)
            {
                System.Windows.Forms.MessageBox.Show("Warning!" + Environment.NewLine +
                    "This deck has not been shuffled yet and will cause a unfair game.",
                    "Unshuffled deck!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                //Check MsgBox result here and do actions depending on anwser. 
            }
        }
        //This method will write the full deck to a log file and warn the user if the deck has not been shuffled yet.
        //this method was used for the debugging of the deck and making sure the shuffleing methods were working correctly.  
        public void Show_Deck() {
            checkShuffle();
            if (!File.Exists("logs.txt"))
            {
                write = File.CreateText("logs.txt");
            }
            else
            {
                write = File.AppendText("logs.txt");
            }
            write.WriteLine("New Deck Deal");
            for(int i = 0; i < this.deck.Count; i++){
               write.WriteLine("Card is an " + deck[i].Value + " of " + deck[i].Suit);
                
            }
            write.WriteLine("End Deck Deal");
            write.Close();
        }

        //Public method to returned a shuffle and deck then return the deck.
        //shuffle the deck with the private method shuffle deck.
        public My_Deck shuffleDeck() {
            this.hasBeenShuffled = true;
            shuffleDeck(this.deck);
            return this;
        }
        
        //Private method to shuffle the deck, this method should only be called from within the class to protect the deck. 
        //the format of this shuffle is based off of the fisher yates shuffle that is a widly used format to give fair deck shuffles.
        private void shuffleDeck(List<My_Cards> deck) 
        {
            for (int i = 0; i < shuffleCount; i++) { }
                for (int n = deck.Count - 1; n > 0; --n)
                {
                    int k = random.Next(n + 1);
                    My_Cards temp = deck[n];
                    deck[n] = deck[k];
                    deck[k] = temp;
                }
        }
    }

}

