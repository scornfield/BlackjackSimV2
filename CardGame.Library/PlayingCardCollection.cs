using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cornfield.PlayingCards.Library
{
    public class PlayingCardCollection : Collection<IPlayingCard> 
    {
        public PlayingCardCollection() : base() { }
        public PlayingCardCollection(IList<IPlayingCard> list) : base(list) { }

        public override string ToString()
        {
            return string.Join(" ", this);
        }
    }
}
