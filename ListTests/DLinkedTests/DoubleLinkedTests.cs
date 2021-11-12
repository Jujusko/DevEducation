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
    }
}
