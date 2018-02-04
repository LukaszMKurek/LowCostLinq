using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters.Items
{
    [StructLayout(LayoutKind.Auto)]
    public /*readonly */struct WhereItemEqualTo<TItem> : IFilter<TItem, TItem>
        where TItem : IEquatable<TItem>
    {
        private /*readonly */TItem _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereItemEqualTo(/*in*/ TItem param)
        {
            _param = param;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TItem input, out TItem output, ref bool willBreak)
        {
            output = input;

            if (_param != null)
            {
                /*if (_param == null)
                    return false;*/

                return _param.Equals(input);
            }
            
            return input == null;
        }
    }
    
    [StructLayout(LayoutKind.Auto)]
    public /*readonly */struct WhereItemEqualToNullable<TItem> : IFilter<TItem?, TItem?>
        where TItem : struct, IEquatable<TItem>
    {
        private /*readonly */TItem? _param;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereItemEqualToNullable(/*in*/ TItem? param)
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
                    return false;

                return _param.Value.Equals(input.Value);
            }
            
            return input == null;
        }
    }
}
