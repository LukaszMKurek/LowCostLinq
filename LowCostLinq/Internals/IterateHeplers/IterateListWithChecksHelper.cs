using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LowCostLinq.Filters;

namespace LowCostLinq.Internals.IterateHeplers
{
    internal static class IterateListWithChecksHelper
    {
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void IterateListWithChecks<TIn, TAcc>(List<TIn> list, ref TAcc acc)
            where TAcc : struct, IAccumulator<TIn>
        {
            TAcc accLocal = acc;
            foreach (var item in list)
            {
                var input = item;
                if (accLocal.Accumulate(ref input))
                    break;
            }
            acc = accLocal;
        }

        internal static void IterateListWithChecks<TIn, TFilter1, TOut, TAcc>(List<TIn> list, TFilter1 filter1, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;

            if (typeof(TFilter1) == typeof(Where<TOut>))
            {
                var @where = ((Where<TOut>)(object)filter1)._where;

                foreach (var item in list)
                {
                    var current = (TOut)(object)item;
                    if (@where(current))
                    {
                        if (accLocal.Accumulate(ref current))
                            break;
                    }
                }
            }
            else
            {
                bool willBreak = false;
                var iterator = list.GetEnumerator();
                while (iterator.MoveNext() && willBreak == false)
                {
                    var input = iterator.Current;
                    if (filter1.Filter(ref input, out var current, ref willBreak))
                    {
                        willBreak = accLocal.Accumulate(ref current);
                    }
                }
            }

            acc = accLocal;
        }

        internal static void IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TOut, TAcc>(List<TIn> list, TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            foreach (var item in list)
            {
                var input = item;
                if (filter1.Filter(ref input, out var mid1, ref willBreak))
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

        internal static void IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(List<TIn> list, TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            foreach (var item in list)
            {
                var input = item;
                if (filter1.Filter(ref input, out var mid1, ref willBreak))
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

        internal static void IterateListWithChecks<TIn, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(List<TIn> list, TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            TAcc accLocal = acc;
            bool willBreak = false;

            foreach (var item in list)
            {
                var input = item;
                if (filter1.Filter(ref input, out var mid1, ref willBreak))
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