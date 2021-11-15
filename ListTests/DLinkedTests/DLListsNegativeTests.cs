using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nodes;

namespace ListTests.DLinkedTests
{
    class DLListsNegativeTests
    {
        [TestCase(123, new int[] {1, 2, 3, 123 ,0, 55})]
        [TestCase(-1, new int[] {1, 2, 3, 123 ,0, 55})]
        [TestCase(7, new int[] {1, 2, 3, 123 ,0, 55})]
        public static void AddByIndexNegativeTest(int index, int [] arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.AddByIndex(index, 11));

        }
        [TestCase(new int[] { })]
        public static void DeleteFromEndNegativeTest( int[] arr)
        {
            DLList test = new(arr);
            Assert.Throws<Exception>(() => test.DeleteFromEnd());

        }

        [TestCase(new int[] { })]
        public static void DeleteFromHeadNegativeTest(int[] arr)
        {
            DLList test = new(arr);
            Assert.Throws<Exception>(() => test.DeleteFromHead());
        }


        [TestCase(123, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(7, new int[] { 1, 2, 3, 123, 0, 55 })]
        public static void DeleteByIndexNegativeTest(int index, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.DeleteByIndex(index));
        }

        [TestCase(123, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(7, new int[] { 1, 2, 3, 123, 0, 55 })]
        public static void DeleteFromEndSomeElemsNegativeTest(int amount, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.DeleteFromEndSomeElems(amount));
        }

        [TestCase(123, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(7, new int[] { 1, 2, 3, 123, 0, 55 })]
        public static void DeleteFromHeadSomeElemsNegativeTest(int amount, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.DeleteFromEndSomeElems(amount));
        }

        [TestCase(123, 0, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, 2, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(2, 333, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(1, 8, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(8, 1, new int[] { 1, 2, 3, 123, 0, 55 })]
        public static void DeleteByIndexSomeElemsNegativeTest(int amount, int index, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.DeleteByIndexSomeElems(index, amount));
        }

        [TestCase(124, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(0, new int[] { 1, 2, 3, 123, 3, 55 })]
        public static void GetIndexByValueNegativeTest(int value, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<ArgumentException>(() => test.GetIndexByValue(value));
        }

        [TestCase(123, 0, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1, 2, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(22, 333, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(13, 8, new int[] { 1, 2, 3, 123, 0, 55 })]
        [TestCase(-1222, 1, new int[] { 1, 2, 3, 123, 0, 55 })]
        public static void ChangeByIndexNegativeTest(int index, int value, int[]arr)
        {
            DLList test = new(arr);
            Assert.Throws<Exception>(() => test.ChangeByIndex(index, value));
        }

        [TestCase(new int[] { })]
        public static void GetMaxValueNegativeTest( int[] arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.GetMaxValue());
        }

        [TestCase(new int[] { })]
        public static void GetMinValueNegativeTest(int[] arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.GetMinValue());
        }

        [TestCase(new int[] { })]
        public static void FindIndexOfMaxContentNegativeTest(int[] arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.FindIndexOfMaxContent());
        }

        [TestCase(new int[] { })]
        public static void FindIndexOfMinContentNegativeTest(int[] arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.FindIndexOfMinContent());
        }

        [TestCase(1 ,new int[] {2, 3, 4, 5, 6 })]
        [TestCase(-1 ,new int[] {2, 3, 4, 5, 6 })]
        [TestCase(1 ,new int[] {2})]
        [TestCase(1 ,new int[] {})]
        public static void DeleteOneByValueNegativeTest(int value, int[]arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.DeleteOneByValue(value));
        }

        [TestCase(1, new int[] { })]
        public static void DeleteAllByValueNegativeTest(int value, int[] arr)
        {
            DLList test = new(arr);

            Assert.Throws<Exception>(() => test.DeleteAllByValue(value));
        }

        [TestCase(4, new int[] {1, 2, 3}, new int[] {4, 5, 6, 7, 8})]
        [TestCase(-1, new int[] {1, 2, 3}, new int[] {4, 5, 6, 7, 8})]
        public static void AddByIndexNegativeTest(int index, int[]arr, int[]secArr)
        {
            DLList test = new(arr);
            DLList toAdd = new(secArr);
            Assert.Throws<Exception>(() => test.AddByIndex(toAdd, index));
        }
    }
}
