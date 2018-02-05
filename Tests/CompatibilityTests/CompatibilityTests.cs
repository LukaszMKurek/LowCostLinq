using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using LowCostLinq;
using NUnit.Framework;

namespace CompatibilityTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public static readonly int[][][] TestCasesArray =
        {
            new[] { new int[0] },
            new[] { new[] { -1 } },
            new[] { new[] { 0 } },
            new[] { new[] { 1 } },
            new[] { new[] { 2 } },
            new[] { new[] { 3 } },
            new[] { new[] { 4 } },
            new[] { new[] { 8 } },
            new[] { new[] { 0, 0 } },
            new[] { new[] { 0, 1 } },
            new[] { new[] { 0, 2 } },
            new[] { new[] { 0, 3 } },
            new[] { new[] { 0, 4 } },
            new[] { new[] { 0, 5 } },
            new[] { new[] { 0, 8 } },
            new[] { new[] { 0, 0, 0 } },
            new[] { new[] { 11, 11, 11 } },
            new[] { new[] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, Int32.MaxValue, Int32.MinValue } },
            new[] { new[] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 } }
        };

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        protected static void AssertEnumerable(IEnumerable<int> reference, IEnumerable<int> testedEnumerable, int[] testedToArray, int[] testedToArraySecond)
        {
            Test(reference, testedEnumerable);
            Test(reference, testedEnumerable); // test eventual side efects during enumeration
            Test(reference, testedToArray);
            Test(reference, testedToArraySecond); // test eventual side efects during enumeration

            Assert.AreEqual(reference.FirstOrDefault(), testedEnumerable.FirstOrDefault());
            Assert.AreEqual(reference.Count(), testedEnumerable.Count());
            Assert.AreEqual(reference.Count(i => i != 8), testedEnumerable.Count(i => i != 8));
        }

        protected static void Test(IEnumerable<int> reference, IEnumerable<int> tested)
        {
            var a1 = reference.ToArray();
            var a2 = tested.ToArray();

            if (a1.Length != a2.Length)
            {
                /*foreach (var i in a1)
                    Console.Write(i + ", ");*/

                Assert.Fail($"Różna długość: {a1} != {a2}");
            }

            for (int i = 0; i < a1.Length; i++)
            {
                //Console.Write(a1[i] + ", ");

                if (a1[i] != a2[i])
                {
                    Assert.Fail($"Różnice od elementu: {i}");
                }
            }
        }

        protected static void AssertCorrectEnumeratorBehaviour(IEnumerator<int> reference, IEnumerator<int> tested)
        {
            using (reference)
            using (tested)
            {
                while (reference.MoveNext())
                {
                    Assert.True(tested.MoveNext(), "tested.MoveNext()");
                    Assert.AreEqual(reference.Current, tested.Current);
                    Assert.AreEqual(reference.Current, tested.Current); // test eventual side efects
                }

                for (int i = 0; i < 3; i++)
                {
                    Assert.False(reference.MoveNext(), "reference.MoveNext()");
                    Assert.False(tested.MoveNext(), "tested.MoveNext()");

                    // Assert.AreEqual(reference.Current, tested.Current); // we do not must meet this assertion because microssoft implementation do not respect this bechaviour
                }
            }

            Assert.False(reference.MoveNext(), "reference.MoveNext()");
            Assert.False(tested.MoveNext(), "tested.MoveNext()");
        }

        protected static void AssertThatTypeIsImmutableStruct<T>(T t)
            where T : struct
        {
            //Assert.True(Attribute.IsDefined(typeof(T), typeof(System.Runtime.CompilerServices.IsReadOnlyAttribute)), "Struct Must Be Immutable");
            //Assert.True(typeof(T).CustomAttributes.Any(i => i is IsReadOnlyAttribute), "Struct Must Be Immutable");
            // I do not known why abowe asserts not working properly...
            Assert.True(typeof(T).CustomAttributes.Any(i => i.ToString() == "[System.Runtime.CompilerServices.IsReadOnlyAttribute()]"), "Struct Must Be Immutable");
        }

        protected static void AssertThatTypeIsStruct<T>(T t)
            where T : struct
        {
        }

        protected static void AssertLowCostMethod<T>(Func<T> f)
        {
            Assert.AreEqual(typeof(LowCostEnumerable).Assembly.FullName, f.Target.GetType().Assembly.FullName);
        }

        protected static void AssertLowCostMethod<TIn, TOut>(Func<TIn, TOut> f)
        {
            Assert.AreEqual(typeof(LowCostEnumerable).Assembly.FullName, f.Target.GetType().Assembly.FullName);
        }
    }

    public abstract class CompatibilityTests_ArrayBase : BaseTest
    {
        public const string SourceName = nameof(TestCasesArray);
    }

    public abstract class CompatibilityTests_ListBase : BaseTest
    {
        public static readonly List<int>[][] TestCasesList;

        static CompatibilityTests_ListBase()
        {
            TestCasesList = TestCasesArray
                .Select(i => new[] { i[0].ToList() })
                .ToArray();
        }

        public const string SourceName = nameof(TestCasesList);
    }

    public abstract class CompatibilityTests_IEnumerableBase : BaseTest
    {
        public static readonly List<int>[][] TestCasesList;
        public static readonly IEnumerable<int>[][] TestCasesIEnumerable;

        static CompatibilityTests_IEnumerableBase()
        {
            TestCasesList = TestCasesArray
                .Select(i => new[] { i[0].ToList() })
                .ToArray();

            TestCasesIEnumerable = TestCasesArray
                .Select(i => (IEnumerable<int>)i[0])
                .Union(TestCasesList.Select(i => i[0]))
                .Union(TestCasesArray.Select(i => new ReadOnlyCollection<int>(i[0])))
                .Select(i => new[] { i })
                .ToArray();
        }

        public const string SourceName = nameof(TestCasesIEnumerable);
    }
}