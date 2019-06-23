using System.Runtime.CompilerServices;

namespace LowCostLinq.Internals.IterateHeplers
{
    internal static class IterateArrayHelper
    {
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void IterateArray<TIn, TAcc>(TIn[] array, ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>
        {
            TAcc accLocal = acc;
            for (uint i = 0; i < unchecked((uint)array.Length); i = unchecked(i + 1))
            {
                if (accLocal.Accumulate(ref array[i]))
                    break;
            }
            acc = accLocal;
        }

        internal static void IterateArray<TIn, TFilter1, TOut, TAcc>(TIn[] array, TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (uint i = 0; i < unchecked((uint)array.Length); i = unchecked(i + 1))
            {
                if (filter1.Filter(ref array[i], out var current, ref willBreak))
                {
                    willBreak = accLocal.Accumulate(ref current);
                }

                if (willBreak)
                    break;
            }
            acc = accLocal;
        }

        internal static void IterateArray<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(TIn[] array, TFilter1 filter1,
            TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (uint i = 0; i < unchecked((uint)array.Length); i = unchecked(i + 1))
            {
                if (filter1.Filter(ref array[i], out var mid1, ref willBreak))
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

        internal static void IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TIn[] array,
            TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (uint i = 0; i < unchecked((uint)array.Length); i = unchecked(i + 1))
            {
                if (filter1.Filter(ref array[i], out var mid1, ref willBreak))
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

        internal static void IterateArray<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(
            TIn[] array, TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            for (uint i = 0; i < unchecked((uint)array.Length); i = unchecked(i + 1))
            {
                if (filter1.Filter(ref array[i], out var mid1, ref willBreak))
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
    }
}