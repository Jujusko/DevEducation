using NUnit.Framework;
using System;
using DevEducation;
using List;

namespace ListTests
{
    public class PartOneTests
    {
        #region AddValueMethods
        [TestCase(0, new int[] { 1, 2, 3, 5, 22}, new int[] { 1, 2, 3, 5, 22, 0})]
        [TestCase(2, new int[] { 1}, new int[] { 1, 2 })]
        [TestCase(1, new int[] {  }, new int[] { 1 })]
        [TestCase(1, new int[] { 1,1,1,1,1,1,1}, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] {23,22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 0, 0 })]
        public static void AddFrontTest(int value, int[] firsrArr, int [] secondArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.AddFront(value);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0, new int[] { 1, 2, 3, 5, 22 }, new int[] {0, 1, 2, 3, 5, 22})]
        [TestCase(2, new int[] { 1 }, new int[] { 2, 1 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] { 23, 22, 43, 6457, 0 }, new int[] {0, 23, 22, 43, 6457, 0 })]
        public static void ListAddBackTest(int value, int[] firsrArr, int[] secondArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.ListAddBack(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(1, 1, new int[] { 1 }, new int[] { 1, 1 })]
        [TestCase(1, 0, new int[] { }, new int[] { 1 })]
        [TestCase(1, 3, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(4, 4, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 4, 0 })]
        public static void ListAddByIndexTest(int value,int index, int[] firsrArr, int[] secondArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        #endregion



        #region DeleteValueMethods
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3, 5, 22, 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 0, 0 })]
        public static void DeleteAtEndTest(int[] secondArr, int[] firsrArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteAtEnd();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 0, 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 1 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 23, 22, 43, 6457, 0 }, new int[] { 0, 23, 22, 43, 6457, 0 })]
        public static void DeleteAtHead(int[] secondArr, int[] firsrArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteAtHead();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 0, 3, 5, 22 })]
        [TestCase(1, new int[] { 1 }, new int[] { 1, 1 })]
        [TestCase(0, new int[] { }, new int[] { 1 })]
        [TestCase(3, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(4, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 4, 0 })]
        public static void DeleteByIndexTest(int index, int[] secondArr, int[] firsrArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 5}, new int[] { 1, 2, 3, 5, 22, 1 })]
        [TestCase(1, new int[] { 1 }, new int[] { 1, 1 })]
        [TestCase(0, new int[] { 1 }, new int[] { 1 })]
        [TestCase(2, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(4, new int[] { }, new int[] { 23, 22, 43, 6457})]
        public static void DeleteSomeIndexesFromEndTest (int indexes, int[] secondArr, int[] firsrArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteSomeIndexesFromEnd(indexes);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 1, 2, 3, 5, 6, 7, 8 }, new int[] { 3, 5, 6, 7, 8 })]
        [TestCase(1, new int[] { 1, 1 }, new int[] { 1 })]
        [TestCase(0, new int[] { 1 }, new int[] { 1 })]
        [TestCase(6, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { })]
        [TestCase(4, new int[] { 32, 44, 11, 11, 54, 3, 78}, new int[] { 54, 3, 78 })]
        public static void DeleteSomeIndexesFromStartTest(int indexes, int[] firsrArr, int[] secondArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteSomeIndexesFromStart(indexes);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1, new int[] { 1, 2, 3, 5, 6, 7, 8 }, new int[] { 1, 2, 5, 6, 7, 8 })]
        [TestCase(1, 1, new int[] { 1, 1 }, new int[] { 1 })]
        [TestCase(0, 0, new int[] { 1 }, new int[] { 1 })]
        [TestCase(0, 6, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { })]
        [TestCase(4, 2, new int[] { 32, 44, 11, 11, 54, 3, 78 }, new int[] { 32, 44, 11, 11, 78 })]
        public static void DeleteSomeIndexesFromNeededIndexTest(int start, int amountIndexes, 
             int[] firsrArr, int[] secondArr)
        {
            ArrayList actual = new ArrayList(firsrArr);
            ArrayList expected = new ArrayList(secondArr);

            actual.DeleteSomeIndexesFromNeededIndex(start, amountIndexes);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}