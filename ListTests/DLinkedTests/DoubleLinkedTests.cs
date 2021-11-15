using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nodes;

namespace ListTests.DLinkedTests
{
    class DoubleLinkedTests
    {
        [TestCase(44, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(0, new int[] { 55, 33, 22, 33 }, new int[] { 55, 33, 22, 33, 0 })]
        [TestCase(-9, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public static void AddFrontTest(int value, int[] arr, int[] expectedArr)
        {
            DLList expected = new(expectedArr);
            DLList actual = new DLList(arr);
            actual.AddFront(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(44, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(0, new int[] { 55, 33, 22, 33 }, new int[] { 0, 55, 33, 22, 33 })]
        [TestCase(-9, new int[] { 1, 2, 3, 4, 5 }, new int[] { -9, 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public static void AddBackTest(int value, int[] arr, int[] expectedArr)
        {
            DLList expected = new(expectedArr);
            DLList actual = new DLList(arr);
            actual.AddBack(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 44, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, 0, new int[] { 55, 33, 22, 33 }, new int[] { 55, 33, 0, 22, 33 })]
        [TestCase(5, -9, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, 1, new int[] { }, new int[] { 1 })]
        public static void AddByIndexTest(int index, int value, int[] arr, int[] expectedArr)
        {
            DLList expected = new(expectedArr);
            DLList actual = new DLList(arr);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(new int[] { 55, 33, 22, 33 }, new int[] { 55, 33, 22, 33, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        public static void DeleteFromEndTest(int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteFromEnd();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(new int[] { 33, 22, 33, 0 }, new int[] { 55, 33, 22, 33, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, -9 }, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        public static void DeleteFromHeadTest(int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteFromHead();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, new int[] { 55, 33, 22, 33, 0 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(0, new int[] { 1, 2, 3, 4, 5, -9 }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, new int[] { }, new int[] { 1 })]
        public static void DeleteByIndexTest(int index, int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, new int[] { 55, 33, 64, 22 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(0, new int[] { 0, 1, 2, 3, 4, 5, -9 }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        public static void DeleteFromEndSomeElemsTest(int amount, int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteFromEndSomeElems(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, new int[] { 64, 22, 33, 0 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(7, new int[] { }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, new int[] { }, new int[] { })]
        public static void DeleteFromHeadSomeElemsTest(int amount, int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteFromHeadSomeElems(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 2, new int[] { 44, 44, 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, 2, new int[] { 55, 33, 33, 0 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(0, 2, new int[] { 2, 3, 4, 5, -9 }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, 0, new int[] { }, new int[] { })]
        public static void DeleteByIndexSomeElemsTest(int index, int amount, int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteByIndexSomeElems(index, amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(44, 0, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(64, 2, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(0, 0, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(1, 0, new int[] { 1 })]
        public static void GetIndexByValueTest(int value, int expected, int[] arr)
        {
            DLList expectedList;
            DLList actualList;
            int actual;

            expectedList = new(arr);
            actualList = new(arr);
            actual = actualList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCase(666, 2, new int[] { 44, 44, 666, 44, 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, 0, new int[] { 2, 33, 64, 22, 33, 0 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(999, 2, new int[] { 0, 1, 999, 3, 4, 5, -9 }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, 0, new int[] { 0 }, new int[] { 1 })]
        public static void ChangeByIndexTest(int value, int index, int[] arr, int[] secArr)
        {
            DLList expectedList;
            DLList actualList;

            expectedList = new(arr);
            actualList = new(secArr);
            actualList.ChangeByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, new int[] { 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { 1, 0 }, new int[] { 0, 1 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 1, 2 }, new int[] { 2, 1, 0 })]
        public static void ReverseTest(int[] arr, int[] secArr)
        {
            DLList expectedList;
            DLList actualList;

            expectedList = new(arr);
            actualList = new(secArr);
            actualList.Reverse();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCase(7, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(1, new int[] { 1 })]
        [TestCase(6, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(99, new int[] { 99, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { -1, -32, 1, 0, 0 })]

        public static void GetMaxValueTest(int expected, int[] arr)
        {
            DLList actualList;
            int actual;

            actualList = new(arr);
            actual = actualList.GetMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(1, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(1, new int[] { 99, 1, 2, 3, 4 })]
        [TestCase(-32, new int[] { -1, -32, 1, 0, 0 })]

        public static void GetMinValueTest(int expected, int[] arr)
        {
            DLList actualList;
            int actual;

            actualList = new(arr);
            actual = actualList.GetMinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(0, new int[] { 1 })]
        [TestCase(5, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(0, new int[] { 99, 1, 2, 3, 4 })]
        [TestCase(3, new int[] { -1, -32, 1, 0, 0 })]
        [TestCase(6, new int[] { 123, -1, -32, -123, 1, 0, 1234 })]
        public static void FindIndexOfMaxContentTest(int expected, int[] arr)
        {
            DLList actualList;
            int actual;

            actualList = new(arr);
            actual = actualList.FindIndexOfMaxContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(0, new int[] { 1 })]
        [TestCase(0, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(1, new int[] { 99, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { -1, -32, 1, 0, 0 })]
        [TestCase(3, new int[] { 123, -1, -32, -1000, -123, 1, 0, 1234 })]
        public static void FindIndexOfMinContentTest(int expected, int[] arr)
        {
            DLList actualList;
            int actual;

            actualList = new(arr);
            actual = actualList.FindIndexOfMinContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6}, new int[] { 6, 5, 4, 3, 2, 1})]
        [TestCase(new int[] {1, 2, 23, 33, 55}, new int[] { 1, 2, 55, 33, 23 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1}, new int[] { 1, 1, 1, 1, 1})]
        [TestCase(new int[] { 1, 33}, new int[] { 1, 33})]
        public static void SortByAscendingTest(int[]arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.SortByAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 55, 33, 23, 2, 1 }, new int[] { 1, 2, 23, 33, 55 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 33, 1 }, new int[] { 1, 33 })]
        public static void SortByDescendingTest(int[] arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.SortByDescending();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(6,new int[] {1, 2, 3, 4, 5  }, new int[] {1, 2, 3, 4, 5, 6 })]
        [TestCase(0,new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(0,new int[] { }, new int[] {0 })]
        [TestCase(1,new int[] { 1, 1, 1, 1, 1, 1 }, new int[] {1, 1, 1, 1, 1, 1, 1})]
        [TestCase(-95,new int[] { 123, 54, 44, 987, 5 }, new int[] { 123, 54, -95, 44, 987, 5 })]
        public static void DeleteOneByValueTest(int value, int []arr, int[]secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteOneByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6,1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(0,1, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(0,1, new int[] { }, new int[] { 0 })]
        [TestCase(0, 8, new int[] { }, new int[] { 0, 0,0,0,0,0,0,0 })]
        [TestCase(1, 7,  new int[] { }, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(-95,2, new int[] { 123, 54, 44, 987, 5 }, new int[] {-95,  123, 54, -95, 44, 987, 5 })]
        public static void DeleteAllByValueTest(int value,int expected, int[] arr, int[] secArr)
        {
            int act;
            DLList expectedList = new(arr);
            DLList actual = new(secArr);
            act = actual.DeleteAllByValue(value);
            Assert.AreEqual(expectedList, actual);
            Assert.AreEqual(expected, act);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 4, 5}, new int[] { 1, 2, 3, 4, 5})]
        [TestCase(new int[] { 1, 2, 3}, new int[] {}, new int[] { 1, 2, 3})]
        [TestCase(new int[] {}, new int[] { 4, 5 }, new int[] {4, 5 })]

        public static void AddFrontForListTest(int [] arr, int[]secArr, int[]expectedAr)
        {
            DLList expected = new(expectedAr);
            DLList actual = new(arr);
            DLList toAdd = new(secArr);

            actual.AddFront(toAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] {4,5,1,2,3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 4, 5 }, new int[] { 4, 5 })]

        public static void AddBackForListTest(int[] arr, int[] secArr, int[] expectedAr)
        {
            DLList expected = new(expectedAr);
            DLList actual = new(arr);
            DLList toAdd = new(secArr);

            actual.AddBack(toAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 1,4, 5, 2, 3 })]
        [TestCase(0, new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(0,new int[] { }, new int[] { 4, 5 }, new int[] { 4, 5 })]

        public static void AddByIndexForListTest(int index, int[] arr, int[] secArr, int[] expectedAr)
        {
            DLList expected = new(expectedAr);
            DLList actual = new(arr);
            DLList toAdd = new(secArr);

            actual.AddByIndex(toAdd, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
