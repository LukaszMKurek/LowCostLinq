using System;
using LowCostLinq.CollectionWrappers;
using LowCostLinq.Internals;

namespace LowCostLinq
{
    public static class LowCostEnumerable
    {
        public static LowCostLinq<int, RangeW, RangeW.Iterator> Range(int start, int count)
        {
            if (count < 0) ThrowHelper.ArgumentCountCannotBeLessThanZero();
            if ((((long)start) + count) > Int32.MaxValue) ThrowHelper.InvalidRangeArgument();

            var range = new RangeW(start, unchecked(start + count));
            return new LowCostLinq<int, RangeW, RangeW.Iterator>(range);
        }
    }
}