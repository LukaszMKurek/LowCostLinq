using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters.Items
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct WhereItemIsNull<TItem> : IFilter<TItem, TItem>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TItem input, out TItem output, ref bool willBreak)
        {
            output = input;
            return input == null;
        }
    }
}