using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct ToArrayAccumulator<T> : IAccumulator<T>
    {
        private T[] items;
        private int count;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (items == null)
            {
                items = new T[4];
            }
            else if (items.Length == count)
            {
                var newItems = new T[checked(count * 2)];
                Array.Copy(items, 0, newItems, 0, count);
                items = newItems;
            }

            items[count++] = item;

            return false;
        }

        internal T[] ToArray()
        {
            if (count == 0)
                return new T[0];

            if (items.Length == count)
                return items;

            var result = new T[count];
            Array.Copy(items, 0, result, 0, count);

            return result;
        }
    }
}