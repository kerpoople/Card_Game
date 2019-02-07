using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
   public class Deck
    {
        public List<Card> Cards { get; set; } //List to hold cards.
        private Random rnd; //Randomizer for shuffle function


        //Function to create new Cards.
        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            Cards = new List<Card>();
          
            for (int y = 0; y < suits.Length; y++)
            {
                for (int i = 0; i < faces.Length; i++)
                {
                   //Assign values to card for easier sorting. Create cards and add to the Cards.
                    int card_value = y * faces.Length + i ;
                    Card c = new Card(faces[i], suits[y], card_value);
                    Cards.Add(c);
                }
            }
        }

        //Function for shuffling the Cards
        public void Shuffle()
        {
            rnd = new Random();
            for (int first = 0; first < Cards.Count; first++)
            {
                int second = rnd.Next(Cards.Count - 1); //Store next random card
                Card temp = Cards[first]; //Saves and swaps the picked card with the next randomized one
                Cards[first] = Cards[second];
                Cards[second] = temp;
            }
        }

        //Function to sort the deck after faces and suits.
        public void Sort()
        {
            //Order cards by assigned value to get the sorting right.
            Cards = Cards.OrderBy(x => x.value).ToList(); 
        }

        //Function to deal card from deck.
        public List<Card> DealCard(int number = 1)
        {
            //Remove first card from deck.
            List<Card> cards = new List<Card>();
            for (int i = 0; (i < number && Cards.Count() > 0); i++)
            {
                Card c = Cards[0];
                Cards.RemoveAt(0);
                cards.Add(c);
            }

            return cards;
        }

        //Function to show cards left in deck
        public void Show()
        {
            for (int i = 0; i < Cards.Count; i++) //Loop through all cards
            {
                //Print cards in a prettier way
                Console.Write("{0,-19}", Cards[i]); 
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
        }
    }
}