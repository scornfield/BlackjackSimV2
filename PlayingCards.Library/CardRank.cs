using Cornfield.Utility.Library;

namespace Cornfield.PlayingCards.Library
{
    /// <summary>
    /// CardRank is just a specific abstraction of the NameAbbreviationPair class
    /// </summary>
    public class CardRank : NameAbbreviationPair
    {
        public CardRank(string abbrev, string name) : base(abbrev, name) { }
    }
}
