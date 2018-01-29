using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct SingleWithFlagAccumulator<T> : IAccumulator<T>
    {
        public T Item { get; private set; }
        public bool IsSet { get; private set; }
        public bool HasSecond { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
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
    }
}