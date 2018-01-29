using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace LowCostLinq
{
    public interface ICollectionWrapper<TIn, TCollectionIterator>
        where TCollectionIterator : struct, ICollectionIterator<TIn>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        TCollectionIterator GetIteratorWrapper();
    }

    public interface ICollectionWrapper<TIn>
    {
        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate<TAcc>(ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>;

        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate<TFilter1, TOut, TAcc>(in TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>;

        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate<TFilter1, TMid1, TFilter2, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>;

        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>;

        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate<TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>;
    }
}