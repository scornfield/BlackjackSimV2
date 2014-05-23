using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.PlayingCards.Library.Test
{
    [TestClass]
    public class CardSuitsTests
    {
        [TestMethod]
        public void CardSuits_AllSuitsInitiatlized()
        {
            // Verify that each of our CardSuits are initialized correctly
            Assert.AreEqual(CardSuits.Clubs, new CardSuit("C", "Clubs"));
            Assert.AreEqual(CardSuits.Diamonds, new CardSuit("D", "Diamonds"));
            Assert.AreEqual(CardSuits.Hearts, new CardSuit("H", "Hearts"));
            Assert.AreEqual(CardSuits.Spades, new CardSuit("S", "Spades"));
        }

        [TestMethod]
        public void CardSuits_SuitListInitiatlized()
        {
            // Verify that each of our CardSuits are initialized correctly
            Assert.IsTrue(CardSuits.getAllSuits().Contains(CardSuits.Clubs));
            Assert.IsTrue(CardSuits.getAllSuits().Contains(CardSuits.Diamonds));
            Assert.IsTrue(CardSuits.getAllSuits().Contains(CardSuits.Hearts));
            Assert.IsTrue(CardSuits.getAllSuits().Contains(CardSuits.Spades));

            Assert.AreEqual(4, CardSuits.getAllSuits().Count);
        }
    }
}
