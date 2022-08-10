using ArrayOrderComparer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class ArrayOrderComparerTests
    {
        private string[] GetIndividualsArray()
        {
            return new string[] {
                "Sonia Maria Wood Dempster",
                "Laruen Ana Eagles Beneke",
                "Maurício Luís dos Santos",
                "Jorge Herrera"
            };
        }

        [TestMethod]
        public void order_should_be_ignored_when_order_array_is_null()
        {
            var individualsName = GetIndividualsArray();
            individualsName.SortWithOrder(null);

            CollectionAssert.AreEqual(GetIndividualsArray(), individualsName);
        }

        [TestMethod]
        public void order_should_be_ignored_when_array_is_empty()
        {
            var individualsName = new string[] { };
            individualsName.SortWithOrder(null);

            CollectionAssert.AreEqual(new string[] { }, individualsName);
        }

        [TestMethod]
        public void order_when_have_only_one_argument()
        {
            var individualsName = GetIndividualsArray();
            var order = new int[] { 1 };
            individualsName.SortWithOrder(order);

            Assert.AreEqual(individualsName[0], "Laruen Ana Eagles Beneke");
        }

        [TestMethod]
        public void order_when_have_multiple_arguments()
        {
            var individualsName = GetIndividualsArray();
            var order = new int[] { 4, 3, 2, 1 };
            individualsName.SortWithOrder(order);

            var reversedArray = GetIndividualsArray();
            Array.Reverse(reversedArray);

            CollectionAssert.AreEqual(reversedArray, individualsName);
        }

        [TestMethod]
        public void order_when_have_random_numbers()
        {
            var individualsName = GetIndividualsArray();
            var order = new int[] { 1, 0, 3, 2 };
            individualsName.SortWithOrder(order);

            CollectionAssert.AreEqual(new string[]{
                "Laruen Ana Eagles Beneke",
                "Sonia Maria Wood Dempster",
                "Jorge Herrera",
                "Maurício Luís dos Santos"
            }, individualsName);
        }
    }
}