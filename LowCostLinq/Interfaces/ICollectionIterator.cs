using System;
using System.Runtime.CompilerServices;

namespace LowCostLinq
{
    public interface ICollectionIterator<TIn> : IDisposable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool MoveNext(ref TIn output);
    }
}