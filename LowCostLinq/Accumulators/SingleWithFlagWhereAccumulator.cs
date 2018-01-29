using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct SingleWithFlagWhereAccumulator<T> : IAccumulator<T>
    {
        private readonly Func<T, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SingleWithFlagWhereAccumulator(Func<T, bool> @where)
        {
            _where = @where;
            Item = default;
            IsSet = false;
            HasSecond = false;
        }

        public T Item { get; private set; }
        public bool IsSet { get; private set; }
        public bool HasSecond { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (_where(item))
            {
                if (IsSet)
                {
                    HasSecond = true;
                    return true;
                }

                Item = item;
                IsSet = true;
                return false;
            }

            return false;
        }
    }
}