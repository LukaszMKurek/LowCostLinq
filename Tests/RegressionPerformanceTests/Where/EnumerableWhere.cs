﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using LowCostLinq;

namespace PerformanceTests
{
    public class EnumerableArrayWhere<T> : EnumerableWhereBase<T>
    {
        protected override IEnumerable<T> _collection => EnumerableArray[CollectionSize];
    }

    public class EnumerableListWhere<T> : EnumerableWhereBase<T>
    {
        protected override IEnumerable<T> _collection => EnumerableList[CollectionSize];
    }

    public class EnumerableReadonlyCollectionWhere<T> : EnumerableWhereBase<T>
    {
        protected override IEnumerable<T> _collection => EnumerableReadonlyCollection[CollectionSize];
    }

    public abstract class EnumerableWhereBase<T> : BaseBenchmark<T>
    {
        protected abstract IEnumerable<T> _collection { get; }

        [Benchmark]
        public int LINQ()
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
        public int LinqCount()
        {
            var collection = _collection;
            var enumerable = collection.Where(i => true);
            return enumerable.Count();
        }

        [Benchmark]
        public T[] LinqToArray()
        {
            var collection = _collection;
            var enumerable = collection.Where(i => true);
            return enumerable.ToArray();
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
        public int LowCostLinqWithDelegateCount()
        {
            var collection = _collection;
            var newLinq = collection.AsLowCostLinq().Where(i => true);
            return newLinq.Count();
        }

        [Benchmark]
        public T[] LowCostLinqWithDelegateToArray()
        {
            var collection = _collection;
            var enumerable = collection.AsLowCostLinq().Where(i => true);
            return enumerable.ToArray();
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
        public int LowCostLinqWithoutChecksWithDelegateCount()
        {
            var collection = _collection;
            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(i => true);
            return newLinq.Count();
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
        public int LowCostLinqWithStructWhereCount()
        {
            var collection = _collection;
            var newLinq = collection.AsLowCostLinq().Where(new SimpleFilter1());
            return newLinq.Count();
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
        public int LowCostLinqWithoutChecksWithStructWhereCount()
        {
            var collection = _collection;
            var newLinq = collection.AsLowCostLinqWithoutChecks().Where(new SimpleFilter1());
            return newLinq.Count();
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

        [Benchmark(Baseline = true)]
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