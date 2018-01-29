using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public struct SkipWhile<TIn> : IFilter<TIn, TIn>
    {
        private readonly Func<TIn, bool> _while;
        private bool _continue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipWhile(Func<TIn, bool> @while)
        {
            _while = @while;
            _continue = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TIn output, ref bool willBreak)
        {
            output = input;

            if (_continue)
                return true;

            if (_while(input))
                return false;

            _continue = true;
            return true;
        }
    }
}