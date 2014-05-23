using System;

namespace Cornfield.Utility.Library
{
    /// <summary>
    /// This abstract class is a utility that provides base code for equality comparisons of custom types
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EquatableBase<T> : IEquatable<T> where T : EquatableBase<T>, IEquatable<T>
    {
        public abstract bool Equals(T other);

        public override bool Equals(object obj)
        {
            // If parameter cannot be cast, return false:
            T castedObj = obj as T;
            if (castedObj == null)
                return false;

            // Call our type specific comparision method
            return Equals(castedObj);
        }

        public static bool operator ==(EquatableBase<T> a, EquatableBase<T> b)
        {
            if ((object)a == null || ((object)b) == null)
                return Object.Equals(a, b);

            return a.Equals(b);
        }

        public static bool operator !=(EquatableBase<T> a, EquatableBase<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
