using Cornfield.Utility.Library;

namespace Cornfield.PlayingCards.Library
{
    /// <summary>
    /// CardSuit is just a specific abstraction of the NameAbbreviationPair class
    /// </summary>
    public class CardSuit : NameAbbreviationPair
    {
        public CardSuit(string abbrev, string name) : base(abbrev, name) { }
    }
}
