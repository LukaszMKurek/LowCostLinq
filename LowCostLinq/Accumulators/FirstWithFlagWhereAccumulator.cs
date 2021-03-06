﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Accumulators
{
    [StructLayout(LayoutKind.Auto)]
    internal struct FirstWithFlagWhereAccumulator<T> : IAccumulator<T>
    {
        private readonly Func<T, bool> _where;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public FirstWithFlagWhereAccumulator(Func<T, bool> @where)
        {
            _where = @where;
            Item = default;
            IsSet = false;
        }

        public T Item { get; private set; }
        public bool IsSet { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Accumulate(ref T item)
        {
            if (_where(item))
            {
                Item = item;
                IsSet = true;
                return true;
            }

            return false;
        }
    }
}