using System;
using System.Collections.Generic;

namespace Cornfield.PlayingCards.Library
{
    public class Deck : PlayingCardCollection
    {
        public Deck() : base() { }

        /// <summary>
        /// Suffles the deck using Fisher-Yates algorithm
        /// </summary>
        public void Shuffle()
        {
            Random rng = new Random();
            int n = this.Count;
            while (n > 1)
            {
                int k = rng.Next(n);
                --n;
                IPlayingCard temp = this[n];
                this[n] = this[k];
                this[k] = temp;
            }
        }

        public IPlayingCard Pop()
        {
            IPlayingCard tmp = this[0];
            this.RemoveAt(0);
            return tmp;
        }

        public void AddStandardDeck()
        {
            IReadOnlyCollection<CardRank> ranks = CardRanks.getAllCards();
            IReadOnlyCollection<CardSuit> suits = CardSuits.getAllSuits();

            foreach (CardRank rank in ranks)
            {
                foreach (CardSuit suit in suits)
                {
                    this.Add(new PlayingCard(rank, suit));
                }
            }
        }

    }
}
