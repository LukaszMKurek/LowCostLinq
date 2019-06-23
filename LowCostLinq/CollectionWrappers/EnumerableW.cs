using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LowCostLinq.Internals.IterateHeplers;

namespace LowCostLinq.CollectionWrappers
{
    /// <summary>
    /// Slower than EnumerableWWithoutCheckVersion but identical behaviour like LINQ
    /// </summary>
    public readonly struct EnumerableW<TIn, TEnumerable> : ICollectionWrapper<TIn>, ICollectionWrapper<TIn, EnumerableW<TIn, TEnumerable>.Iterator>
        where TEnumerable : IEnumerable<TIn>
    {
        private readonly TEnumerable _enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal EnumerableW(TEnumerable enumerable)
        {
            _enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Iterator GetIteratorWrapper()
        {
            return new Iterator(_enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TAcc>(ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>
        {
            if (_enumerable is TIn[] array)
            {
                IterateArrayHelper.IterateArray(array, ref acc);
            }
            else if (_enumerable is List<TIn> list)
            {
                IterateListWithChecksHelper.IterateListWithChecks(list, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TAcc>(_enumerable, ref acc);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TOut, TAcc>(in TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            if (_enumerable is TIn[] array)
            {
                IterateArrayHelper.IterateArray<TIn, TFilter1, TOut, TAcc>(array, filter1, ref acc);
            }
            else if (_enumerable is List<TIn> list)
            {
                IterateListWithChecksHelper.IterateListWithChecks<TIn, TFilter1, TOut, TAcc>(list, filter1, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TFilter1, TOut, TAcc>(_enumerable, filter1, ref acc);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            if (_enumerable is TIn[] array)
            {
                IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(array, filter1, filter2, ref acc);
            }
            else if (_enumerable is List<TIn> list)
            {
                IterateListWithChecksHelper.IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(list, filter1, filter2, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TOut, TAcc>(_enumerable, filter1, filter2, ref acc);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            if (_enumerable is TIn[] array)
            {
                IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(array, filter1, filter2, filter3, ref acc);
            }
            else if (_enumerable is List<TIn> list)
            {
                IterateListWithChecksHelper.IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(list, filter1, filter2, filter3, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(_enumerable, filter1, filter2, filter3, ref acc);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            if (_enumerable is TIn[] array)
            {
                IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(array, filter1, filter2, filter3, filter4, ref acc);
            }
            else if (_enumerable is List<TIn> list)
            {
                IterateListWithChecksHelper.IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(list, filter1, filter2, filter3, filter4, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(_enumerable, filter1, filter2, filter3, filter4, ref acc);
            }
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Iterator : ICollectionIterator<TIn>
        {
            private uint _currentIndex;
            private readonly TIn[] _array;
            private IEnumerator<TIn> _enumerator;
            private List<TIn>.Enumerator _listEnumerator;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Iterator(TEnumerable enumerable)
            {
                _currentIndex = 0u;
                _array = enumerable as TIn[];
                _enumerator = null;
                if (_array == null)
                {
                    if (enumerable is List<TIn> list)
                    {
                        _listEnumerator = list.GetEnumerator();
                    }
                    else
                    {
                        _enumerator = enumerable.GetEnumerator();
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext(ref TIn output)
            {
                var array = _array;
                if (array != null)
                {
                    var currentIndex = unchecked(_currentIndex++);

                    if (currentIndex < (uint)array.Length)
                    {
                        output = array[currentIndex]; // todo ref?
                        return true;
                    }
                }
                else
                {
                    var enumerator = _enumerator;
                    if (enumerator == null)
                    {
                        if (_listEnumerator.MoveNext())
                        {
                            output = _listEnumerator.Current;
                            return true;
                        }
                    }
                    else
                    {
                        if (enumerator.MoveNext())
                        {
                            output = enumerator.Current;
                            return true;
                        }
                    }
                }

                return false;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Dispose()
            {
                _enumerator?.Dispose();
                _enumerator = null;
                //_listEnumerator.Dispose();
            }
        }
    }
}