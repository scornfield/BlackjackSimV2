using System;

namespace Cornfield.Utility.Library
{
    /// <summary>
    /// This is a utility class that gives an object a name and abbreviation.  
    /// These properties are then used to determine when two objects are equal utilizing the EquatableBase class.
    /// </summary>
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
