using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.PlayingCards.Library.Test
{
    [TestClass]
    public class CardRanksTests
    {
        [TestMethod]
        public void CardRanks_AllCardsInitiatlized()
        {
            // Verify that each of our CardRanks are initialized correctly
            Assert.AreEqual(CardRanks.Ace, new CardRank("A", "Ace"));
            Assert.AreEqual(CardRanks.Two, new CardRank("2", "Two"));
            Assert.AreEqual(CardRanks.Three, new CardRank("3", "Three"));
            Assert.AreEqual(CardRanks.Four, new CardRank("4", "Four"));
            Assert.AreEqual(CardRanks.Five, new CardRank("5", "Five"));
            Assert.AreEqual(CardRanks.Six, new CardRank("6", "Six"));
            Assert.AreEqual(CardRanks.Seven, new CardRank("7", "Seven"));
            Assert.AreEqual(CardRanks.Eight, new CardRank("8", "Eight"));
            Assert.AreEqual(CardRanks.Nine, new CardRank("9", "Nine"));
            Assert.AreEqual(CardRanks.Ten, new CardRank("10", "Ten"));
            Assert.AreEqual(CardRanks.Jack, new CardRank("J", "Jack"));
            Assert.AreEqual(CardRanks.Queen, new CardRank("Q", "Queen"));
            Assert.AreEqual(CardRanks.King, new CardRank("K", "King"));
        }

        [TestMethod]
        public void CardRanks_CardListInitialized()
        {
            // Verify that each of our expected cards is in the CardRanks list
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Ace));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Two));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Three));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Four));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Five));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Six));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Seven));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Eight));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Nine));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Ten));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Jack));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.Queen));
            Assert.IsTrue(CardRanks.getAllCards().Contains(CardRanks.King));

            // Check the number of cards to make sure there's nothing extra in the list
            Assert.AreEqual(13, CardRanks.getAllCards().Count);
        }
    }
}
