using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct ToArrayAccumulator<T> : IAccumulator<T>
    {
        private readonly static T[] empty = new T[0];
        private uint count;
        private readonly uint expectedCapacity;
        private T[] items;
        
        internal ToArrayAccumulator(uint expectedCapacity)
        {
            count = 0;
            items = empty;
            this.expectedCapacity = expectedCapacity == 0 ? 1 : expectedCapacity; // exception is unnecesary
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (count < (uint)items.Length)
            {
                items[count] = item;
            }
            else
            {
                var newLen = items == empty ? expectedCapacity : count * 2u;
                var newItems = new T[newLen];
                
                Array.Copy(items, 0, newItems, 0, (int)count);
                newItems[count] = item;

                items = newItems;
            }

            unchecked { count++; }

            return false;
        }

        internal T[] ToArray()
        {
            if (items.Length == count)
                return items;

            var result = new T[count];
            Array.Copy(items, 0, result, 0, count);

            return result;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    internal struct ToArrayAccumulatorOptimizedForDefault<T> : IAccumulator<T>
    {
        private readonly static T[] empty = new T[0];
        private uint count;
        private T[] items;

        internal ToArrayAccumulatorOptimizedForDefault(uint expectedCapacity) // C# do not have empty struct constructor
        {
            count = 0;
            items = empty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (count < (uint)items.Length)
            {
                items[count] = item;
            }
            else
            {
                var newLen = items == empty ? 4u : count * 2u;
                var newItems = new T[newLen];

                Array.Copy(items, 0, newItems, 0, (int)count);
                newItems[count] = item;

                items = newItems;
            }

            unchecked { count++; }

            return false;
        }

        internal T[] ToArray()
        {
            if (items.Length == count)
                return items;

            var result = new T[count];
            Array.Copy(items, 0, result, 0, count);

            return result;
        }
    }
}