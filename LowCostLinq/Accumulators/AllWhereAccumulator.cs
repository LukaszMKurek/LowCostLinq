using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct AllWhereAccumulator<T> : IAccumulator<T>
    {
        private readonly Func<T, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AllWhereAccumulator(Func<T, bool> @where)
        {
            _where = @where;
            All = true;
        }

        public bool All { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (_where(item))
            {
                return false;
            }

            All = false;
            return true;
        }
    }
}