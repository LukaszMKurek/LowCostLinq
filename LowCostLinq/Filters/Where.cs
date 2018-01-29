using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Where<TIn> : IFilter<TIn, TIn>
    {
        private readonly Func<TIn, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Where(Func<TIn, bool> @where)
        {
            _where = @where;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TIn output, ref bool willBreak)
        {
            output = input;
            return _where(input);
        }
    }
}
