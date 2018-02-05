using System;
using System.Collections.Generic;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class TestAllInvalidArgument
    {
        private static readonly int[] Array = new int[0];

        [Test]
        public void AsLowCostLinq()
        {
            Assert.Throws<ArgumentNullException>(() => ((int[])null).AsLowCostLinq());

            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).AsLowCostLinq());
            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).AsLowCostLinqWithoutChecks());

            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)null).AsLowCostLinq());
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)null).AsLowCostLinqWithoutChecks());
            
            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).AsLowCostLinqGeneric<int, List<int>>());
            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).AsLowCostLinqWithoutChecksGeneric<int, List<int>>());
        }

        [Test]
        public void ItemsMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Items.AreGreatherThan((string)null));
            Assert.Throws<ArgumentNullException>(() => Items.AreGreatherOrEqualThan((string)null));
            Assert.Throws<ArgumentNullException>(() => Items.AreSmallerThan((string)null));
            Assert.Throws<ArgumentNullException>(() => Items.AreSmallerOrEqualThan((string)null));
        }

        [Test]
        public void WhereMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Where(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Where(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Where(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Where(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Where(null));
        }

        [Test]
        public void WhereNewApiMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Where(1, null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Where(1, null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Where(0, null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Where(1, null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Where(1, null));
        }

        [Test]
        public void SelectMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select((Func<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select((Func<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select((Func<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select((Func<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Select((Func<int, int>)null));
        }

        [Test]
        public void TakeWhileMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().TakeWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).TakeWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).TakeWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).TakeWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).TakeWhile(null));
        }

        [Test]
        public void SkipWhileMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().SkipWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).SkipWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).SkipWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SkipWhile(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SkipWhile(null));
        }

        [Test]
        public void LowCostEnumerableMethods()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LowCostEnumerable.Range(0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => LowCostEnumerable.Range(1, Int32.MaxValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => LowCostEnumerable.Range(10, Int32.MaxValue));
        }
    }
}
