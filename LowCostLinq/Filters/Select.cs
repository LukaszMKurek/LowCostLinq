using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Select<TIn, TOut> : IFilter<TIn, TOut>
    {
        private readonly Func<TIn, TOut> _select;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Select(Func<TIn, TOut> @select)
        {
            _select = @select;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TOut output, ref bool willBreak)
        {
            output = _select(input);
            return true;
        }
    }
}