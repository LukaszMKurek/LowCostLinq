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
    public readonly struct LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut> : IEnumerable<TOut>
        where TCollectionWrapper : struct, ICollectionWrapper<TIn>, ICollectionWrapper<TIn, TCollectionIterator>
        where TCollectionIterator : struct, ICollectionIterator<TIn>
        where TFilter1 : struct, IFilter<TIn, TOut>
    {
        private readonly TCollectionWrapper _collection;
        private readonly TFilter1 _filter1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal LowCostLinq(in TCollectionWrapper collection, in TFilter1 filter1)
        {
            _collection = collection;
            _filter1 = filter1;
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Enumerator : IEnumerator<TOut>
        {
            private TCollectionIterator _iterator;
            private TFilter1 _filter1;
            private TOut _current;
            private bool _work;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Enumerator(in TCollectionWrapper collection, in TFilter1 filter1)
            {
                _iterator = collection.GetIteratorWrapper();
                _filter1 = filter1;
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
                        bool willBreak = false; // maby is way that we not need 2 variable willBreak and _work - curently it is not efficient

                        if (_filter1.Filter(ref input, out _current, ref willBreak))
                        {
                            return true;
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
            return new Enumerator(_collection, _filter1);
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
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, Where<TOut>, TOut> Where(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var filter2 = new Where<TOut>(@where);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, Where<TOut>, TOut>(_collection, _filter1, filter2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, WhereParam<TParam, TOut>, TOut> Where<TParam>(TParam param, Func<TParam, TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var filter2 = new WhereParam<TParam, TOut>(param, @where);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, WhereParam<TParam, TOut>, TOut>(_collection, _filter1, filter2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, Select<TOut, TOutNext>, TOutNext> Select<TOutNext>(Func<TOut, TOutNext> @select)
        {
            if (@select == null) ThrowHelper.SelectDelegateIsNull();

            var filter2 = new Select<TOut, TOutNext>(@select);
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, Select<TOut, TOutNext>, TOutNext>(_collection, _filter1, filter2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TFilter, TOut> Where<TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<TOut, TOut>
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TFilter, TOut>(_collection, _filter1, filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TFilter, TOutNext> Filter<TOutNext, TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<TOut, TOutNext>
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TFilter, TOutNext>(_collection, _filter1, filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TakeN<TOut>, TOut> Take(int n)
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TakeN<TOut>, TOut>(_collection, _filter1, new TakeN<TOut>(n));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TakeWhile<TOut>, TOut> TakeWhile(Func<TOut, bool> @while)
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, TakeWhile<TOut>, TOut>(_collection, _filter1, new TakeWhile<TOut>(@while));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, SkipN<TOut>, TOut> Skip(int n)
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, SkipN<TOut>, TOut>(_collection, _filter1, new SkipN<TOut>(n));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, SkipWhile<TOut>, TOut> SkipWhile(Func<TOut, bool> @while)
        {
            return new LowCostLinq<TIn, TCollectionWrapper, TCollectionIterator, TFilter1, TOut, SkipWhile<TOut>, TOut>(_collection, _filter1, new SkipWhile<TOut>(@while));
        }

        /*//[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Iterate<TAcc>(ref TAcc acc) where TAcc : struct, IAccumulator<TOut>
        {
            using (var iterator = _collection.GetIteratorWrapper()) // using psuje wydajność 
            {
                var filter1 = _filter1;

                TIn input = default;
                int currentIndex = 0;
                bool willBreak = false;

                while (iterator.MoveNext(ref input, currentIndex))
                {
                    currentIndex++;

                    if (filter1.Filter(ref input, out var current, ref willBreak))
                    {
                        willBreak = acc.Accumulate(ref current);
                    }

                    if (willBreak)
                        break;
                    
                }
            }
        }*/

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            var acc = new CountAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, CountAccumulator<TOut>>(_filter1, ref acc);
            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new CountWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, CountWhereAccumulator<TOut>>(_filter1, ref acc);

            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut First()
        {
            var acc = new FirstWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, FirstWithFlagAccumulator<TOut>>(_filter1, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut FirstOrDefault()
        {
            var acc = new FirstWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, FirstWithFlagAccumulator<TOut>>(_filter1, ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut First(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, FirstWithFlagWhereAccumulator<TOut>>(_filter1, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut FirstOrDefault(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, FirstWithFlagWhereAccumulator<TOut>>(_filter1, ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Single()
        {
            var acc = new SingleWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, SingleWithFlagAccumulator<TOut>>(_filter1, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut SingleOrDefault()
        {
            var acc = new SingleWithFlagAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, SingleWithFlagAccumulator<TOut>>(_filter1, ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Single(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, SingleWithFlagWhereAccumulator<TOut>>(_filter1, ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut SingleOrDefault(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, SingleWithFlagWhereAccumulator<TOut>>(_filter1, ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            var acc = new AnyAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, AnyAccumulator<TOut>>(_filter1, ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AnyWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, AnyWhereAccumulator<TOut>>(_filter1, ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<TOut, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AllWhereAccumulator<TOut>(@where);
            _collection.Iterate<TFilter1, TOut, AllWhereAccumulator<TOut>>(_filter1, ref acc);

            return acc.All;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut[] ToArray()
        {
            var acc = new ToArrayAccumulator<TOut>();
            _collection.Iterate<TFilter1, TOut, ToArrayAccumulator<TOut>>(_filter1, ref acc);

            return acc.ToArray();
        }
    }
}