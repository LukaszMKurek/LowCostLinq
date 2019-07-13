using System.Runtime.CompilerServices;

namespace LowCostLinq.Accumulators
{
    internal struct CountAccumulator<T> : IAccumulator<T>
    {
        internal int Count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            checked { Count++; }
            
            return false;
        }
    }
}