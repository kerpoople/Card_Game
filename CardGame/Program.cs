using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck(); //Add new deck
            string choice = "";

            //Keep program open
            while (choice != "exit")
            {
                Console.WriteLine("Write 'Draw', 'Show', 'Sort' or 'Shuffle'. \n 'Exit' to quit.\n");
                choice = Console.ReadLine().ToLower(); //Make input case insensitive

                //Switch for program choices
                switch (choice)
                {
                    case "draw":
                        List<Card> cards = deck.DealCard(1);
                        foreach (Card c in cards)
                        {
                            Console.WriteLine("\n You got " + c);
                        }
                        break;
                    case "show":
                        deck.Show();
                        break;
                    case "sort":
                        deck.Sort();
                        break;
                    case "shuffle":
                        deck.Shuffle();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}




