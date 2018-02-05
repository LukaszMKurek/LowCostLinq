using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    //[DisassemblyDiagnoser(printAsm: true, printSource: true)]
    // [ClrJob, CoreJob, LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [MemoryDiagnoser]
    public class Example6
    {
        private const int Iterations = 10000;
        private const int Count = 100;

        [Benchmark]
        public int LinqExample()
        {
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var enumerable = Enumerable.Range(0, Count).Where(i => i != 23);
                foreach (var item in enumerable)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }

        [Benchmark]
        public int LowCostLinqExample()
        {
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var enumerable = LowCostEnumerable.Range(0, Count).Where(i => i != 23);
                foreach (var item in enumerable)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }
        
        [Benchmark]
        public int EvenBetterLowCostLinqExample()
        {
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var enumerable = LowCostEnumerable.Range(0, Count).Where(Items.AreNotEqualTo(23));
                foreach (var item in enumerable)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }

        [Benchmark]
        public int NearOptimalSolutionUsingDelegates()
        {
            Func<int, bool> filter1 = x => x != 23;

            var preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                for (int item = 0; item < Count; item++)
                {
                    if (filter1(item))
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
            var preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                for (int item = 0; item < Count; item++)
                {
                    if (item != 23)
                    {
                        preventOptimize |= item;
                    }
                }
            }

            return preventOptimize;
        }
    }
}
