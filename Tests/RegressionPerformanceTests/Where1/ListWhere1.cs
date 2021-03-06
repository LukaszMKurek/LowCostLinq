﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    public class ListWhere1Int : ListWhere1<int>
    { }

    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class ListWhere1<T> : BaseBenchmark<T>
    {
        private List<T> _collection => List[CollectionSize.Value];

        [Benchmark]
        public int Linq()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.Where(i => true);
            foreach (var item in enumerable)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithDelegate()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinq().Where(i => true);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithDelegate()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithDelegate2()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinq().Where(true, (param, i) => param);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithDelegate2()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(true, (param, i) => param);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithStructWhere()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinq().Where(new SimpleFilter1());
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithStructWhere()
        {
            int x = 0;
            var collection = _collection;

            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithDelegateCastToIEnumerable()
        {
            int x = 0;
            var collection = _collection;

            IEnumerable<T> newLinq = collection.AsLowCostLinq().Where(i => true);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithDelegateCastToIEnumerable()
        {
            int x = 0;
            var collection = _collection;

            IEnumerable<T> newLinq = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithStructFilterCastToIEnumerable()
        {
            int x = 0;
            var collection = _collection;

            IEnumerable<T> newLinq = collection.AsLowCostLinq().Filter<T, SimpleFilter1>(new SimpleFilter1());
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable()
        {
            int x = 0;
            var collection = _collection;

            IEnumerable<T> newLinq = collection.AsLowCostLinqWithoutChecks().Filter<T, SimpleFilter1>(new SimpleFilter1());
            foreach (var item in newLinq)
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LinqCount()
        {
            var collection = _collection;

            var enumerable = collection.Where(i => true);
            return enumerable.Count();
        }

        [Benchmark]
        public int LowCostLinqWithDelegateCount()
        {
            var collection = _collection;

            var newLinq = collection.AsLowCostLinq().Where(i => true);
            return newLinq.Count();
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithDelegateCount()
        {
            var collection = _collection;

            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            return newLinq.Count();
        }

        [Benchmark]
        public int LowCostLinqWithStructWhereCount()
        {
            var collection = _collection;

            var newLinq = collection.AsLowCostLinq().Where(new SimpleFilter1());
            return newLinq.Count();
        }

        [Benchmark]
        public int LowCostLinqWithoutChecksWithStructWhereCount()
        {
            var collection = _collection;

            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            return newLinq.Count();
        }

        [Benchmark]
        public T[] LinqToArray()
        {
            var collection = _collection;

            var enumerable = collection.Where(i => true);
            return enumerable.ToArray();
        }
        
        [Benchmark]
        public T[] LowCostLinqWithDelegateToArray()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(i => true);
            return enumerable.ToArray();
        }

        [Benchmark]
        public T[] LowCostLinqWithoutChecksWithDelegateToArray()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            return enumerable.ToArray();
        }

        [Benchmark]
        public T[] LowCostLinqWithStructToArray()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(new SimpleFilter1());
            return enumerable.ToArray();
        }

        [Benchmark]
        public T[] LowCostLinqWithoutChecksWithStructToArray()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            return enumerable.ToArray();
        }

        [Benchmark]
        public int Take()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.Where(i => true);
            foreach (var item in enumerable.Take(20))
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostTake()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(i => true);
            foreach (var item in enumerable.Take(20))
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostTakeWithoutChecks()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            foreach (var item in enumerable.Take(20))
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostTakeWithStruct()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(new SimpleFilter1());
            foreach (var item in enumerable.Take(20))
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public int LowCostTakeWithStructWithoutChecks()
        {
            int x = 0;
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            foreach (var item in enumerable.Take(20))
            {
                x++;
            }

            return x;
        }

        [Benchmark]
        public T SkipTakeSingle()
        {
            var collection = _collection;

            var enumerable = collection.Where(i => true);
            return enumerable.Skip(20).Take(1).SingleOrDefault();
        }

        [Benchmark]
        public T LowCostSkipTakeSingle()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(i => true);
            return enumerable.Skip(20).Take(1).SingleOrDefault();
        }

        [Benchmark]
        public T LowCostSkipTakeSingleWithoutChecks()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            return enumerable.Skip(20).Take(1).SingleOrDefault();
        }

        [Benchmark]
        public T LowCostSkipTakeSingleWithStruct()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinq().Where(new SimpleFilter1());
            return enumerable.Skip(20).Take(1).SingleOrDefault();
        }

        [Benchmark]
        public T LowCostSkipTakeSingleWithStructWithoutChecks()
        {
            var collection = _collection;

            var enumerable = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            return enumerable.Skip(20).Take(1).SingleOrDefault();
        }

        [Benchmark]
        public int ForeachDelegate()
        {
            int x = 0;
            Func<T, bool> condition = i => true;
            var collection = _collection;

            foreach (var item in collection)
            {
                if (condition(item))
                    x++;
            }

            return x;
        }

        [Benchmark]
        public int Foreach()
        {
            int x = 0;
            var collection = _collection;

            foreach (var item in collection)
            {
                x++;
            }

            return x;
        }

        [Benchmark(Baseline = true)]
        public int For()
        {
            int x = 0;
            var collection = _collection;

            for (var index = 0; index < collection.Count; index++)
            {
                //var item = _collection[index];
                x++;
            }

            return x;
        }

        public /*readonly*/ struct SimpleFilter1 : IFilter<T, T> //todo dotnet benchmark sobie nie radzi!!!
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Filter(ref T input, out T output, ref bool willBreak)
            {
                output = input;
                return true;
            }
        }
    }
}