using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornfield.CardGame.Library
{
    public interface ICard
    {
        CardRank Rank { get; }
        CardSuit Suit { get; }
    }
}
