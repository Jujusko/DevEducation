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
        [TestCase(44, new int[] {44, 44, 44, 44,44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(0, new int[] { 55, 33, 22, 33 }, new int[] { 55, 33, 22, 33, 0 })]
        [TestCase(-9, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public static void AddFrontTest(int value, int[]arr, int []expectedArr)
        {
            DLList expected = new(expectedArr);
            DLList actual = new DLList(arr);
            actual.AddFront(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(44, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44 })]
        [TestCase(0, new int[] { 55, 33, 22, 33 }, new int[] {0, 55, 33, 22, 33})]
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
        public static void DeleteFromEndTest(int[] arr, int [] secArr)
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
        [TestCase(0, new int[] { 1, 2, 3, 4, 5, -9 }, new int[] {0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, new int[] { }, new int[] { 1 })]
        public static void DeleteByIndexTest(int index, int []arr, int[] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, new int[] { 55, 33, 64, 22}, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(0, new int[] { 0, 1, 2, 3, 4, 5, -9 }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
        [TestCase(0, new int[] { }, new int[] { })]
        public static void DeleteFromEndSomeElemsTest(int amount, int []arr, int [] secArr)
        {
            DLList expected = new(arr);
            DLList actual = new(secArr);
            actual.DeleteFromEndSomeElems(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 44, 44, 44, 44, 44 }, new int[] { 44, 44, 44, 44, 44, 44, 44, 44, 44 })]
        [TestCase(2, new int[] { 64, 22, 33, 0 }, new int[] { 55, 33, 64, 22, 33, 0 })]
        [TestCase(7, new int[] {  }, new int[] { 0, 1, 2, 3, 4, 5, -9 })]
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

    }
}
