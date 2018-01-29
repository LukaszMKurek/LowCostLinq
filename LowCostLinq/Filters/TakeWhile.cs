using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct TakeWhile<TIn> : IFilter<TIn, TIn>
    {
        private readonly Func<TIn, bool> _while;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TakeWhile(Func<TIn, bool> @while)
        {
            _while = @while;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TIn output, ref bool willBreak)
        {
            output = input;

            if (_while(input))
                return true;

            willBreak = true;
            return false;
        }
    }
}