using System.Collections.Generic;
using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class TestAllPublicFilters
    {
        [Test]
        public void SelectTests()
        {
            var tested = new[] { 1, 2, 5 };

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
                    .Select(i => i + 100000)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
                    .Select(i => i + 100000)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
                    .Select(i => i + 100000)
                    .Select(i => i + 1000000)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                    .Select(i => i + 1000)
                    .Select(i => i + 10000)
                    .Select(i => i + 100000)
                    .Select(i => i + 1000000)
            );
        }

        [Test]
        public void WhereTests()
        {
            var tested = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );
        }

        [Test]
        public void LowCostWhereTests()
        {
            var tested = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Where(Items.AreEqualTo(1))
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Where(Items.AreEqualTo(1))
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Where(Items.AreEqualTo(1))
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(Items.AreEqualTo(1))
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(Items.AreEqualTo(1))
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Where(Items.AreEqualTo(1))
            );
        }

        [Test]
        public void TakeTests()
        {
            var tested = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Take(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Take(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Take(4)
            );
        }

        [Test]
        public void TakeWhileTests()
        {
            var tested = new[] { 0, 1, 1, 0, 4, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );
        }

        [Test]
        public void SkipTests()
        {
            var tested = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Skip(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Skip(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Skip(4)
            );
        }

        [Test]
        public void SkipWhileTests()
        {
            var tested = new[] { 0, 1, 1, 0, 4, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEqual(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );
        }

        [Test]
        public void LowCostWhereTest()
        {
            var testedArray = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };
            var testedList = new List<int> { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };
            IEnumerable<int> testedEnumerable = new List<int> { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                testedArray
                    .Where(item => item == 1)
                ,
                testedArray
                    .LowCostWhere(item => item == 1)
            );

            CollectionAssert.AreEqual(
                testedList
                    .Where(item => item == 1)
                ,
                testedList
                    .LowCostWhere(item => item == 1)
            );

            CollectionAssert.AreEqual(
                testedList
                    .Where(item => item == 1)
                ,
                testedList
                    .LowCostWhereWithoutChecks(item => item == 1)
            );

            CollectionAssert.AreEqual(
                testedEnumerable
                    .Where(item => item == 1)
                ,
                testedEnumerable
                    .LowCostWhere(item => item == 1)
            );

            CollectionAssert.AreEqual(
                testedEnumerable
                    .Where(item => item == 1)
                ,
                testedEnumerable
                    .LowCostWhereWithoutChecks(item => item == 1)
            );
        }

        [Test]
        public void AsLowCostLinqGenericTests()
        {
            var tested = new List<int> { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEqual(
                tested
                    .Where(item => item == 1)
                ,
                tested
                    .AsLowCostLinqGeneric<int, List<int>>()
                    .Where(item => item == 1)
            );

            CollectionAssert.AreEqual(
                tested
                    .Where(item => item == 1)
                ,
                tested
                    .AsLowCostLinqWithoutChecksGeneric<int, List<int>>()
                    .Where(item => item == 1)
            );
        }
    }
}