using NUnit.Framework;
using Nodes;

namespace LinkedListTests
{
    public class Tests
    {
        [TestCase(0, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3, 5, 22, 0 })]
        [TestCase(2, new int[] { 1 }, new int[] { 1, 2 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 0, 0 })]
        public void AddTest(int a, int[] firstAr, int []secondArr)
        {
            LinkedList expected = new LinkedList(secondArr);
            LinkedList actual = new LinkedList(firstAr);
            actual.AddFront(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 2, 3, 5, 22 }, new int[] { 0, 1, 2, 3, 5, 22 })]
        [TestCase(2, new int[] { 1 }, new int[] { 2, 1 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 0, 23, 22, 43, 6457, 0 })]

        public static void ListAddBackTest(int a, int[] firstArr, int[] secondArr)
        {
            LinkedList expected = new LinkedList(secondArr);
            LinkedList actual = new LinkedList(firstArr);
            actual.AddBack(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(1, 1, new int[] { 1 }, new int[] { 1, 1 })]
        [TestCase(1, 0, new int[] { }, new int[] { 1 })]
        [TestCase(1, 3, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(4, 4, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 4, 0 })]
        public static void ListAddByIndexTest(int value, int index, int[] firsrArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firsrArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(0, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] {1 })]
        [TestCase(0, new int[] { 1,2,3,4,5,6,7,8})]
        [TestCase(8, new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public static void GetMinContentIndexTest(int actual, int[] array)
        {
            int expected;
            LinkedList test = new LinkedList(array);
            expected = test.GetMinContentIndex();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(0, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] { 1 })]
        [TestCase(7, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(0, new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public static void GetMaxContentIndexTest(int actual, int[] array)
        {
            int expected;
            LinkedList test = new LinkedList(array);
            expected = test.GetMaxContentIndex();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(1, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(1, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(0, new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public static void GetMinContentTest(int actual, int[] array)
        {
            int expected;
            LinkedList test = new LinkedList(array);
            expected = test.GetMinContent();
            Assert.AreEqual(expected, actual);
        }
    }
}