using System;
using System.Collections.Generic;

namespace deckofcards
{
    //************************************************* Program ************************************************************************/
    class Program
    {
        static void Main(string[] args)
        {
            Player Chelsea = new Player("Chelsea");

            Deck myDeck = new Deck();

            Chelsea.DrawCard(myDeck.Draw());

            myDeck.Reset();

            myDeck.Shuffle();
        }
    }
    //*************************************************** Card Class ************************************************************************/
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        private static string[] suits = {"Spades", "Clubs", "Hearts", "Diamonds"};
        private static int[] vals = {1,2,3,4,5,6,7,8,9,10,11,12,13};
        private static string[] stringval = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

        public Card(int value, int suit, int val)
        {
            this.stringVal = stringval[value];
            this.suit = suits[suit];
            this.val = vals[val];
        }        
    }
    //*************************************************** Deck Class ************************************************************************/

    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                int theSuit = i;
                for (int k = 0; k<13; k++)
                {
                    int stringval = k;
                    int val = k;
                    cards.Add(new Card(stringval, theSuit, val));
                }
            }
        }
        public Card Draw()
        {
            Card ToRemove = cards[0];
            cards.RemoveAt(0);
            return ToRemove;
        }
        public List<Card> Reset()
        {
            cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                int theSuit = i;
                for (int k = 0; k<13; k++)
                {
                    int stringval = k;
                    int val = k;
                    cards.Add(new Card(stringval, theSuit, val));
                }
            }
        return cards;
        }

        public List<Card> Shuffle()
        {
            cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                int theSuit = i;
                for (int k = 0; k<13; k++)
                {
                    int stringval = k;
                    int val = k;
                    cards.Add(new Card(stringval, theSuit, val));
                }
            }

            Random rand = new Random();
            List<Card> shuffledCards = new List<Card>();
            for (int s = 0; s <52; s++)
            {
                Card randie = cards[rand.Next(1,52)];
                shuffledCards.Add(randie);
            }
            return shuffledCards;
        }
    }
    //*************************************************** Player Class ************************************************************************/

    public class Player
    {
        public string Name;

        public List<Card> Hand;

        public Player(string Name)
        {
            this.Name = Name;
            this.Hand = new List<Card>();
        }

        public Card DrawCard(Card drawn)
        {
            Hand.Add(drawn);
            return drawn;
        }
    }

}
