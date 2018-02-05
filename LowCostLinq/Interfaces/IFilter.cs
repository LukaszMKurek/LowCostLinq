using System.Runtime.CompilerServices;

namespace LowCostLinq
{
    public interface IFilter<TIn, TOut>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool Filter(ref TIn input, out TOut output, ref bool willBreak);
    }
}