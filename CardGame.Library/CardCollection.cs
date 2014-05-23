using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cornfield.CardGame.Library
{
    public class CardCollection : Collection<ICard> 
    {
        public CardCollection() : base() { }
        public CardCollection(IList<ICard> list) : base(list) { }

        public override string ToString()
        {
            return string.Join(" ", this);
        }
    }
}
