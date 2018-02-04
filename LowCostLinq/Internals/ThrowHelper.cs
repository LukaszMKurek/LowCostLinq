using System;

namespace LowCostLinq.Internals
{
    internal static class ThrowHelper
    {
        internal static void ArgumentIsNull()
        {
            throw new ArgumentNullException();
        }

        internal static void CollectionIsNull()
        {
            throw new ArgumentNullException("collection");
        }

        internal static void WhereDelegateIsNull()
        {
            throw new ArgumentNullException("where delegate");
        }

        internal static void SelectDelegateIsNull()
        {
            throw new ArgumentNullException("select delegate");
        }

        internal static void TakeWhileDelegateIsNull()
        {
            throw new ArgumentNullException("take delegate");
        }

        internal static void SkipWhileDelegateIsNull()
        {
            throw new ArgumentNullException("skip delegate");
        }

        internal static void ElementNotFound()
        {
            throw new InvalidOperationException("Element not found");
        }

        internal static void MoreThanOneElementWasFound()
        {
            throw new InvalidOperationException("More than one element was found");
        }

        internal static void ArgumentCountCannotBeLessThanZero()
        {
            throw new ArgumentOutOfRangeException("Argument 'count' can not be less than zero");
        }

        internal static void InvalidRangeArgument()
        {
            throw new ArgumentOutOfRangeException("Arguments must met start + count < Int32.MaxValue");
        }
    }
}