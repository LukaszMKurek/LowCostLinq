using System;
using System.Collections.Generic;
using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class TestAllAccumulators
    {
        public static readonly List<int[][]> TestCasesArray = new List<int[][]>();
        private static readonly Func<int, bool> Predicate = i => i == 2 || i == 3;

        static TestAllAccumulators()
        {
            TestCasesArray.Add(new[] { new int[0] });
            TestCasesArray.Add(new[] { new[] { 1 } });
            TestCasesArray.Add(new[] { new[] { 2 } });
            TestCasesArray.Add(new[] { new[] { 3 } });
            TestCasesArray.Add(new[] { new[] { 1, 1 } });
            TestCasesArray.Add(new[] { new[] { 2, 3 } });
            TestCasesArray.Add(new[] { new[] { 1, 2 } });
            TestCasesArray.Add(new[] { new[] { 2, 1 } });
            TestCasesArray.Add(new[] { new[] { 1, 1, 1 } });
            TestCasesArray.Add(new[] { new[] { 2, 3, 4 } });
            TestCasesArray.Add(new[] { new[] { 1, 2, 3 } });
            TestCasesArray.Add(new[] { new[] { 1, 2, 4 } });
            TestCasesArray.Add(new[] { new[] { 1, 4, 5, 1 } });
            TestCasesArray.Add(new[] { new[] { 1, 4, 5, 1, 5 } });
            TestCasesArray.Add(new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 7, 1, 1, 2, 3, 2, 3, 2, 7 } });

            var rnd = new Random();
            var longRandomArray = new int[rnd.Next(100, 200)];
            for (int i = 0; i < longRandomArray.Length; i++)
                longRandomArray[i] = rnd.Next() * (rnd.Next(0, 2) == 0 ? 1 : -1);

            TestCasesArray.Add(new[] { longRandomArray });
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void Count(int[] input)
        {
            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Count(),
                input.AsLowCostLinq().Count()
            );

            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Select(i => i).Count(),
                input.AsLowCostLinq().Select(i => i).Count()
            );

            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Select(i => i).Select(i => i).Count(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Count()
            );

            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Select(i => i).Select(i => i).Select(i => i).Count(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Count()
            );

            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Count(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Count()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void CountWhere(int[] input)
        {
            Assert.AreEqual(
                input.Count(Predicate),
                input.AsLowCostLinq().Count(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Count(Predicate),
                input.AsLowCostLinq().Select(i => i).Count(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Count(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Count(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Count(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Count(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Count(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Count(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void FirstOrDefault(int[] input)
        {
            Assert.AreEqual(
                input.FirstOrDefault(),
                input.AsLowCostLinq().FirstOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).FirstOrDefault(),
                input.AsLowCostLinq().Select(i => i).FirstOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).FirstOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).FirstOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).FirstOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).FirstOrDefault()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void FirstOrDefaultWhere(int[] input)
        {
            Assert.AreEqual(
                input.FirstOrDefault(Predicate),
                input.AsLowCostLinq().FirstOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).FirstOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).FirstOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).FirstOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).FirstOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).FirstOrDefault(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void First(int[] input)
        {
            if (input.Length == 0)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.First());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().First());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).First());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).First());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).First());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).First());

                return;
            }

            Assert.AreEqual(
                input.First(),
                input.AsLowCostLinq().First()
            );

            Assert.AreEqual(
                input.Select(i => i).First(),
                input.AsLowCostLinq().Select(i => i).First()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).First(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).First()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).First(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).First()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).First(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).First()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void FirstWhere(int[] input)
        {
            if (input.Count(Predicate) == 0)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.First(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().First(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).First(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).First(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).First(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).First(Predicate));

                return;
            }

            Assert.AreEqual(
                input.First(Predicate),
                input.AsLowCostLinq().First(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).First(Predicate),
                input.AsLowCostLinq().Select(i => i).First(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).First(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).First(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).First(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).First(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).First(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).First(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void SingleOrDefault(int[] input)
        {
            if (input.Length > 1)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.SingleOrDefault());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().SingleOrDefault());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).SingleOrDefault());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).SingleOrDefault());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SingleOrDefault());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault());

                return;
            }

            Assert.AreEqual(
                input.SingleOrDefault(),
                input.AsLowCostLinq().SingleOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).SingleOrDefault(),
                input.AsLowCostLinq().Select(i => i).SingleOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).SingleOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).SingleOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SingleOrDefault()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void SingleOrDefaultWhere(int[] input)
        {
            if (input.Count(Predicate) > 1)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.SingleOrDefault(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().SingleOrDefault(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).SingleOrDefault(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).SingleOrDefault(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate));

                return;
            }

            Assert.AreEqual(
                input.SingleOrDefault(Predicate),
                input.AsLowCostLinq().SingleOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).SingleOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).SingleOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).SingleOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).SingleOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).SingleOrDefault(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void Single(int[] input)
        {
            if (input.Length == 0 || input.Length > 1)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.Single());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Single());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Single());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Single());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Single());
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single());

                return;
            }

            Assert.AreEqual(
                input.Single(),
                input.AsLowCostLinq().Single()
            );

            Assert.AreEqual(
                input.Select(i => i).Single(),
                input.AsLowCostLinq().Select(i => i).Single()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Single(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Single()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Single(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Single()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void SingleWhere(int[] input)
        {
            if (input.Count(Predicate) == 0 || input.Count(Predicate) > 1)
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Assert.Throws<InvalidOperationException>(() => input.Single(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Single(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Single(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Single(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Single(Predicate));
                Assert.Throws<InvalidOperationException>(() => input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single(Predicate));

                return;
            }

            Assert.AreEqual(
                input.Single(Predicate),
                input.AsLowCostLinq().Single(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Single(Predicate),
                input.AsLowCostLinq().Select(i => i).Single(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Single(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Single(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Single(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Single(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Single(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void Any(int[] input)
        {
            Assert.AreEqual(
                input.Any(),
                input.AsLowCostLinq().Any()
            );

            Assert.AreEqual(
                input.Select(i => i).Any(),
                input.AsLowCostLinq().Select(i => i).Any()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Any(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Any()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Any(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Any()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Any(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Any()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void AnyWhere(int[] input)
        {
            Assert.AreEqual(
                input.Any(Predicate),
                input.AsLowCostLinq().Any(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Any(Predicate),
                input.AsLowCostLinq().Select(i => i).Any(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Any(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Any(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Any(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Any(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).Any(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).Any(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void AllWhere(int[] input)
        {
            Assert.AreEqual(
                input.All(Predicate),
                input.AsLowCostLinq().All(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).All(Predicate),
                input.AsLowCostLinq().Select(i => i).All(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).All(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).All(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).All(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).All(Predicate)
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).All(Predicate),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).All(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void ToArray(int[] input)
        {
            Assert.AreEqual(
                input.ToArray(),
                input.AsLowCostLinq().ToArray()
            );

            Assert.AreEqual(
                input.Select(i => i).ToArray(),
                input.AsLowCostLinq().Select(i => i).ToArray()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).ToArray(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).ToArray()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).ToArray(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).ToArray()
            );

            Assert.AreEqual(
                input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).ToArray(),
                input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).ToArray()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void ToArrayWithOutputSizeHint(int[] input)
        {
            foreach (var sizeHint in new uint[] { 0, 1, 2, 3, 4, 5, 6, 40, 77, 10215 })
            {
                Assert.AreEqual(
                    input.ToArray(),
                    input.AsLowCostLinq().ToArray(expectedCapacity: sizeHint)
                );

                Assert.AreEqual(
                    input.Select(i => i).ToArray(),
                    input.AsLowCostLinq().Select(i => i).ToArray(expectedCapacity: sizeHint)
                );

                Assert.AreEqual(
                    input.Select(i => i).Select(i => i).ToArray(),
                    input.AsLowCostLinq().Select(i => i).Select(i => i).ToArray(expectedCapacity: sizeHint)
                );

                Assert.AreEqual(
                    input.Select(i => i).Select(i => i).Select(i => i).ToArray(),
                    input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).ToArray(expectedCapacity: sizeHint)
                );

                Assert.AreEqual(
                    input.Select(i => i).Select(i => i).Select(i => i).Select(i => i).ToArray(),
                    input.AsLowCostLinq().Select(i => i).Select(i => i).Select(i => i).Select(i => i).ToArray(expectedCapacity: sizeHint)
                );
            }
        }
    }
}