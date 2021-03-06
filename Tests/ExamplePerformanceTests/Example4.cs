﻿using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    //[DisassemblyDiagnoser(printAsm: true, printSource: true)]
    // [ClrJob, CoreJob, LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [MemoryDiagnoser]
    public class Example4
    {
        private const int Iterations = 10000;
        private const int ArraySize = 100;
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
                int p1 = n;
                int p2 = n;
                int p3 = n;
                int p4 = n;

                var result = collection
                    .Where(i => i != p1)
                    .Where(i => i != p2)
                    .Where(i => i != p3)
                    .Where(i => i != p4);

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
                int p1 = n;
                int p2 = n;
                int p3 = n;
                int p4 = n;

                var result = collection.AsLowCostLinq()
                    .Where(i => i != p1)
                    .Where(i => i != p2)
                    .Where(i => i != p3)
                    .Where(i => i != p4);

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
                int p1 = n;
                int p2 = n;
                int p3 = n;
                int p4 = n;

                var result = collection.AsLowCostLinq()
                    .Where(p1, (param, i) => i != param) // we use cached delegate(cache is generated by compiler) so delegate is not allocated and closure is not allocated every times
                    .Where(p2, (param, i) => i != param)
                    .Where(p3, (param, i) => i != param)
                    .Where(p4, (param, i) => i != param);

                foreach (var item in result)
                {
                    preventOptimize |= item;
                }
            }

            return preventOptimize;
        }

        [Benchmark]
        public int BestLowCostLinqExample()
        {
            var collection = _array;
            int preventOptimize = 0;

            for (int n = 0; n < Iterations; n++)
            {
                var result = collection.AsLowCostLinq()
                    .Where(Items.AreNotEqualTo(0))
                    .Where(Items.AreNotEqualTo(1))
                    .Where(Items.AreNotEqualTo(2))
                    .Where(Items.AreNotEqualTo(3));

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
            Func<int, bool> filter3 = x => x != 2;
            Func<int, bool> filter4 = x => x != 3;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                foreach (var item in collection)
                {
                    if (filter1(item) && filter2(item) && filter3(item) && filter4(item))
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
                    if (item != 0 && item != 1 && item != 2 && item != 3)
                    {
                        preventOptimize |= item;
                    }
                }
            }

            return preventOptimize;
        }
    }
}