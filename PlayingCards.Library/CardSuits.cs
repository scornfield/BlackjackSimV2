using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cornfield.PlayingCards.Library
{
    public static class CardSuits
    {
        private static ReadOnlyCollection<CardSuit> _suitList = null;

        public static readonly CardSuit Spades = new CardSuit("S", "Spades");
        public static readonly CardSuit Diamonds = new CardSuit("D", "Diamonds");
        public static readonly CardSuit Hearts = new CardSuit("H", "Hearts");
        public static readonly  CardSuit Clubs = new CardSuit("C", "Clubs");

        public static ReadOnlyCollection<CardSuit> getAllSuits()
        {
            if (_suitList == null)
                _suitList = new ReadOnlyCollection<CardSuit>(new List<CardSuit> { Spades, Diamonds, Hearts, Clubs });

            return _suitList;
        }
    }
}
