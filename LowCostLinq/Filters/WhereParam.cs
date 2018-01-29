using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct WhereParam<TParam, TIn> : IFilter<TIn, TIn>
    {
        private readonly Func<TParam, TIn, bool> _where;
        private readonly TParam _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereParam(TParam param, Func<TParam, TIn, bool> @where)
        {
            _param = param;
            _where = @where;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TIn output, ref bool willBreak)
        {
            output = input;
            return _where(_param, input);
        }
    }
}