using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    //[DisassemblyDiagnoser(printAsm: true, printSource: true)]
    // [ClrJob, CoreJob, LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [MemoryDiagnoser]
    public class Example1
    {
        private const int Iterations = 1000;
        private int[] _array;

        [GlobalSetup]
        public void Setup()
        {
            _array = Enumerable.Range(0, 1000).ToArray();
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
                    .Select(i => i + 2)
                    .Skip(16)
                    .Take(32)
                    .ToArray();

                preventOptimize += result[0];
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
                var result = collection.AsLowCostLinq() // <-- HERE is magic!
                    .Where(i => i != 0)
                    .Select(i => i + 2)
                    .Skip(16)
                    .Take(32)
                    .ToArray();

                preventOptimize += result[0];
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
                var result = collection.AsLowCostLinq() // <-- HERE is magic!
                    .Where(Items.AreNotEqualTo(0)) // <-- HERE is more fantastic magic!
                    .Filter<int, MyUltraFastHelpers.AddTwo>(MyUltraFastHelpers.IncreaseByTwo()) // inference now not work as good as we want
                    .Skip(16)
                    .Take(32)
                    .ToArray();

                preventOptimize += result[0];
            }

            return preventOptimize;
        }

        public static class MyUltraFastHelpers
        {
            public static AddTwo IncreaseByTwo() => new AddTwo();

            public readonly struct AddTwo : IFilter<int, int>
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public bool Filter(ref int input, out int output, ref bool willBreak)
                {
                    output = input + 2;
                    return true;
                }
            }
        }

        [Benchmark]
        public int NearOptimalSolutionUsingDelegates()
        {
            var collection = _array;
            Func<int, bool> filter1 = x => x != 0;
            Func<int, int> select = x => x + 2;
            
            const int toSkip = 16;
            const int toTake = 32;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                int skiped = 0;
                var resultList = new List<int>(32);

                foreach (var item in collection)
                {
                    if (filter1(item))
                    {
                        if (skiped < toSkip)
                        {
                            skiped++;
                            continue;
                        }

                        var mapped = select(item);

                        resultList.Add(mapped);

                        if (resultList.Count == toTake)
                            break;
                    }
                }

                var result = resultList.ToArray(); // not optimal but short to write
                preventOptimize += result[0];
            }

            return preventOptimize;
        }
        
        [Benchmark(Baseline = true)]
        public int NearOptimalSolution()
        {
            var collection = _array;
            const int toSkip = 16;
            const int toTake = 32;

            var preventOptimize = 0;

            for (int i = 0; i < Iterations; i++)
            {
                int skiped = 0;
                int taked = 0;

                var result = new int[toTake + 1];

                foreach (var item in collection)
                {
                    if (item != 0)
                    {
                        if (skiped < toSkip)
                        {
                            skiped++;
                            continue;
                        }

                        result[taked++] = item + 2;

                        if (taked > toTake)
                            break;
                    }
                }
                
                preventOptimize += result[0]; // result not always have 32 element but it was most performant
            }

            return preventOptimize;
        }
    }
}
