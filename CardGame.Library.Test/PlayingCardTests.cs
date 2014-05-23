using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.PlayingCards.Library.Test
{
    [TestClass]
    public class PlayingCardTests
    {
        [TestMethod]
        public void PlayingCard_ToStringTest()
        {
            PlayingCard AceOfSpades = new PlayingCard(CardRanks.Ace, CardSuits.Spades);
            Assert.AreEqual(string.Format("{0}{1}", CardRanks.Ace, CardSuits.Spades), AceOfSpades.ToString());
        }

        [TestMethod]
        public void PlayingCard_EqualityTest()
        {
            PlayingCard AceOfSpades = new PlayingCard(CardRanks.Ace, CardSuits.Spades);
            PlayingCard AceOfSpades2 = new PlayingCard(CardRanks.Ace, CardSuits.Spades);
            PlayingCard KingOfHearts = new PlayingCard(CardRanks.King, CardSuits.Hearts);

            Assert.AreEqual(AceOfSpades, AceOfSpades2);
            Assert.AreNotEqual(AceOfSpades, KingOfHearts);
            Assert.IsFalse(AceOfSpades.Equals(null));
        }
    }
}
