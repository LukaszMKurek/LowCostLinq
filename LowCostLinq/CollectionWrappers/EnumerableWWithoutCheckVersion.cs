using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LowCostLinq.Internals.IterateHeplers;

namespace LowCostLinq.CollectionWrappers
{
    /// <summary>
    /// For better performance this implementation neglect checking internal version in List
    /// </summary>
    public readonly struct EnumerableWWithoutCheckVersion<TIn, TEnumerable> : ICollectionWrapper<TIn>, ICollectionWrapper<TIn, EnumerableWWithoutCheckVersion<TIn, TEnumerable>.Iterator>
        where TEnumerable : IEnumerable<TIn>
    {
        private readonly TEnumerable _enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal EnumerableWWithoutCheckVersion(TEnumerable enumerable)
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
                IterateListWithoutChecksHelper.IterateListWithoutChecks(list, ref acc);
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
                IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TOut, TAcc>(list, filter1, ref acc);
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
                IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(list, filter1, filter2, ref acc);
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
                IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(list, filter1, filter2, filter3, ref acc);
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
                IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(list, filter1, filter2, filter3, filter4, ref acc);
            }
            else
            {
                IterateEnumerableHelper.IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(_enumerable, filter1, filter2, filter3, filter4, ref acc);
            }
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Iterator : ICollectionIterator<TIn>
        {
            private uint _currentIndexU;
            private int _currentIndex;
            private readonly uint _case;
            private readonly TIn[] _array;
            private readonly List<TIn> _list;
            private IEnumerator<TIn> _enumerator; // todo te 3 pola mogą się ukryć pod unią

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Iterator(TEnumerable enumerable)
            {
                _currentIndexU = 0u;
                _currentIndex = 0;
                _array = enumerable as TIn[];
                _list = enumerable as List<TIn>;
                if (_array != null)
                {
                    _case = 0u;
                    _enumerator = null;
                }
                else if (_list != null)
                {
                    _case = 1u;
                    _enumerator = null;
                }
                else
                {
                    _case = 2u;
                    _enumerator = enumerable.GetEnumerator();
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext(ref TIn output)
            {
                switch (_case)
                {
                    case 0u:

                        var currentIndexU = unchecked(_currentIndexU++);
                        var array = _array;

                        if (currentIndexU < (uint)array.Length)
                        {
                            output = array[currentIndexU]; // todo ref?
                            return true;
                        }

                        break;
                    case 1u:

                        var currentIndex = unchecked(_currentIndex++);
                        var list = _list;

                        if (currentIndex < list.Count)
                        {
                            output = list[currentIndex];
                            return true;
                        }

                        break;
                    //case 2u:
                    default:

                        if (_enumerator.MoveNext())
                        {
                            output = _enumerator.Current;
                            return true;
                        }

                        break;
                }

                return false;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Dispose()
            {
                _enumerator?.Dispose();
                _enumerator = null;
                //_case = 3;
            }
        }
    }
}