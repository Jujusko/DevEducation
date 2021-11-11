using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nodes;

namespace ListTests.LinkedTests
{
    class LinkedListMethodsNegativeTests
    {
        [TestCase(4322, 213, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(1, -1, new int[] { 1 })]

        public static void AddByIndexNegativeTest(int value, int index, int[] firsrArr)
        {
            LinkedList actual = new LinkedList(firsrArr);
       
            Assert.Throws<ArgumentException>(() => actual.AddByIndex(index, value));
        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        public static void DeleteSomeElementsFromEndNegativeTest(int amount, int [] firstArr)
        {
            LinkedList actual = new LinkedList(firstArr);

            Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteSomeElementsFromEnd(amount));
        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        public static void DeleteSomeElementsFromHeadNegativeTest(int amount, int[] firstArr)
        {
            LinkedList actual = new LinkedList(firstArr);
            Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteSomeElementsFromEnd(amount));

        }

        [TestCase(4322, 2, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(1, 4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, 2, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(1, -123, new int[] { 1, 2, 3, 5, 22 })]
        public void DeleteSomeElementsFromNeededIndexNegativeTest(int index, int amount, int [] firstArr)
        {
            LinkedList actual = new LinkedList(firstArr);

            Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteSomeElementsFromNeededIndex(index, amount));
        }


        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(0, new int[] { 1, 2, 3, 5, 22 })]
        public void DeleteOneNodeByContentNegativeTest(int value, int[] arr)
        {
            LinkedList actual = new LinkedList(arr);

            Assert.Throws<ArgumentException>(() => actual.DeleteOneNodeByContent(value));
        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(0, new int[] { 1, 2, 3, 5, 22 })]
        public void DeleteAllNodesWithSameContentNegativeTest(int value, int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<ArgumentException>(() => actual.DeleteAllNodesWithSameContent(value));

        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(0, new int[] {  })]
        public void getValueByIndexNegativeTest(int value, int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<Exception>(() => actual.getValueByIndex(value));
        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(0, new int[] { })]
        public void GetIndexByContentNegativeTest(int index, int[] arr)
        {
            LinkedList actual = new LinkedList(arr);

            Assert.Throws<Exception>(() => actual.getValueByIndex(index));
        }

        [TestCase(4322, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(0, new int[] { })]
        public void SetContentByIndexNegativeTest(int index, int[] arr)
        {
            LinkedList actual = new LinkedList(arr);

            Assert.Throws<Exception>(() => actual.SetContentByIndex(index, 123));
        }

        [TestCase(new int[] { })]
        public void GetMaxContentNegativeTest(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<Exception>(() => actual.GetMaxContent());
        }

        [TestCase(new int[] { })]
        public void GetMinContentNegativeTest(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<Exception>(() => actual.GetMinContent());
        }

        [TestCase(new int[] { })]
        public void GetMaxContentIndexNegativeTest(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<Exception>(() => actual.GetMaxContentIndex());
        }

        [TestCase(new int[] { })]
        public void GetMinContenIndextNegativeTest(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<Exception>(() => actual.GetMinContentIndex());
        }
    }
}
