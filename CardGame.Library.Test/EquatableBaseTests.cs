using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cornfield.CardGame.Library.Test
{
    [TestClass]
    public class EquatableBaseTests
    {
        public class TestEquatableObj : EquatableBase<TestEquatableObj>
        {
            public int Val { get; set; }

            public TestEquatableObj(int val)
            {
                Val = val;
            }

            public override bool Equals(TestEquatableObj other)
            {
                if (other == null)
                    return false;

                return Val == other.Val;
            }
        }

        [TestMethod]
        public void EquatableBase_EqualsTest()
        {
            Assert.IsTrue(new TestEquatableObj(1).Equals(new TestEquatableObj(1)));
            Assert.IsFalse(new TestEquatableObj(1).Equals(new TestEquatableObj(2)));
            Assert.IsFalse(new TestEquatableObj(2).Equals(new TestEquatableObj(1)));
            Assert.IsFalse(new TestEquatableObj(1).Equals(null));
            Assert.IsFalse(new TestEquatableObj(1).Equals(4));
        }

        [TestMethod]
        public void EquatableBase_OperatorEqualsTest()
        {
            Assert.IsTrue(new TestEquatableObj(1) == new TestEquatableObj(1));
            Assert.IsFalse(new TestEquatableObj(1) == new TestEquatableObj(2));
            Assert.IsFalse(new TestEquatableObj(2) == new TestEquatableObj(1));
            Assert.IsFalse(new TestEquatableObj(1) == null);
            Assert.IsFalse(null == new TestEquatableObj(1));
        }

        [TestMethod]
        public void EquatableBase_OperatorNotEqualsTest()
        {
            Assert.IsFalse(new TestEquatableObj(1) != new TestEquatableObj(1));
            Assert.IsTrue(new TestEquatableObj(1) != new TestEquatableObj(2));
            Assert.IsTrue(new TestEquatableObj(2) != new TestEquatableObj(1));
            Assert.IsTrue(new TestEquatableObj(1) != null);
            Assert.IsTrue(null != new TestEquatableObj(1));
        }
    }
}
