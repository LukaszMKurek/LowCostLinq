﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters.Items
{
    [StructLayout(LayoutKind.Auto)]
    public /*readonly*/ struct WhereItemIsSmallerThan<TItem> : IFilter<TItem, TItem>
        where TItem : IComparable<TItem>
    {
        private /*readonly*/ TItem _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereItemIsSmallerThan(TItem param)
        {
            _param = param;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TItem input, out TItem output, ref bool willBreak)
        {
            output = input;
            return _param.CompareTo(input) > 0;
        }
    }
}