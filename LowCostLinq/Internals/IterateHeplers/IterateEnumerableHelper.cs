using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LowCostLinq.Internals.IterateHeplers
{
    internal static class IterateEnumerableHelper
    {
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void IterateEnumerable<TIn, TEnumerable, TAcc>(TEnumerable enumerable, ref TAcc acc)
            where TEnumerable : IEnumerable<TIn>
            where TAcc : struct, IAccumulator<TIn>
        {
            foreach (var item in enumerable)
            {
                var input = item;
                if (acc.Accumulate(ref input))
                    break;
            }
        }

        internal static void IterateEnumerable<TIn, TEnumerable, TFilter1, TOut, TAcc>(TEnumerable enumerable, TFilter1 filter1, ref TAcc acc)
            where TEnumerable : IEnumerable<TIn>
            where TFilter1 : struct, IFilter<TIn, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            bool willBreak = false;

            foreach (var item in enumerable)
            {
                var input = item;
                if (filter1.Filter(ref input, out var current, ref willBreak))
                {
                    willBreak = acc.Accumulate(ref current);
                }

                if (willBreak)
                    break;
            }
        }

        internal static void IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TOut, TAcc>(TEnumerable enumerable, TFilter1 filter1, TFilter2 filter2, ref TAcc acc)
            where TEnumerable : IEnumerable<TIn>
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            bool willBreak = false;

            foreach (var item in enumerable)
            {
                var input = item;
                if (filter1.Filter(ref input, out var mid1, ref willBreak))
                {
                    if (filter2.Filter(ref mid1, out var output, ref willBreak))
                    {
                        willBreak = acc.Accumulate(ref output);
                    }
                }

                if (willBreak)
                    break;
            }
        }

        internal static void IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TOut, TAcc>(TEnumerable enumerable, TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, ref TAcc acc)
            where TEnumerable : IEnumerable<TIn>
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            bool willBreak = false;

            foreach (var item in enumerable)
            {
                var input = item;
                if (filter1.Filter(ref input, out var mid1, ref willBreak))
                {
                    if (filter2.Filter(ref mid1, out var mid2, ref willBreak))
                    {
                        if (filter3.Filter(ref mid2, out var output, ref willBreak))
                        {
                            willBreak = acc.Accumulate(ref output);
                        }
                    }
                }

                if (willBreak)
                    break;
            }
        }

        internal static void IterateEnumerable<TIn, TEnumerable, TFilter1, TMid1, TFilter2, TMid2, TFilter3, TMid3, TFilter4, TOut, TAcc>(TEnumerable enumerable, TFilter1 filter1, TFilter2 filter2, TFilter3 filter3, TFilter4 filter4, ref TAcc acc)
            where TEnumerable : IEnumerable<TIn>
            where TFilter1 : struct, IFilter<TIn, TMid1>
            where TFilter2 : struct, IFilter<TMid1, TMid2>
            where TFilter3 : struct, IFilter<TMid2, TMid3>
            where TFilter4 : struct, IFilter<TMid3, TOut>
            where TAcc : struct, IAccumulator<TOut>
        {
            bool willBreak = false;

            foreach (var item in enumerable)
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
                                willBreak = acc.Accumulate(ref output);
                            }
                        }
                    }
                }

                if (willBreak)
                    break;
            }
        }
    }
}