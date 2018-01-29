using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LowCostLinq.CollectionWrappers;
using LowCostLinq.Filters;
using LowCostLinq.Internals;

namespace LowCostLinq
{
    public static class LowCostLinqExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, ArrayW<T>, ArrayW<T>.Iterator> AsLowCostLinq<T>(this T[] array)
        {
            if (array == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, ArrayW<T>, ArrayW<T>.Iterator>(new ArrayW<T>(array));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, ArrayW<T>, ArrayW<T>.Iterator, Where<T>, T> LowCostWhere<T>(this T[] array, Func<T, bool> @where)
        {
            if (@where == null) ThrowHelper.WhereDelegateIsNull();
            
            return new LowCostLinq<T, ArrayW<T>, ArrayW<T>.Iterator, Where<T>, T>(new ArrayW<T>(array), new Where<T>(@where));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, ListW<T>, ListW<T>.Iterator> AsLowCostLinq<T>(this List<T> list)
        {
            if (list == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, ListW<T>, ListW<T>.Iterator>(new ListW<T>(list));
        }

        /// <summary>
        /// During iteration over List, List internal version check will be skip to achive maximum performance.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, ListWWithoutCheckVersion<T>, ListWWithoutCheckVersion<T>.Iterator> AsLowCostLinqWithoutChecks<T>(this List<T> list)
        {
            if (list == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, ListWWithoutCheckVersion<T>, ListWWithoutCheckVersion<T>.Iterator>(new ListWWithoutCheckVersion<T>(list));
        }

        /// <summary>
        /// Exist only because AsLowCostLinqGeneric can not infer in current version of C#. Mayby in future.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, EnumerableW<T, IEnumerable<T>>, EnumerableW<T, IEnumerable<T>>.Iterator> AsLowCostLinq<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, EnumerableW<T, IEnumerable<T>>, EnumerableW<T, IEnumerable<T>>.Iterator>(new EnumerableW<T, IEnumerable<T>>(enumerable));
        }

        /// <summary>
        /// Exist only because AsLowCostLinqWithoutChecksGeneric can not infer in current version of C#. Maby in future.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, EnumerableWWithoutCheckVersion<T, IEnumerable<T>>, EnumerableWWithoutCheckVersion<T, IEnumerable<T>>.Iterator> AsLowCostLinqWithoutChecks<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, EnumerableWWithoutCheckVersion<T, IEnumerable<T>>, EnumerableWWithoutCheckVersion<T, IEnumerable<T>>.Iterator>(new EnumerableWWithoutCheckVersion<T, IEnumerable<T>>(enumerable));
        }

        /// <summary>
        /// Mayby future version of C# can infer this method
        /// During iteration over List, List internal version check will be skip to achive maximum performance.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, EnumerableW<T, TEnumerable>, EnumerableW<T, TEnumerable>.Iterator> AsLowCostLinqGeneric<T, TEnumerable>(this TEnumerable enumerable)
            where TEnumerable : IEnumerable<T>
        {
            if (enumerable == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, EnumerableW<T, TEnumerable>, EnumerableW<T, TEnumerable>.Iterator>(new EnumerableW<T, TEnumerable>(enumerable));
        }

        /// <summary>
        /// Mayby future version of C# can infer this method
        /// During iteration over List, List internal version check will be skip to achive maximum performance.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LowCostLinq<T, EnumerableWWithoutCheckVersion<T, TEnumerable>, EnumerableWWithoutCheckVersion<T, TEnumerable>.Iterator> AsLowCostLinqWithoutChecksGeneric<T, TEnumerable>(this TEnumerable enumerable)
            where TEnumerable : IEnumerable<T>
        {
            if (enumerable == null) ThrowHelper.CollectionIsNull();

            return new LowCostLinq<T, EnumerableWWithoutCheckVersion<T, TEnumerable>, EnumerableWWithoutCheckVersion<T, TEnumerable>.Iterator>(new EnumerableWWithoutCheckVersion<T, TEnumerable>(enumerable));
        }
    }
}