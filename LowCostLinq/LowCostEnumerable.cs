using System;
using LowCostLinq.CollectionWrappers;
using LowCostLinq.Internals;

namespace LowCostLinq
{
    public static class LowCostEnumerable
    {
        public static RangeW Range(int start, int count)
        {
            if (count < 0) ThrowHelper.ArgumentCountCannotBeLessThanZero();
            if (start < Int32.MaxValue - count) ThrowHelper.InvalidRangeArgument();

            return new RangeW(start, unchecked(start + count));
        }
    }
}
