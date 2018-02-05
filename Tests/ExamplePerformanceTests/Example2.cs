using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    //[DisassemblyDiagnoser(printAsm: true, printSource: true)]
    // [ClrJob, CoreJob, LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [MemoryDiagnoser]
    public class Example2
    {
        private const int Iterations = 1000;
        private const int ArraySize = 1000;
        private const int SomeMagicNumber = ArraySize / 2;
        private int[] _array;

        [GlobalSetup]
        public void Setup()
        {
            _array = Enumerable.Range(0, ArraySize).ToArray();
        }

        [Benchmark]
        public int LinqExample()
        {
            var collection = _array;
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var result = collection
                    .Where(i => i != 0)
                    .Where(i => i != 1)
                    .Where(i => i != 2)
                    .Where(i => i != 3)
                    .First(i => i > SomeMagicNumber);

                preventOptimize += result;
            }

            return preventOptimize;
        }

        [Benchmark]
        public int LowCostLinqExample()
        {
            var collection = _array;
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var result = collection.AsLowCostLinq()
                    .Where(i => i != 0)
                    .Where(i => i != 1)
                    .Where(i => i != 2)
                    .Where(i => i != 3)
                    .First(i => i > SomeMagicNumber);

                preventOptimize += result;
            }

            return preventOptimize;
        }

        [Benchmark]
        public int EvenBetterLowCostLinqExample()
        {
            var collection = _array;
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var result = collection.AsLowCostLinq()
                    .Where(Items.AreNotEqualTo(0)) // instead delegate, this magic can be inlined during jitting
                    .Where(Items.AreNotEqualTo(1))
                    .Where(Items.AreNotEqualTo(2))
                    .Where(Items.AreNotEqualTo(3))
                    .Where(Items.AreGreatherThan(SomeMagicNumber))
                    .First(); // currently I am going to not implement faster wersion of First. I do not want blow API even more

                preventOptimize += result;
            }

            return preventOptimize;
        }

        [Benchmark]
        public int NearOptimalSolutionUsingDelegates()
        {
            var collection = _array;
            Func<int, bool> filter1 = x => x != 0;
            Func<int, bool> filter2 = x => x != 1;
            Func<int, bool> filter3 = x => x != 2;
            Func<int, bool> filter4 = x => x != 3;
            Func<int, bool> filter5 = x => x > SomeMagicNumber;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                var result = 0;

                foreach (var item in collection)
                {
                    if (filter1(item) && filter2(item) && filter3(item) && filter4(item))
                    {
                        if (filter5(item))
                        {
                            result = item;
                            break;
                        }
                    }
                }

                preventOptimize += result;
            }

            return preventOptimize;
        }

        [Benchmark(Baseline = true)]
        public int NearOptimalSolution()
        {
            var collection = _array;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                var result = 0;

                foreach (var item in collection)
                {
                    if (item != 0 && item != 1 && item != 2 && item != 3)
                    {
                        if (item > SomeMagicNumber)
                        {
                            result = item;
                            break;
                        }
                    }
                }

                preventOptimize += result;
            }

            return preventOptimize;
        }
    }
}