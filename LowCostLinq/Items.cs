using System;
using System.Runtime.CompilerServices;
using LowCostLinq.Filters.Items;

namespace LowCostLinq
{
    public static class Item
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemEqualTo<TItem> AreEqualTo<TItem>(TItem param)
            where TItem : IEquatable<TItem>
        {
            return new WhereItemEqualTo<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemNotEqualTo<TItem> AreNotEqualTo<TItem>(TItem param)
            where TItem : IEquatable<TItem>
        {
            return new WhereItemNotEqualTo<TItem>(param);
        }
    }
}