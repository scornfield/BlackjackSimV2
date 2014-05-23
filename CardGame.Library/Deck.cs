using System;
using System.Collections.Generic;

namespace Cornfield.CardGame.Library
{
    public class Deck : CardCollection
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
                ICard temp = this[n];
                this[n] = this[k];
                this[k] = temp;
            }
        }

        public ICard Pop()
        {
            ICard tmp = this[0];
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
                    this.Add(new Card(rank, suit));
                }
            }
        }

    }
}
