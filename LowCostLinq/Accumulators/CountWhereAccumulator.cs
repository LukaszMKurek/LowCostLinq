using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct CountWhereAccumulator<T> : IAccumulator<T>
    {
        private readonly Func<T, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CountWhereAccumulator(Func<T, bool> @where)
        {
            _where = @where;
            Count = 0;
        }

        public int Count { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (_where(item))
            {
                checked { Count++; }
            }

            return false;
        }
    }
}