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

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i + 10)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i + 10)
                    .Select(i => i + 100)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i + 10)
                    .Select(i => i + 100)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
                tested
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .Where(item => item == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Where(1, (param, item) => item == param)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
                tested
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Where(Item.AreEqualTo(1))
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Where(Item.AreEqualTo(1))
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .Select(i => i)
                    .Where(i => i == 1)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Select(i => i)
                    .Where(Item.AreEqualTo(1))
            );

            CollectionAssert.AreEquivalent(
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
                    .Where(Item.AreEqualTo(1))
            );

            CollectionAssert.AreEquivalent(
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
                    .Where(Item.AreEqualTo(1))
            );

            CollectionAssert.AreEquivalent(
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
                    .Where(Item.AreEqualTo(1))
            );
        }

        [Test]
        public void TakeTests()
        {
            var tested = new[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 };

            CollectionAssert.AreEquivalent(
                tested
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Take(4)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .Take(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Take(4)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
                tested
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .TakeWhile(i => i != 4)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
                tested
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Skip(4)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .Skip(4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .Skip(4)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
                tested
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEquivalent(
                tested
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
                ,
                tested.AsLowCostLinq()
                    .Select(i => i)
                    .SkipWhile(i => i != 4)
            );

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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

            CollectionAssert.AreEquivalent(
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
    }
}
