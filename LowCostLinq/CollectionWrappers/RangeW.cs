using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.CollectionWrappers
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RangeW : ICollectionWrapper<int>, ICollectionWrapper<int, RangeW.Iterator>
    {
        private readonly int _start;
        private readonly int _max;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal RangeW(int start, int max)
        {
            _start = start;
            _max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Iterator GetIteratorWrapper()
        {
            return new Iterator(_start, _max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TAcc>(ref TAcc acc)
            where TAcc : struct, IAccumulator<int>
        {
            TAcc accLocal = acc;
            for (int i = _start; i < _max; i = unchecked(i + 1))
            {
                if (accLocal.Accumulate(ref i))
                    break;
            }
            acc = accLocal;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TOut, TAcc>(in TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<int, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (int i = _start; i < _max; i = unchecked(i + 1))
            {
                if (filter1.Filter(ref i, out var current, ref willBreak))
                {
                    willBreak = accLocal.Accumulate(ref current);
                }

                if (willBreak)
                    break;
            }
            acc = accLocal;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<int, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (int i = _start; i < _max; i = unchecked(i + 1))
            {
                if (filter1.Filter(ref i, out var mid1, ref willBreak))
                {
                    if (filter2.Filter(ref mid1, out var output, ref willBreak))
                    {
                        willBreak = accLocal.Accumulate(ref output);
                    }
                }

                if (willBreak)
                    break;
            }
            acc = accLocal;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<int, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (int i = _start; i < _max; i = unchecked(i + 1))
            {
                if (filter1.Filter(ref i, out var mid1, ref willBreak))
                {
                    if (filter2.Filter(ref mid1, out var mid2, ref willBreak))
                    {
                        if (filter3.Filter(ref mid2, out var output, ref willBreak))
                        {
                            willBreak = accLocal.Accumulate(ref output);
                        }
                    }
                }

                if (willBreak)
                    break;
            }
            acc = accLocal;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<int, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (int i = _start; i < _max; i = unchecked(i + 1))
            {
                if (filter1.Filter(ref i, out var mid1, ref willBreak))
                {
                    if (filter2.Filter(ref mid1, out var mid2, ref willBreak))
                    {
                        if (filter3.Filter(ref mid2, out var mid3, ref willBreak))
                        {
                            if (filter4.Filter(ref mid3, out var output, ref willBreak))
                            {
                                willBreak = accLocal.Accumulate(ref output);
                            }
                        }
                    }
                }

                if (willBreak)
                    break;
            }
            acc = accLocal;
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Iterator : ICollectionIterator<int>
        {
            private readonly int _start;
            private readonly int _max;
            private int _currentIndex;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Iterator(int start, int max)
            {
                _start = start;
                _max = max;
                _currentIndex = 0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext(ref int output)
            {
                var value = unchecked(_start + _currentIndex);
                if (value < _max)
                {
                    unchecked { _currentIndex++; }
                    output = value;
                    return true;
                }

                return false;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Dispose()
            {
                //_currentIndex = Int32.MaxValue;
            }
        }
    }
}