using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct AnyWhereAccumulator<T> : IAccumulator<T>
    {
        private readonly Func<T, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AnyWhereAccumulator(Func<T, bool> @where)
        {
            _where = @where;
            Any = false;
        }

        public bool Any { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (_where(item))
            {
                Any = true;
                return true;
            }

            return false;
        }
    }
}