using System.Linq;
using LowCostLinq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public sealed class ItemFilterTests
    {
        private static int[] _items = { 0, 1, 2, 3, 4, 3, 5, 5, 6, -1, 7 };
        private static int?[] _nullableItems = { 0, 1, null, 2, 3, 4, 3, null, 5, 5, null, 6, -1, 7 };
        private static string[] _stringItems = { "0", "1", null, "2", "3", "4", "3", null, "5", "5", null, "6", "-1", "7" };

        [Test]
        public void IsNull()
        {
            CollectionAssert.AreEqual(
                _items.Where(i => /*i == null*/ false)
                ,
                _items.AsLowCostLinq().Where(Items.AreNull<int>())
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i == null)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreNullNullable<int>()) // unfortunately C# is not enough smart currently
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i == null)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreNull<string>())
            );
        }

        [Test]
        public void IsNotNull()
        {
            CollectionAssert.AreEqual(
                _items.Where(i => /*i != null*/ true)
                ,
                _items.AsLowCostLinq().Where(Items.AreNotNull<int>())
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i != null)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreNotNullNullable<int>()) // unfortunately C# is not enough smart currently
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i != null)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreNotNull<string>())
            );
        }

        [Test]
        public void IsEqualTo()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i == x)
                ,
                _items.AsLowCostLinq().Where(Items.AreEqualTo(x)) // x cannot be nullable type when _items is array of nonnullable
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i == x)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreEqualTo((int?)x)) // unfortunately C# is not enough smart currently, so we need use explicit cast to nullable
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i == null)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreEqualTo((int?)null)) // unfortunately C# is not enough smart currently, so we need use explicit cast to nullable
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i == "3")
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreEqualTo("3"))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i == null)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreEqualTo((string)null))
            );
        }

        [Test]
        public void IsNotEqualTo()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i != x)
                ,
                _items.AsLowCostLinq().Where(Items.AreNotEqualTo(x)) // x cannot be nullable type when _items is array of nonnullable
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i != x)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreNotEqualTo((int?)x)) // unfortunately C# is not enough smart currently, so we need use explicit cast to nullable
            );

            CollectionAssert.AreEqual(
                _nullableItems.Where(i => i != null)
                ,
                _nullableItems.AsLowCostLinq().Where(Items.AreNotEqualTo((int?)null)) // unfortunately C# is not enough smart currently, so we need use explicit cast to nullable
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i != "3")
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreNotEqualTo("3"))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => i != null)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreNotEqualTo((string)null))
            );
        }

        [Test]
        public void IsGreatherThan()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i > x)
                ,
                _items.AsLowCostLinq().Where(Items.AreGreatherThan(x))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => "3".CompareTo(i) < 0)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreGreatherThan("3"))
            );
        }

        [Test]
        public void IsGreatherOrEqualThan()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i >= x)
                ,
                _items.AsLowCostLinq().Where(Items.AreGreatherOrEqualThan(x))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => "3".CompareTo(i) <= 0)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreGreatherOrEqualThan("3"))
            );
        }

        [Test]
        public void IsSmallerThan()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i < x)
                ,
                _items.AsLowCostLinq().Where(Items.AreSmallerThan(x))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => "3".CompareTo(i) > 0)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreSmallerThan("3"))
            );
        }

        [Test]
        public void IsSmallerOrEqualThan()
        {
            var x = 3;

            CollectionAssert.AreEqual(
                _items.Where(i => i <= x)
                ,
                _items.AsLowCostLinq().Where(Items.AreSmallerOrEqualThan(x))
            );

            CollectionAssert.AreEqual(
                _stringItems.Where(i => "3".CompareTo(i) >= 0)
                ,
                _stringItems.AsLowCostLinq().Where(Items.AreSmallerOrEqualThan("3"))
            );
        }
    }
}