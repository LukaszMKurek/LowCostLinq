using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LowCostLinq.Internals.IterateHeplers;

namespace LowCostLinq.CollectionWrappers
{
    public readonly struct ListWWithoutCheckVersion<TIn> : ICollectionWrapper<TIn>, ICollectionWrapper<TIn, ListWWithoutCheckVersion<TIn>.Iterator>
    {
        private readonly List<TIn> _list;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ListWWithoutCheckVersion(List<TIn> list)
        {
            _list = list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Iterator GetIteratorWrapper()
        {
            return new Iterator(_list);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TAcc>(ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>
        {
            IterateListWithoutChecksHelper.IterateListWithoutChecks(_list, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TOut, TAcc>(in TFilter1 filter1, ref TAcc acc) 
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TOut, TAcc>(_list, filter1, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(_list, filter1, filter2, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(_list, filter1, filter2, filter3, ref acc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            IterateListWithoutChecksHelper.IterateListWithoutChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(_list, filter1, filter2, filter3, filter4, ref acc);
        }

        [StructLayout(LayoutKind.Auto)]
        public struct Iterator : ICollectionIterator<TIn>
        {
            private readonly List<TIn> _list;
            private int _currentIndex;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Iterator(List<TIn> list)
            {
                _list = list;
                _currentIndex = 0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext(ref TIn output)
            {
                if (_currentIndex < _list.Count)
                {
                    output = _list[unchecked(_currentIndex++)];
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