using System;
using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class RangeTests
    {
        [TestCase(Int32.MinValue, Int32.MaxValue)]
        [TestCase(0, Int32.MaxValue)]
        [TestCase(Int32.MinValue, 0)]
        public void Range(int startFrom, int count)
        {
            LowCostEnumerable.Range(startFrom, count);
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void Where(int startFrom, int count)
        {
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count),
                LowCostEnumerable.Range(startFrom, count)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count),
                LowCostEnumerable.Range(startFrom, count).ToArray()
            );
            Assert.AreEqual(
                Enumerable.Range(startFrom, count).FirstOrDefault(),
                LowCostEnumerable.Range(startFrom, count).FirstOrDefault()
            );

            Func<int, bool> predicate1 = i => i != 1 && i != 2;
            Func<int, bool> predicate2 = i => i != 3 && i != 4;
            Func<int, bool> predicate3 = i => i != 5 && i != 6;
            Func<int, bool> predicate4 = i => i != 7 && i != 8;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).ToArray()
            );
            Assert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).FirstOrDefault(),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).FirstOrDefault()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).ToArray()
            );
            Assert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).FirstOrDefault(),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).FirstOrDefault()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).ToArray()
            );
            Assert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).FirstOrDefault(),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).FirstOrDefault()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4).ToArray()
            );
            Assert.AreEqual(
                Enumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4).FirstOrDefault(),
                LowCostEnumerable.Range(startFrom, count).Where(predicate1).Where(predicate2).Where(predicate3).Where(predicate4).FirstOrDefault()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void Select(int startFrom, int count)
        {
            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1),
                LowCostEnumerable.Range(startFrom, count).Select(select1)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1),
                LowCostEnumerable.Range(startFrom, count).Select(select1).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4).ToArray()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void TakeWhile(int startFrom, int count)
        {
            Func<int, bool> takeWhilePredicate = i => i < 20;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).ToArray()
            );

            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4).TakeWhile(takeWhilePredicate)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4).TakeWhile(takeWhilePredicate),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).Select(select4).TakeWhile(takeWhilePredicate).ToArray()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void TakeWhile2(int startFrom, int count)
        {
            Func<int, bool> takeWhilePredicate = i => i < 20;
            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3).Select(select4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).TakeWhile(takeWhilePredicate).Select(select1).Select(select2).Select(select3).Select(select4).ToArray()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void TakeWhile3(int startFrom, int count)
        {
            Func<int, bool> takeWhilePredicate = i => i < 20;
            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3).Select(select4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).TakeWhile(takeWhilePredicate).Select(select2).Select(select3).Select(select4).ToArray()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void TakeWhile4(int startFrom, int count)
        {
            Func<int, bool> takeWhilePredicate = i => i < 20;
            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3).ToArray()
            );

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3).Select(select4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).TakeWhile(takeWhilePredicate).Select(select3).Select(select4).ToArray()
            );
        }

        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(-10, 100)]
        [TestCase(10, 100)]
        public void TakeWhile5(int startFrom, int count)
        {
            Func<int, bool> takeWhilePredicate = i => i < 20;
            Func<int, int> select1 = i => i * 3;
            Func<int, int> select2 = i => i * 5;
            Func<int, int> select3 = i => i * 7;
            Func<int, int> select4 = i => i * 11;

            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate).Select(select4)
            );
            CollectionAssert.AreEqual(
                Enumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate).Select(select4),
                LowCostEnumerable.Range(startFrom, count).Select(select1).Select(select2).Select(select3).TakeWhile(takeWhilePredicate).Select(select4).ToArray()
            );
        }

        // todo check enumerator behaviour during non standard usage
    }
}