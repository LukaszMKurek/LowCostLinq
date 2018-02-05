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
            Assert.Throws<ArgumentNullException>(() => ((int[])null).LowCostWhere(null));
            Assert.Throws<ArgumentNullException>(() => Array.LowCostWhere(null));

            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).LowCostWhere(null));
            Assert.Throws<ArgumentNullException>(() => new List<int>().LowCostWhere(null));

            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).LowCostWhereWithoutChecks(null));
            Assert.Throws<ArgumentNullException>(() => new List<int>().LowCostWhereWithoutChecks(null));

            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)null).LowCostWhere(null));
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)new List<int>()).LowCostWhere(null));

            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)null).LowCostWhereWithoutChecks(null));
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)new List<int>()).LowCostWhereWithoutChecks(null));

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
        public void FirstMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().First(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).First(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).First(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).First(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).First(null));
        }

        [Test]
        public void FirstOrDefaultMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().FirstOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).FirstOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).FirstOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(null));
        }

        [Test]
        public void SingleMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Single(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Single(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Single(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Single(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single(null));
        }

        [Test]
        public void SingleOrDefaultMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().SingleOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).SingleOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).SingleOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(null));
        }

        [Test]
        public void AnyMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Any(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Any(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Any(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Any(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Any(null));
        }

        [Test]
        public void AllMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().All(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).All(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).All(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).All(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).All(null));
        }

        [Test]
        public void CountMethods()
        {
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Count(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Count(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Count(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Count(null));
            Assert.Throws<ArgumentNullException>(() => Array.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Count(null));
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
