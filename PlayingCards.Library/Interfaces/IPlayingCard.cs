using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornfield.PlayingCards.Library
{
    public interface IPlayingCard
    {
        CardRank Rank { get; }
        CardSuit Suit { get; }
    }
}
