using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LowCostLinq.Internals.IterateHeplers;

namespace LowCostLinq.CollectionWrappers
{
    public readonly struct ArrayW<TIn> : ICollectionWrapper<TIn>, ICollectionWrapper<TIn, ArrayW<TIn>.Iterator>
    {
        private readonly TIn[] _array;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ArrayW(TIn[] array)
        {
            _array = array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Iterator GetIteratorWrapper()
        {
            return new Iterator(_array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TAcc>(ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>
        {
            IterateArrayHelper.IterateArray(_array, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TOut, TAcc>(in TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateArrayHelper.IterateArray<TIn, TFilter1, TOut, TAcc>(_array, filter1, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(_array, filter1, filter2, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(_array, filter1, filter2, filter3, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateArrayHelper.IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(_array, filter1, filter2, filter3, filter4, ref acc);
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Iterator : ICollectionIterator<TIn>
        {
            private uint _currentIndex;
            private readonly TIn[] _array;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Iterator(TIn[] array)
            {
                _currentIndex = 0u;
                _array = array;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext(ref TIn output)
            {
                var currentIndex = unchecked(_currentIndex++);
                var array = _array;

                if (currentIndex < (uint)array.Length)
                {
                    output = array[currentIndex]; // todo ref?
                    return true;
                }

                return false;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Dispose()
            {
                //_currentIndex = Int32.MaxValue; // or _array = null;
            }
        }
    }
}