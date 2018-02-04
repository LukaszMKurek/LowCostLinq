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
            TestCasesArray.Add(new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 7, 1, 1, 2, 3, 2, 3, 2, 7 } });
            TestCasesArray.Add(new[] { new[] { 1, 4, 5, 1, 5 } });
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void Count(int[] input)
        {
            Assert.AreEqual(
                // ReSharper disable once UseCollectionCountProperty
                input.Count(),
                input.AsLowCostLinq().Count()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void CountWhere(int[] input)
        {
            Assert.AreEqual(
                input.Count(Predicate),
                input.AsLowCostLinq().Count(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void FirstOrDefault(int[] input)
        {
            Assert.AreEqual(
                input.FirstOrDefault(),
                input.AsLowCostLinq().FirstOrDefault()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void FirstOrDefaultWhere(int[] input)
        {
            Assert.AreEqual(
                input.FirstOrDefault(Predicate),
                input.AsLowCostLinq().FirstOrDefault(Predicate)
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

                return;
            }

            Assert.AreEqual(
                input.First(),
                input.AsLowCostLinq().First()
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

                return;
            }

            Assert.AreEqual(
                input.First(Predicate),
                input.AsLowCostLinq().First(Predicate)
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

                return;
            }

            Assert.AreEqual(
                input.Single(),
                input.AsLowCostLinq().Single()
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

                return;
            }

            Assert.AreEqual(
                input.Single(Predicate),
                input.AsLowCostLinq().Single(Predicate)
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void Any(int[] input)
        {
            Assert.AreEqual(
                input.Any(),
                input.AsLowCostLinq().Any()
            );
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void AnyWhere(int[] input)
        {
            Assert.AreEqual(
                input.Any(Predicate),
                input.AsLowCostLinq().Any(Predicate)
            );
        }
        
        [TestCaseSource(nameof(TestCasesArray))]
        public void AllWhere(int[] input)
        {
            Assert.AreEqual(
                input.All(Predicate),
                input.AsLowCostLinq().All(Predicate)
            );
        }
    }
}
