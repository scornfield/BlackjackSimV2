using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Cornfield.PlayingCards.Library.Test
{
    [TestClass]
    public class PlayingCardCollectionTests
    {
        [TestMethod]
        public void PlayingCardCollection_ConstructorWithNoParametersTest()
        {
            PlayingCardCollection tmp = new PlayingCardCollection();
            
            // Verify that the new collection is empty
            Assert.AreEqual(0, tmp.Count);
        }

        [TestMethod]
        public void PlayingCardCollection_ConstructorWithListParameterTest()
        {
            PlayingCardCollection tmp = new PlayingCardCollection(new List<IPlayingCard>());

            // Verify that the new collection is empty
            Assert.AreEqual(0, tmp.Count);
        }

        [TestMethod]
        public void PlayingCardCollection_ToStringTest()
        {
            PlayingCardCollection tmp = new PlayingCardCollection();

            tmp.Add(new PlayingCard(CardRanks.Ace, CardSuits.Spades));
            tmp.Add(new PlayingCard(CardRanks.King, CardSuits.Hearts));

            Assert.AreEqual(2, tmp.Count);
            Assert.AreEqual(string.Format("{0} {1}", new PlayingCard(CardRanks.Ace, CardSuits.Spades), new PlayingCard(CardRanks.King, CardSuits.Hearts)), tmp.ToString());

        }
    }
}
