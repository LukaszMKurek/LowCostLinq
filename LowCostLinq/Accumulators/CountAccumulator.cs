using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct CountAccumulator<T> : IAccumulator<T>
    {
        public int Count { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            checked { Count++; }
            
            return false;
        }
    }
}