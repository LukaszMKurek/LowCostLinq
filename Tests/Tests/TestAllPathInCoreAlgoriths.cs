using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class TestAllPathInCoreAlgoriths
    {
        public static readonly List<int[][]> TestCasesArray = new List<int[][]>();
        public static readonly List<int>[][] TestCasesList;
        public static readonly IEnumerable<int>[][] TestCasesIEnumerable;

        static TestAllPathInCoreAlgoriths()
        {
            var possibleValues = new[] { 1, 2, 3, 4, 5, 6, 7, 11, 12, 13, 14, 15, 16, 17 };

            TestCasesArray.Add(new[] { new int[0] });

            foreach (var pv in possibleValues)
            {
                TestCasesArray.Add(new[] { new[] { pv } });
            }

            foreach (var pv1 in possibleValues)
            foreach (var pv2 in possibleValues)
            {
                TestCasesArray.Add(new[] { new[] { pv1, pv2 } });
            }

            foreach (var pv1 in possibleValues)
            foreach (var pv2 in possibleValues)
            foreach (var pv3 in possibleValues)
            {
                TestCasesArray.Add(new[] { new[] { pv1, pv2, pv3 } });
            }

            TestCasesList = TestCasesArray
                .Select(i => new[] { i[0].ToList() })
                .ToArray();

            TestCasesIEnumerable = TestCasesArray
                .Select(i => new[] { (IEnumerable<int>)i[0] })
                .Union(TestCasesList)
                .Union(TestCasesArray.Select(i => new IEnumerable<int>[] { new HashSet<int>(i[0]) }))
                .Union(TestCasesArray.Select(i => new IEnumerable<int>[] { new ReadOnlyCollection<int>(i[0]) }))
                .ToArray();
        }

        [TestCaseSource(nameof(TestCasesArray))]
        public void TestAllPathInCoreAlgorithsForArray(int[] input)
        {
            //Console.WriteLine(string.Join(", ", input));

            var testedEnumerable0 = input.AsLowCostLinq();
            AssertThatResultCorespondingModel(input.ToList(), testedEnumerable0, testedEnumerable0.ToArray(), testedEnumerable0.FirstOrDefault());

            var testedEnumerable1 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11));
            AssertThatResultCorespondingModel(GetExpectedOutput1(input), testedEnumerable1, testedEnumerable1.ToArray(), testedEnumerable1.FirstOrDefault());

            var testedEnumerable2 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12));
            AssertThatResultCorespondingModel(GetExpectedOutput2(input), testedEnumerable2, testedEnumerable2.ToArray(), testedEnumerable2.FirstOrDefault());

            var testedEnumerable3 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13));
            AssertThatResultCorespondingModel(GetExpectedOutput3(input), testedEnumerable3, testedEnumerable3.ToArray(), testedEnumerable3.FirstOrDefault());

            var testedEnumerable4 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14));
            AssertThatResultCorespondingModel(GetExpectedOutput4(input), testedEnumerable4, testedEnumerable4.ToArray(), testedEnumerable4.FirstOrDefault());

            var testedEnumerable5 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15));
            AssertThatResultCorespondingModel(GetExpectedOutput5(input), testedEnumerable5, testedEnumerable5.ToArray(), testedEnumerable5.FirstOrDefault());

            var testedEnumerable6 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15))
                .Filter<int, TestFilter>(new TestFilter(6, 16));
            AssertThatResultCorespondingModel(GetExpectedOutput6(input), testedEnumerable6, testedEnumerable6.ToArray(), testedEnumerable6.FirstOrDefault());
        }

        [TestCaseSource(nameof(TestCasesList))]
        public void TestAllPathInCoreAlgorithsForList(List<int> input)
        {
            //Console.WriteLine(string.Join(", ", input));

            var testedEnumerable0 = input.AsLowCostLinq();
            AssertThatResultCorespondingModel(input.ToList(), testedEnumerable0, testedEnumerable0.ToArray(), testedEnumerable0.FirstOrDefault());

            var testedEnumerable1 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11));
            AssertThatResultCorespondingModel(GetExpectedOutput1(input), testedEnumerable1, testedEnumerable1.ToArray(), testedEnumerable1.FirstOrDefault());

            var testedEnumerable2 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12));
            AssertThatResultCorespondingModel(GetExpectedOutput2(input), testedEnumerable2, testedEnumerable2.ToArray(), testedEnumerable2.FirstOrDefault());

            var testedEnumerable3 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13));
            AssertThatResultCorespondingModel(GetExpectedOutput3(input), testedEnumerable3, testedEnumerable3.ToArray(), testedEnumerable3.FirstOrDefault());

            var testedEnumerable4 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14));
            AssertThatResultCorespondingModel(GetExpectedOutput4(input), testedEnumerable4, testedEnumerable4.ToArray(), testedEnumerable4.FirstOrDefault());

            var testedEnumerable5 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15));
            AssertThatResultCorespondingModel(GetExpectedOutput5(input), testedEnumerable5, testedEnumerable5.ToArray(), testedEnumerable5.FirstOrDefault());

            var testedEnumerable6 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15))
                .Filter<int, TestFilter>(new TestFilter(6, 16));
            AssertThatResultCorespondingModel(GetExpectedOutput6(input), testedEnumerable6, testedEnumerable6.ToArray(), testedEnumerable6.FirstOrDefault());
        }

        [TestCaseSource(nameof(TestCasesList))]
        public void TestAllPathInCoreAlgorithsForListWithoutListVersionCheckDuringEnumeration(List<int> input)
        {
            //Console.WriteLine(string.Join(", ", input));

            var testedEnumerable0 = input.AsLowCostLinqWithoutChecks();
            AssertThatResultCorespondingModel(input.ToList(), testedEnumerable0, testedEnumerable0.ToArray(), testedEnumerable0.FirstOrDefault());

            var testedEnumerable1 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11));
            AssertThatResultCorespondingModel(GetExpectedOutput1(input), testedEnumerable1, testedEnumerable1.ToArray(), testedEnumerable1.FirstOrDefault());

            var testedEnumerable2 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12));
            AssertThatResultCorespondingModel(GetExpectedOutput2(input), testedEnumerable2, testedEnumerable2.ToArray(), testedEnumerable2.FirstOrDefault());

            var testedEnumerable3 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13));
            AssertThatResultCorespondingModel(GetExpectedOutput3(input), testedEnumerable3, testedEnumerable3.ToArray(), testedEnumerable3.FirstOrDefault());

            var testedEnumerable4 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14));
            AssertThatResultCorespondingModel(GetExpectedOutput4(input), testedEnumerable4, testedEnumerable4.ToArray(), testedEnumerable4.FirstOrDefault());

            var testedEnumerable5 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15));
            AssertThatResultCorespondingModel(GetExpectedOutput5(input), testedEnumerable5, testedEnumerable5.ToArray(), testedEnumerable5.FirstOrDefault());

            var testedEnumerable6 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15))
                .Filter<int, TestFilter>(new TestFilter(6, 16));
            AssertThatResultCorespondingModel(GetExpectedOutput6(input), testedEnumerable6, testedEnumerable6.ToArray(), testedEnumerable6.FirstOrDefault());
        }

        // ReSharper disable PossibleMultipleEnumeration
        [TestCaseSource(nameof(TestCasesIEnumerable))]
        public void TestAllPathInCoreAlgorithsForEnumerable(IEnumerable<int> input)
        {
            //Console.WriteLine(string.Join(", ", input));

            var testedEnumerable0 = input.AsLowCostLinq();
            AssertThatResultCorespondingModel(input.ToList(), testedEnumerable0, testedEnumerable0.ToArray(), testedEnumerable0.FirstOrDefault());

            var testedEnumerable1 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11));
            AssertThatResultCorespondingModel(GetExpectedOutput1(input), testedEnumerable1, testedEnumerable1.ToArray(), testedEnumerable1.FirstOrDefault());

            var testedEnumerable2 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12));
            AssertThatResultCorespondingModel(GetExpectedOutput2(input), testedEnumerable2, testedEnumerable2.ToArray(), testedEnumerable2.FirstOrDefault());

            var testedEnumerable3 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13));
            AssertThatResultCorespondingModel(GetExpectedOutput3(input), testedEnumerable3, testedEnumerable3.ToArray(), testedEnumerable3.FirstOrDefault());

            var testedEnumerable4 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14));
            AssertThatResultCorespondingModel(GetExpectedOutput4(input), testedEnumerable4, testedEnumerable4.ToArray(), testedEnumerable4.FirstOrDefault());

            var testedEnumerable5 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15));
            AssertThatResultCorespondingModel(GetExpectedOutput5(input), testedEnumerable5, testedEnumerable5.ToArray(), testedEnumerable5.FirstOrDefault());

            var testedEnumerable6 = input.AsLowCostLinq()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15))
                .Filter<int, TestFilter>(new TestFilter(6, 16));
            AssertThatResultCorespondingModel(GetExpectedOutput6(input), testedEnumerable6, testedEnumerable6.ToArray(), testedEnumerable6.FirstOrDefault());
        }

        [TestCaseSource(nameof(TestCasesIEnumerable))]
        public void TestAllPathInCoreAlgorithsForEnumerableWithoutListVersionCheckDuringEnumeration(IEnumerable<int> input)
        {
            //Console.WriteLine(string.Join(", ", input));

            var testedEnumerable0 = input.AsLowCostLinqWithoutChecks();
            AssertThatResultCorespondingModel(input.ToList(), testedEnumerable0, testedEnumerable0.ToArray(), testedEnumerable0.FirstOrDefault());

            var testedEnumerable1 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11));
            AssertThatResultCorespondingModel(GetExpectedOutput1(input), testedEnumerable1, testedEnumerable1.ToArray(), testedEnumerable1.FirstOrDefault());

            var testedEnumerable2 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12));
            AssertThatResultCorespondingModel(GetExpectedOutput2(input), testedEnumerable2, testedEnumerable2.ToArray(), testedEnumerable2.FirstOrDefault());

            var testedEnumerable3 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13));
            AssertThatResultCorespondingModel(GetExpectedOutput3(input), testedEnumerable3, testedEnumerable3.ToArray(), testedEnumerable3.FirstOrDefault());

            var testedEnumerable4 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14));
            AssertThatResultCorespondingModel(GetExpectedOutput4(input), testedEnumerable4, testedEnumerable4.ToArray(), testedEnumerable4.FirstOrDefault());

            var testedEnumerable5 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15));
            AssertThatResultCorespondingModel(GetExpectedOutput5(input), testedEnumerable5, testedEnumerable5.ToArray(), testedEnumerable5.FirstOrDefault());

            var testedEnumerable6 = input.AsLowCostLinqWithoutChecks()
                .Filter<int, TestFilter>(new TestFilter(1, 11))
                .Filter<int, TestFilter>(new TestFilter(2, 12))
                .Filter<int, TestFilter>(new TestFilter(3, 13))
                .Filter<int, TestFilter>(new TestFilter(4, 14))
                .Filter<int, TestFilter>(new TestFilter(5, 15))
                .Filter<int, TestFilter>(new TestFilter(6, 16));
            AssertThatResultCorespondingModel(GetExpectedOutput6(input), testedEnumerable6, testedEnumerable6.ToArray(), testedEnumerable6.FirstOrDefault());
        }

        private void AssertThatResultCorespondingModel(List<int> model, IEnumerable<int> testedEnumerable, int[] testedArray, int firstOfDefault)
        {
            var array = testedEnumerable.ToArray();

            Assert.AreEqual(model.Count, array.Length, "Lenght Enumerable");
            Assert.AreEqual(model.Count, testedArray.Length, "Lenght ToArray");

            for (var index = 0; index < model.Count; index++)
            {
                var item = model[index];

                Assert.AreEqual(item, array[index], "Item equal Enumerable");
                Assert.AreEqual(item, testedArray[index], "Item equal ToArray");
            }

            Assert.AreEqual(model.FirstOrDefault(), firstOfDefault, "firstOfDefault");
        }

        internal readonly struct TestFilter : IFilter<int, int>
        {
            private readonly int _filterOnNum;
            private readonly int _breakOnNum;

            public TestFilter(int filterOnNum, int breakOnNum)
            {
                _filterOnNum = filterOnNum;
                _breakOnNum = breakOnNum;
            }

            public bool Filter(ref int input, out int output, ref bool willBreak)
            {
                output = input;

                if (input == _filterOnNum)
                    return false;

                if (input == _breakOnNum)
                {
                    willBreak = true;
                    return false;
                }

                return true;
            }
        }

        private List<int> GetExpectedOutput1(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }

        private List<int> GetExpectedOutput2(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                if (item == 2)
                    continue;

                if (item == 12)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }

        private List<int> GetExpectedOutput3(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                if (item == 2)
                    continue;

                if (item == 12)
                {
                    break;
                }

                if (item == 3)
                    continue;

                if (item == 13)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }

        private List<int> GetExpectedOutput4(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                if (item == 2)
                    continue;

                if (item == 12)
                {
                    break;
                }

                if (item == 3)
                    continue;

                if (item == 13)
                {
                    break;
                }

                if (item == 4)
                    continue;

                if (item == 14)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }

        private List<int> GetExpectedOutput5(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                if (item == 2)
                    continue;

                if (item == 12)
                {
                    break;
                }

                if (item == 3)
                    continue;

                if (item == 13)
                {
                    break;
                }

                if (item == 4)
                    continue;

                if (item == 14)
                {
                    break;
                }

                if (item == 5)
                    continue;

                if (item == 15)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }

        private List<int> GetExpectedOutput6(IEnumerable<int> input)
        {
            var list = new List<int>();

            foreach (var item in input)
            {
                if (item == 1)
                    continue;

                if (item == 11)
                {
                    break;
                }

                if (item == 2)
                    continue;

                if (item == 12)
                {
                    break;
                }

                if (item == 3)
                    continue;

                if (item == 13)
                {
                    break;
                }

                if (item == 4)
                    continue;

                if (item == 14)
                {
                    break;
                }

                if (item == 5)
                    continue;

                if (item == 15)
                {
                    break;
                }

                if (item == 6)
                    continue;

                if (item == 16)
                {
                    break;
                }

                list.Add(item);
            }

            return list;
        }
    }
}