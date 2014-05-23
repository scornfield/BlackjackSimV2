using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cornfield.CardGame.Library
{
    public class CardRanks
    {
        private static ReadOnlyCollection<CardRank> _cardList = null;

        public static readonly CardRank Ace = new CardRank("A", "Ace");
        public static readonly CardRank Two = new CardRank("2", "Two");
        public static readonly CardRank Three = new CardRank("3", "Three");
        public static readonly CardRank Four = new CardRank("4", "Four");
        public static readonly CardRank Five = new CardRank("5", "Five");
        public static readonly CardRank Six = new CardRank("6", "Six");
        public static readonly CardRank Seven = new CardRank("7", "Seven");
        public static readonly CardRank Eight = new CardRank("8", "Eight");
        public static readonly CardRank Nine = new CardRank("9", "Nine");
        public static readonly CardRank Ten = new CardRank("10", "Ten");
        public static readonly CardRank Jack = new CardRank("J", "Jack");
        public static readonly CardRank Queen = new CardRank("Q", "Queen");
        public static readonly CardRank King = new CardRank("K", "King");

        public static ReadOnlyCollection<CardRank> getAllCards()
        {
            if (_cardList == null) 
                _cardList = new ReadOnlyCollection<CardRank>(new List<CardRank> { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King });

            return _cardList;
        }
    }
}
