using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct FirstAccumulator<T> : IAccumulator<T>
    {
        public T Item { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            Item = item;
            return true;
        }
    }
}