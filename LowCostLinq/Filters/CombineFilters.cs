using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    // todo zrobić jeszcze specjalizacje dla dóch rodzajów delegat może będzie szybciej...
    [StructLayout(LayoutKind.Auto)]
    public struct CombineFilters<TIn, TFilter1, TMid, TFilter2, TOut> : IFilter<TIn, TOut>
        where TFilter1 : struct, IFilter<TIn, TMid>
        where TFilter2 : struct, IFilter<TMid, TOut>
    {
        // Important! these field must be non readonly!
        private TFilter1 _filter1;
        private TFilter2 _filter2;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CombineFilters(in TFilter1 filter1, in TFilter2 filter2)
        {
            _filter1 = filter1;
            _filter2 = filter2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TOut output, ref bool willBreak)
        {
            if (_filter1.Filter(ref input, out var mid, ref willBreak))
            {
                return _filter2.Filter(ref mid, out output, ref willBreak);
            }

            output = default;
            return false;
        }
    }
}