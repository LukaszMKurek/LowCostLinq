using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    //[DisassemblyDiagnoser(printAsm: true, printSource: true)]
    // [ClrJob, CoreJob, LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [MemoryDiagnoser]
    public class Example5
    {
        private const int Iterations = 10000;
        private const int ArraySize = 10;
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
                    .Where(i => i != 1);

                foreach (var item in result)
                {
                    preventOptimize |= item;
                }
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
                    .Where(i => i != 1);

                foreach (var item in result)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }

        [Benchmark]
        public int ShortLowCostLinqExample()
        {
            var collection = _array;
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var result = collection
                    .LowCostWhere(i => i != 0) // less code, less jitting
                    .Where(i => i != 1);

                foreach (var item in result)
                {
                    preventOptimize |= item;
                }
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
                    .Where(Items.AreNotEqualTo(0))
                    .Where(Items.AreNotEqualTo(1));

                foreach (var item in result)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }

        [Benchmark]
        public int NearOptimalSolutionUsingDelegates()
        {
            var collection = _array;
            Func<int, bool> filter1 = x => x != 0;
            Func<int, bool> filter2 = x => x != 1;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                foreach (var item in collection)
                {
                    if (filter1(item) && filter2(item))
                    {
                        preventOptimize |= item;
                    }
                }
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
                foreach (var item in collection)
                {
                    if (item != 0 && item != 1)
                    {
                        preventOptimize |= item;
                    }
                }
            }

            return preventOptimize;
        }
    }
}
