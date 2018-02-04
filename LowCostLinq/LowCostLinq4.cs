using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LowCostLinq.Accumulators;
using LowCostLinq.Filters;
using LowCostLinq.Internals;

namespace LowCostLinq
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut> : IEnumerable<TOut>
        where TCollectionWrapper : struct, ICollectionWrapper<TIn>, ICollectionWrapper<TIn, TCollectionIterator>
        where TCollectionIterator : struct, ICollectionIterator<TIn>
        where TFilter1 : struct, IFilter<TIn, TM1>
        where TFilter2 : struct, IFilter<TM1, TM2>
        where TFilter3 : struct, IFilter<TM2, TM3>
        where TFilter4 : struct, IFilter<TM3, TOut>
    {
        private readonly TCollectionWrapper _collection;
        private readonly TFilter1 _filter1;
        private readonly TFilter2 _filter2;
        private readonly TFilter3 _filter3;
        private readonly TFilter4 _filter4;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal LowCostLinq(in TCollectionWrapper collection, in TFilter1 filter1, in TFilter2 filter2, in TFilter3 filter3, in TFilter4 filter4)
        {
            _collection = collection;
            _filter1 = filter1;
            _filter2 = filter2;
            _filter3 = filter3;
            _filter4 = filter4;
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Enumerator : IEnumerator<TOut>
        {
            private TCollectionIterator _iterator;
            private TFilter1 _filter1;
            private TFilter2 _filter2;
            private TFilter3 _filter3;
            private TFilter4 _filter4;
            private TOut _current;
            private bool _work;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Enumerator(in TCollectionWrapper collection, in TFilter1 filter1, in TFilter2 filter2, in TFilter3 filter3, in TFilter4 filter4)
            {
                _iterator = collection.GetIteratorWrapper();
                _filter1 = filter1;
                _filter2 = filter2;
                _filter3 = filter3;
                _filter4 = filter4;
                _current = default;
                _work = true;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext()
            {
                TIn input = default;

                while (_work)
                {
                    if (_iterator.MoveNext(ref input))
                    {
                        bool willBreak = false;

                        if (_filter1.Filter(ref input, out TM1 mid1, ref willBreak))
                        {
                            if (_filter2.Filter(ref mid1, out TM2 mid2, ref willBreak))
                            {
                                if (_filter3.Filter(ref mid2, out TM3 mid3, ref willBreak))
                                {
                                    if (_filter4.Filter(ref mid3, out _current, ref willBreak))
                                    {
                                        return true;
                                    }
                                }
                            }
                        }

                        if (willBreak)
                            break;
                    }
                    else
                        break;
                }

                _work = false;
                Dispose();
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public TOut Current
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return _current; }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //if (_work)
                    _iterator.Dispose();
                //_current = default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator()
        {
            return new Enumerator(_collection, _filter1, _filter2, _filter3, _filter4);
        }

        IEnumerator<TOut> IEnumerable<TOut>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, Where<TOut>, TOut>, TOut> Where(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var w = new Where<TOut>(@where);
            var next = new CombineFilters<TM3, TFilter4, TOut, Where<TOut>, TOut>(_filter4, w);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, Where<TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, WhereParam<TParam, TOut>, TOut>, TOut> Where<TParam>(TParam param, Func<TParam, TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var w = new WhereParam<TParam, TOut>(param, @where);
            var next = new CombineFilters<TM3, TFilter4, TOut, WhereParam<TParam, TOut>, TOut>(_filter4, w);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, WhereParam<TParam, TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, Select<TOut, TOutNext>, TOutNext>, TOutNext> Select<TOutNext>(Func<TOut, TOutNext> @select)
        {
            if (@select == null) ThrowHelper.SelectDelegateIsNull();

            var s = new Select<TOut, TOutNext>(@select);
            var next = new CombineFilters<TM3, TFilter4, TOut, Select<TOut, TOutNext>, TOutNext>(_filter4, s);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, Select<TOut, TOutNext>, TOutNext>, TOutNext>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TFilter, TOut>, TOut> Where<TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<TOut, TOut>
        {
            var next = new CombineFilters<TM3, TFilter4, TOut, TFilter, TOut>(_filter4, filter);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TFilter, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TFilter, TOutNext>, TOutNext> Filter<TOutNext, TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<TOut, TOutNext>
        {
            var next = new CombineFilters<TM3, TFilter4, TOut, TFilter, TOutNext>(_filter4, filter);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TFilter, TOutNext>, TOutNext>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TakeN<TOut>, TOut>, TOut> Take(int n)
        {
            var next = new CombineFilters<TM3, TFilter4, TOut, TakeN<TOut>, TOut>(_filter4, new TakeN<TOut>(n));
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TakeN<TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TakeWhile<TOut>, TOut>, TOut> TakeWhile(Func<TOut, bool> @while)
        {
            if (@while == null) ThrowHelper.TakeWhileDelegateIsNull();

            var next = new CombineFilters<TM3, TFilter4, TOut, TakeWhile<TOut>, TOut>(_filter4, new TakeWhile<TOut>(@while));
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, TakeWhile<TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, SkipN<TOut>, TOut>, TOut> Skip(int n)
        {
            var next = new CombineFilters<TM3, TFilter4, TOut, SkipN<TOut>, TOut>(_filter4, new SkipN<TOut>(n));
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, SkipN<TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, SkipWhile<TOut>, TOut>, TOut> SkipWhile(Func<TOut, bool> @while)
        {
            if (@while == null) ThrowHelper.SkipWhileDelegateIsNull();

            var next = new CombineFilters<TM3, TFilter4, TOut, SkipWhile<TOut>, TOut>(_filter4, new SkipWhile<TOut>(@while));
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, CombineFilters<TM3, TFilter4, TOut, SkipWhile<TOut>, TOut>, TOut>(_collection, _filter1, _filter2, _filter3, next);
        }

        /*private void Iterate<TAcc>(ref TAcc acc) where TAcc : struct, IAccumulator<TOut>
        {
            using (var iterator = _collection.GetIteratorWrapper())
            {
                var filter1 = _filter1;
                var filter2 = _filter2;
                var filter3 = _filter3;
                var filter4 = _filter4;

                TIn input = default;
                int currentIndex = 0;
                bool willBreak = false;

                while (true)
                {
                    if (iterator.MoveNext(ref input, currentIndex))
                    {
                        currentIndex++;

                        if (filter1.Filter(ref input, out var mid1, ref willBreak))
                        {
                            if (filter2.Filter(ref mid1, out var mid2, ref willBreak))
                            {
                                if (filter3.Filter(ref mid2, out var mid3, ref willBreak))
                                {
                                    if (filter4.Filter(ref mid3, out var output, ref willBreak))
                                    {
                                        willBreak = acc.Accumulate(ref output);
                                    }
                                }
                            }
                        }

                        if (willBreak)
                            break;
                    }
                    else
                        break;
                }
            }
        }*/

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            var acc = new CountAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, CountAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);
            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new CountWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, CountWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut First()
        {
            var acc = new FirstWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, FirstWithFlagAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut FirstOrDefault()
        {
            var acc = new FirstWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, FirstWithFlagAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut First(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, FirstWithFlagWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut FirstOrDefault(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, FirstWithFlagWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Single()
        {
            var acc = new SingleWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, SingleWithFlagAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut SingleOrDefault()
        {
            var acc = new SingleWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, SingleWithFlagAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Single(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, SingleWithFlagWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut SingleOrDefault(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, SingleWithFlagWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            var acc = new AnyAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, AnyAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AnyWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, AnyWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AllWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, AllWhereAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.All;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut[] ToArray()
        {
            var acc = new ToArrayAccumulator<TOut>();
            _collection.Iterate<TFilter1, TM1, TFilter2, TM2, TFilter3, TM3, TFilter4, TOut, ToArrayAccumulator<TOut>>(_filter1, _filter2, _filter3, _filter4, ref acc);

            return acc.ToArray();
        }
    }
}