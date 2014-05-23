using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.CardGame.Library.Test
{
    /// <summary>
    /// Summary description for NameAbbreviationPairTests
    /// </summary>
    [TestClass]
    public class NameAbbreviationPairTests
    {
        [TestMethod]
        public void NameAbbreviationPair_OperatorEqualsTest()
        {
            Assert.IsTrue(new NameAbbreviationPair("S", "Steven") == new NameAbbreviationPair("S", "Steven"));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven") == new NameAbbreviationPair("S", "Bryan"));
            Assert.IsFalse(new NameAbbreviationPair("S", "Bryan") == new NameAbbreviationPair("S", "Steven"));
            Assert.IsFalse(new NameAbbreviationPair("X", "Steven") == new NameAbbreviationPair("S", "Steven"));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven") == new NameAbbreviationPair("X", "Steven"));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven") == null);
            Assert.IsFalse(null == new NameAbbreviationPair("S", "Steven"));
        }

        [TestMethod]
        public void NameAbbreviationPair_OperatorNotEqualsTest()
        {
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven") != new NameAbbreviationPair("S", "Steven"));
            Assert.IsTrue(new NameAbbreviationPair("S", "Steven") != new NameAbbreviationPair("S", "Bryan"));
            Assert.IsTrue(new NameAbbreviationPair("S", "Bryan") != new NameAbbreviationPair("S", "Steven"));
            Assert.IsTrue(new NameAbbreviationPair("X", "Steven") != new NameAbbreviationPair("S", "Steven"));
            Assert.IsTrue(new NameAbbreviationPair("S", "Steven") != new NameAbbreviationPair("X", "Steven"));
            Assert.IsTrue(new NameAbbreviationPair("S", "Steven") != null);
            Assert.IsTrue(null != new NameAbbreviationPair("S", "Steven"));
        }

        [TestMethod]
        public void NameAbbreviationPair_EqualsTest()
        {
            Assert.IsTrue(new NameAbbreviationPair("S", "Steven").Equals(new NameAbbreviationPair("S", "Steven")));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven").Equals(new NameAbbreviationPair("S", "Bryan")));
            Assert.IsFalse(new NameAbbreviationPair("S", "Bryan").Equals(new NameAbbreviationPair("S", "Steven")));
            Assert.IsFalse(new NameAbbreviationPair("X", "Steven").Equals(new NameAbbreviationPair("S", "Steven")));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven").Equals(new NameAbbreviationPair("X", "Steven")));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven").Equals(null));
            Assert.IsFalse(new NameAbbreviationPair("S", "Steven").Equals(4));
        }

    }
}
