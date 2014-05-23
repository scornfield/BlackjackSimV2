using System;
using Cornfield.Utility.Library;

namespace Cornfield.PlayingCards.Library
{
    public class PlayingCard : EquatableBase<PlayingCard>, IPlayingCard, IEquatable<PlayingCard>
    {
        public CardRank Rank { get; protected set; }
        public CardSuit Suit { get; protected set; }

        public PlayingCard(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Rank, Suit);
        }

        public override bool Equals(PlayingCard other)
        {
            if (other == null)
                return false;

            return Rank == other.Rank && Suit == other.Suit;
        }
    }
}
