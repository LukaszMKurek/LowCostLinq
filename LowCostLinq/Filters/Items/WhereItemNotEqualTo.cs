using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters.Items
{
    [StructLayout(LayoutKind.Auto)]
    public /*readonly*/ struct WhereItemNotEqualTo<TItem> : IFilter<TItem, TItem>
        where TItem : IEquatable<TItem>
    {
        private /*readonly*/ TItem _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereItemNotEqualTo(TItem param)
        {
            _param = param;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TItem input, out TItem output, ref bool willBreak)
        {
            output = input;

            if (_param != null)
            {
                /*if (input == null)
                    return true;*/

                return _param.Equals(input) == false;
            }

            return input != null;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public /*readonly*/ struct WhereItemNotEqualToNullable<TItem> : IFilter<TItem?, TItem?>
        where TItem : struct, IEquatable<TItem>
    {
        private /*readonly*/ TItem? _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereItemNotEqualToNullable(TItem? param)
        {
            _param = param;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TItem? input, out TItem? output, ref bool willBreak)
        {
            output = input;

            if (_param != null)
            {
                if (input == null)
                    return true;

                return _param.Value.Equals(input.Value) == false;
            }
            
            return input != null;
        }
    }
}