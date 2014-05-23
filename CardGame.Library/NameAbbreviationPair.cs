using System;

namespace Cornfield.CardGame.Library
{
    public class NameAbbreviationPair : EquatableBase<NameAbbreviationPair>, INameAbbreviationPair, IEquatable<NameAbbreviationPair>
    {
        public string Abbrev { get; protected set; }
        public string Name { get; protected set; }

        public NameAbbreviationPair(string abbrev, string name)
        {
            Abbrev = abbrev;
            Name = name;
        }

        public override string ToString()
        {
            return Abbrev;
        }

        public override bool Equals(NameAbbreviationPair other)
        {
            if (other == null)
                return Object.Equals(this, other);

            return Abbrev == other.Abbrev && Name == other.Name;
        }
    }
}
