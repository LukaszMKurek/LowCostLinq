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
    public readonly struct LowCostLinq<T, TCollectionWrapper, TCollectionIterator> : IEnumerable<T>
        where TCollectionWrapper : struct, ICollectionWrapper<T>, ICollectionWrapper<T, TCollectionIterator>
        where TCollectionIterator : struct, ICollectionIterator<T>
    {
        private readonly TCollectionWrapper _collection;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal LowCostLinq(in TCollectionWrapper collection)
        {
            _collection = collection;
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Enumerator : IEnumerator<T>
        {
            private TCollectionIterator _iterator;
            private T _current;
            private bool _work;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Enumerator(in TCollectionWrapper collection)
            {
                _iterator = collection.GetIteratorWrapper();
                _current = default;
                _work = true;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext()
            {
                if (_work && _iterator.MoveNext(ref _current))
                {
                    return true;
                }

                _work = false;
                Dispose();
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public T Current
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return _current; }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //if (_disposed == false)
                _iterator.Dispose();
                //_current = default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator()
        {
            return new Enumerator(_collection);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, Where<T>, T> Where(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var filter1 = new Where<T>(@where);
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, Where<T>, T>(_collection, filter1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, WhereParam<TParam, T>, T> Where<TParam>(TParam param, Func<TParam, T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();
            // todo test @where that is realy delegate without closure

            var filter1 = new WhereParam<TParam, T>(param, @where);
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, WhereParam<TParam, T>, T>(_collection, filter1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, Select<T, TOutNext>, TOutNext> Select<TOutNext>(Func<T, TOutNext> @select)
        {
            if (@select == null) ThrowHelper.SelectDelegateIsNull();

            var filter1 = new Select<T, TOutNext>(@select);
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, Select<T, TOutNext>, TOutNext>(_collection, filter1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TFilter, T> Where<TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<T, T>
        {
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TFilter, T>(_collection, filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TFilter, TOutNext> Filter<TOutNext, TFilter>(in TFilter filter)
            where TFilter : struct, IFilter<T, TOutNext>
        {
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TFilter, TOutNext>(_collection, filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TakeN<T>, T> Take(int n)
        {
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TakeN<T>, T>(_collection, new TakeN<T>(n));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TakeWhile<T>, T> TakeWhile(Func<T, bool> @while)
        {
            if (@while == null) ThrowHelper.TakeWhileDelegateIsNull();

            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, TakeWhile<T>, T>(_collection, new TakeWhile<T>(@while));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, SkipN<T>, T> Skip(int n)
        {
            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, SkipN<T>, T>(_collection, new SkipN<T>(n));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LowCostLinq<T, TCollectionWrapper, TCollectionIterator, SkipWhile<T>, T> SkipWhile(Func<T, bool> @while)
        {
            if (@while == null) ThrowHelper.SkipWhileDelegateIsNull();

            return new LowCostLinq<T, TCollectionWrapper, TCollectionIterator, SkipWhile<T>, T>(_collection, new SkipWhile<T>(@while));
        }

        /*[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Iterate<TAcc>(ref TAcc acc) where TAcc : struct, IAccumulator<T>
        {
            using (var iterator = _collection.GetIteratorWrapper())
            {
                T input = default;
                int currentIndex = 0;

                while (true)
                {
                    if (iterator.MoveNext(ref input, currentIndex))
                    {
                        currentIndex++;
                        
                        if (acc.Accumulate(ref input))
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
            var acc = new CountAccumulator<T>();
            _collection.Iterate(ref acc);

            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new CountWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            return acc.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First()
        {
            var acc = new FirstWithFlagAccumulator<T>();
            _collection.Iterate(ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault()
        {
            var acc = new FirstAccumulator<T>();
            _collection.Iterate(ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWithFlagWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new FirstWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Single()
        {
            var acc = new SingleWithFlagAccumulator<T>();
            _collection.Iterate(ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T SingleOrDefault()
        {
            var acc = new SingleWithFlagAccumulator<T>();
            _collection.Iterate(ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Single(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            if (acc.IsSet == false) ThrowHelper.ElementNotFound();
            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T SingleOrDefault(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new SingleWithFlagWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            if (acc.HasSecond) ThrowHelper.MoreThanOneElementWasFound();

            return acc.Item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            var acc = new AnyAccumulator<T>();
            _collection.Iterate(ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AnyWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            return acc.Any;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();

            var acc = new AllWhereAccumulator<T>(@where);
            _collection.Iterate(ref acc);

            return acc.All;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            var acc = new ToArrayAccumulator<T>();
            _collection.Iterate(ref acc);

            return acc.ToArray();
        }
    }
}