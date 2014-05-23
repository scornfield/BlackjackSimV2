using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.CardGame.Library.Test
{
    [TestClass]
    public class CardRanksTests
    {
        [TestMethod]
        public void CardRanks_AllCardsInitiatlized()
        {
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
    }
}
