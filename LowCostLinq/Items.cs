using System;
using System.Runtime.CompilerServices;
using LowCostLinq.Filters.Items;
using LowCostLinq.Internals;

namespace LowCostLinq
{
    /// <summary>
    /// LowCostLinq specific API that offer very fast filters.
    /// </summary>
    public static class Items
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsNull<TItem> AreNull<TItem>()
            where TItem : IEquatable<TItem>
        {
            return new WhereItemIsNull<TItem>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsNull<TItem?> AreNullNullable<TItem>()
            where TItem : struct, IEquatable<TItem>
        {
            return new WhereItemIsNull<TItem?>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsNotNull<TItem> AreNotNull<TItem>()
            where TItem : IEquatable<TItem>
        {
            return new WhereItemIsNotNull<TItem>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsNotNull<TItem?> AreNotNullNullable<TItem>()
            where TItem : struct, IEquatable<TItem>
        {
            return new WhereItemIsNotNull<TItem?>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemEqualTo<TItem> AreEqualTo<TItem>(TItem param)
            where TItem : IEquatable<TItem>
        {
            return new WhereItemEqualTo<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemEqualToNullable<TItem> AreEqualTo<TItem>(TItem? param)
            where TItem : struct, IEquatable<TItem>
        {
            return new WhereItemEqualToNullable<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemNotEqualTo<TItem> AreNotEqualTo<TItem>(TItem param)
            where TItem : IEquatable<TItem>
        {
            return new WhereItemNotEqualTo<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemNotEqualToNullable<TItem> AreNotEqualTo<TItem>(TItem? param)
            where TItem : struct, IEquatable<TItem>
        {
            return new WhereItemNotEqualToNullable<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsGreatherThan<TItem> AreGreatherThan<TItem>(TItem param)
            where TItem : IComparable<TItem>
        {
            if (param == null) ThrowHelper.ArgumentIsNull();

            return new WhereItemIsGreatherThan<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsGreatherOrEqualThan<TItem> AreGreatherOrEqualThan<TItem>(TItem param)
            where TItem : IComparable<TItem>
        {
            if (param == null) ThrowHelper.ArgumentIsNull();

            return new WhereItemIsGreatherOrEqualThan<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsSmallerThan<TItem> AreSmallerThan<TItem>(TItem param)
            where TItem : IComparable<TItem>
        {
            if (param == null) ThrowHelper.ArgumentIsNull();

            return new WhereItemIsSmallerThan<TItem>(param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereItemIsSmallerOrEqualThan<TItem> AreSmallerOrEqualThan<TItem>(TItem param)
            where TItem : IComparable<TItem>
        {
            if (param == null) ThrowHelper.ArgumentIsNull();

            return new WhereItemIsSmallerOrEqualThan<TItem>(param);
        }
    }
}