using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class LowCostLinqProperlyCallIEnumerableInterface
    {
        [Test]
        public void EnumerateAll([Values(0, 1, 2, 3, 100/*, 200_000_000*/)] int count)
        {
            var collection = new StubCollection(count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks(), count, count);
            
            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0), count, count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0), count, count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).ToArray(), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0), count, count);
        }

        [Test]
        public void EnumerateNone([Values(0, 1, 2, 3, 100/*, 200_000_000*/)] int count)
        {
            var collection = new StubCollection(count);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).ToArray(), count, 0);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).ToArray(), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0), count, 0);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0), count, 0);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);

            AssertToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).ToArray(), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);
            AssertIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0).Where(i => i != 0), count, 0);
        }

        [Test]
        public void BreakEarly([Values(0, 1, 2, 3, 100/*, 200_000_000*/)] int count, [Values(0, 1, 5)] int breakAfter)
        {
            var collection = new StubCollection(count);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Take(breakAfter), count, breakAfter);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Take(breakAfter), count, breakAfter);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);

            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakToArrayBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter).ToArray(), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinq().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);
            AssertEarlyBreakIEnumerableBehaviour(() => collection.AsLowCostLinqWithoutChecks().Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Where(i => i == 0).Take(breakAfter), count, breakAfter);
        }

        public void AssertToArrayBehaviour(Func<int[]> testedAction, int inputCount, int outputCount)
        {
            StubCollection.ResetStatistics();

            var array = testedAction();

            Assert.AreEqual(outputCount, array.Length);
            StubCollection.VeryfiEnumerateBechaviourAndReset(inputCount);
        }

        public void AssertEarlyBreakToArrayBehaviour(Func<int[]> testedAction, int inputCount, int breakAfter)
        {
            StubCollection.ResetStatistics();

            var array = testedAction();

            Assert.AreEqual(Math.Min(inputCount, breakAfter), array.Length);
            StubCollection.VeryfiEnumerateBechaviourAfterEarlyBreakAndReset(inputCount, breakAfter);
        }

        public void AssertIEnumerableBehaviour(Func<IEnumerable<int>> testedAction, int inputCount, int outputCount)
        {
            StubCollection.ResetStatistics();

            var result = testedAction();

            Assert.AreEqual(outputCount, result.Count());
            StubCollection.VeryfiEnumerateBechaviourAndReset(inputCount);

            Assert.AreEqual(outputCount, Enumerate(testedAction()).count);
            StubCollection.VeryfiEnumerateBechaviourAndReset(inputCount);

            AssertCorrectEnumeratorBehaviour(testedAction().GetEnumerator());
            StubCollection.VeryfiEnumerateBechaviourAndReset(inputCount);

            Assert.Throws<NotImplementedException>(() => testedAction().GetEnumerator().Reset());
        }

        public void AssertEarlyBreakIEnumerableBehaviour(Func<IEnumerable<int>> testedAction, int inputCount, int breakAfter)
        {
            StubCollection.ResetStatistics();

            var result = testedAction();

            Assert.AreEqual(Math.Min(inputCount, breakAfter), result.Count());
            StubCollection.VeryfiEnumerateBechaviourAfterEarlyBreakAndReset(inputCount, breakAfter);

            Assert.AreEqual(Math.Min(inputCount, breakAfter), Enumerate(testedAction()).count);
            StubCollection.VeryfiEnumerateBechaviourAfterEarlyBreakAndReset(inputCount, breakAfter);

            AssertCorrectEnumeratorBehaviour(testedAction().GetEnumerator());
            StubCollection.VeryfiEnumerateBechaviourAfterEarlyBreakAndReset(inputCount, breakAfter);

            Assert.Throws<NotImplementedException>(() => testedAction().GetEnumerator().Reset());
        }

        private static void AssertCorrectEnumeratorBehaviour(IEnumerator<int> tested)
        {
            using (tested)
            {
                while (tested.MoveNext())
                {
                    Assert.AreEqual(tested.Current, tested.Current);
                }

                for (int i = 0; i < 3; i++)
                {
                    Assert.False(tested.MoveNext(), "tested.MoveNext()");

                    Assert.AreEqual(tested.Current, tested.Current);
                }
            }
            
            Assert.False(tested.MoveNext(), "tested.MoveNext()");
            Assert.AreEqual(tested.Current, tested.Current);

            tested.Dispose(); // double Dispose should broke nothing

            Assert.False(tested.MoveNext(), "tested.MoveNext()");
            Assert.AreEqual(tested.Current, tested.Current);
        }

        private (int count, int sum) Enumerate(IEnumerable<int> x)
        {
            var sum = 0;
            var count = 0;
            foreach (var i in x)
            {
                count++;
                sum += i;
            }
            
            return (count, sum);
        }

        public sealed class StubCollection : IEnumerable<int>
        {
            private static int _getEnumeratorInvokeCount;
            private static int _moveNextInvokeCount;
            private static int _getCurrentInvokeCount;
            private static int _disposeInvokeCount;

            private readonly int _count;

            public static void VeryfiEnumerateBechaviourAndReset(int count)
            {
                try
                {
                    Assert.AreEqual(1, _getEnumeratorInvokeCount, "getEnumeratorInvokeCount");
                    Assert.AreEqual(count + 1, _moveNextInvokeCount, "moveNextInvokeCount");
                    Assert.AreEqual(count, _getCurrentInvokeCount, "getCurrentInvokeCount");
                    Assert.AreEqual(1, _disposeInvokeCount, "disposeInvokeCount");
                }
                finally
                {
                    ResetStatistics();
                }
            }

            public static void VeryfiEnumerateBechaviourAfterEarlyBreakAndReset(int count, int breakAfter)
            {
                try
                {
                    Assert.AreEqual(1, _getEnumeratorInvokeCount, "getEnumeratorInvokeCount");
                    Assert.AreEqual(Math.Min(count, breakAfter) + 1, _moveNextInvokeCount, "moveNextInvokeCount");
                    Assert.AreEqual(Math.Min(count, breakAfter) + (count <= breakAfter ? 0 : 1), _getCurrentInvokeCount, "getCurrentInvokeCount");
                    Assert.AreEqual(1, _disposeInvokeCount, "disposeInvokeCount");
                }
                finally
                {
                    ResetStatistics();
                }
            }

            public static void ResetStatistics()
            {
                _getEnumeratorInvokeCount = 0;
                _moveNextInvokeCount = 0;
                _getCurrentInvokeCount = 0;
                _disposeInvokeCount = 0;
            }

            public StubCollection(int count)
            {
                _count = count;
            }

            public IEnumerator<int> GetEnumerator()
            {
                _getEnumeratorInvokeCount++;

                return new StubCollectionEnumerator(_count);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public sealed class StubCollectionEnumerator : IEnumerator<int>
            {
                private readonly int _count;
                private int _current;

                public StubCollectionEnumerator(int count)
                {
                    _count = count;
                }

                public void Dispose()
                {
                    _disposeInvokeCount++;
                }

                public bool MoveNext()
                {
                    _moveNextInvokeCount++;

                    return _current++ < _count;
                }

                public void Reset()
                {
                    throw new NotImplementedException();
                }

                public int Current
                {
                    get
                    {
                        _getCurrentInvokeCount++;

                        return 0;
                    }
                }

                object IEnumerator.Current => Current;
            }
        }
    }
}
