using System.Runtime.CompilerServices;

namespace LowCostLinq
{
    public interface IAccumulator<T>
    {
        /// <summary>
        /// When return true accumulating will stop
        /// </summary>
        /// <param name="item">Current item. Do not update reference. ref is only for performance.</param>
        /// <returns>Accumulate is finished?</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool Accumulate(ref T item);
    }
}