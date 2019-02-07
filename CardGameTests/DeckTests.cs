using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Tests
{
    [TestClass()]
    public class DeckTests
    {
        //Test that deck contains cards
        [TestMethod()]
        public void DeckTest()
        {
            var deck = new Deck();
            var testInput = new List<Card>(deck.Cards);
             
            foreach (var card in testInput)
            {
                Assert.IsTrue(deck.Cards.Contains(card));
            }

        }

        //Test if deck is indeed shuffled and different every time
        [TestMethod()]
        public void ShuffleTest()
        {
            var deck = new Deck();
            var testInput = new List<Card>(deck.Cards);
            deck.Shuffle();
            
            var count = 0;
            for(var i = 0; i < testInput.Count; i++)
            {
                if(testInput[i] == deck.Cards[i])
                {
                    count++;
                }
            }
            Assert.AreNotEqual(count, deck.Cards.Count);
        }

        //Test if shuffled deck gets sorted again
        [TestMethod()]
        public void SortTest()
        {
            var deck = new Deck();
            deck.Shuffle();
            var shuffledDeck = new List<Card>(deck.Cards);
            deck.Sort();

            var count = 0;
            for (int i = 0; i < shuffledDeck.Count; i++)
            {
                if (shuffledDeck[i] == deck.Cards[i])
                {
                    count++;
                }
            }
            Assert.AreNotEqual(count, deck.Cards.Count);
        }
    }
}