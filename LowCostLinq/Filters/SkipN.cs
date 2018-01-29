using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LowCostLinq.Filters
{
    [StructLayout(LayoutKind.Auto)]
    public struct SkipN<TIn> : IFilter<TIn, TIn>
    {
        private readonly int _n;
        private int _currentN;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipN(int n)
        {
            _n = n;
            _currentN = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Filter(ref TIn input, out TIn output, ref bool willBreak)
        {
            output = input;

            if (_currentN >= _n)
                return true;

            _currentN++;
            return false;
        }
    }
}