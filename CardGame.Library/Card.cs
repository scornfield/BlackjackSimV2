using System;

namespace Cornfield.CardGame.Library
{
    public class Card : EquatableBase<Card>, ICard, IEquatable<Card>
    {
        public CardRank Rank { get; protected set; }
        public CardSuit Suit { get; protected set; }

        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Rank, Suit);
        }

        public override bool Equals(Card other)
        {
            if (other == null)
                return false;

            return Rank == other.Rank && Suit == other.Suit;
        }
    }
}
