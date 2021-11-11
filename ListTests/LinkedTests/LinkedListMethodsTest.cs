using NUnit.Framework;
using Nodes;

namespace ListTests
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
        [TestCase(-1, 2, new int[] { -1, -2, -3 }, new int[] { -1, -2, -1, -3 })]
        public static void AddByIndexTest(int value, int index, int[] firsrArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firsrArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(6, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(8, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void GetMinContentIndexTest(int actual, DevEducation.Test.SomeMocks.Flags op)
        {
            int expected;
            int[] array = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            LinkedList test = new LinkedList(array);
            expected = test.GetMinContentIndex();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void GetMaxContentIndexTest(int actual, DevEducation.Test.SomeMocks.Flags op)
        {
            int expected;
            int[] array = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            LinkedList test = new LinkedList(array);
            expected = test.GetMaxContentIndex();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-12345, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(-91, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-669, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(23, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void GetMinContentTest(int actual, DevEducation.Test.SomeMocks.Flags op)
        {
            int expected;
            int[] array = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            LinkedList test = new LinkedList(array);
            expected = test.GetMinContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(333, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(32, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-23, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(86, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void GetMaxContentTest(int actual, DevEducation.Test.SomeMocks.Flags op )
        {
            int expected;
            int[] arr = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            LinkedList test = new LinkedList(arr);
            expected = test.GetMaxContent();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3, 5, 22, 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 0, 0 })]
        public void DeleteFromEndTest(int[] secondArr, int[] firstAr)
        {
            LinkedList expected = new LinkedList(secondArr);
            LinkedList actual = new LinkedList(firstAr);
            actual.DeleteFromEnd();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 0, 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 1 })]
        [TestCase(new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 23, 22, 43, 6457, 0 }, new int[] { 0, 23, 22, 43, 6457, 0 })]
        public void DeleteAtHeadTest(int[] secondArr, int[] firstAr)
        {
            LinkedList expected = new LinkedList(secondArr);
            LinkedList actual = new LinkedList(firstAr);
            actual.DeleteAtHead();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 5, 22 })]
        [TestCase(0, new int[] { 2, 1 }, new int[] { 1 })]
        [TestCase(0, new int[] {1}, new int[] { })]
        [TestCase(4, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] {1, 1, 1, 1, 1, 1 })]
        [TestCase(4, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457 })]
        public static void DeleteByIndexTest(int index, int[] firstArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firstArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3})]
        [TestCase(1, new int[] { 2, 1 }, new int[] { 2 })]
        [TestCase(1, new int[] { 1 }, new int[] { })]
        [TestCase(4, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [TestCase(5, new int[] { 23, 22, 43, 6457, 0 }, new int[] {})]
        public static void DeleteSomeElementsFromEndTest(int index, int[] firstArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firstArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.DeleteSomeElementsFromEnd(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 3, 5, 22 })]
        [TestCase(1, new int[] { 2, 1 }, new int[] {  1 })]
        [TestCase(1, new int[] { 1 }, new int[] { })]
        [TestCase(4, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] {  1, 1, 1 })]
        [TestCase(5, new int[] { 23, 22, 43, 6457, 0 }, new int[] {})]
        [TestCase(0, new int[] { }, new int[] { })]
        public static void DeleteSomeElementsFromHeadTest(int index, int[] firstArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firstArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.DeleteSomeElementsFromHead(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 22 })]
        [TestCase(1, 1, new int[] { 2, 1 }, new int[] { 2 })]
        [TestCase(0, 1, new int[] { 1 }, new int[] {1})]
        [TestCase(4, 2, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        [TestCase(0, 5, new int[] { 23, 22, 43, 6457, 0 }, new int[] { })]
        [TestCase(5, 0, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 23, 22, 43, 6457, 0 })]
        [TestCase(0, 0, new int[] { }, new int[] { })]
        public static void DeleteSomeElementsFromNeededIndexTest(int index, int amount, int[] firstArr, int[] secondArr)
        {
            LinkedList actual = new LinkedList(firstArr);
            LinkedList expected = new LinkedList(secondArr);

            actual.DeleteSomeElementsFromNeededIndex(index, amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(2, new int[] { 2, 1 })]
        [TestCase(1, new int[] { 1 })]
        [TestCase(7, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(0, new int[] { })]
        [TestCase(5, new int[] { 23, 22, 43, 6457, 0 })]
        [TestCase(5, new int[] { -23, -33, -123, -4444, 5555555 })]
        public static void GetLenghtTest(int expected, int [] arr)
        {
            LinkedList test = new LinkedList(arr);
            Assert.AreEqual(expected, test.GetLenght());
        }

        [TestCase(3, 2, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(2, 0, new int[] { 2, 1 })]
        [TestCase(1, 0, new int[] { 1 })]
        [TestCase(1, 6, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(23, 0, new int[] { 23, 22, 43, 6457, 0 })]
        [TestCase(5555555, 4, new int[] { -23, -33, -123, -4444, 5555555 })]
        public static void GetValueByIndexTest(int expected, int index, int[] arr)
        {
            LinkedList test = new LinkedList(arr);
            Assert.AreEqual(expected, test.getValueByIndex(index));
        }

        [TestCase(3, 2, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(2, 0, new int[] { 2, 1 })]
        [TestCase(1, 0, new int[] { 1 })]
        [TestCase(1, 0, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(23, 0, new int[] { 23, 22, 43, 6457, 0 })]
        [TestCase(5555555, 4, new int[] { -23, -33, -123, -4444, 5555555 })]
        public static void GetIndexByContentTest(int value, int expected, int [] arr)
        {
            LinkedList test = new LinkedList(arr);
            Assert.AreEqual(expected, test.GetIndexByContent(value));
        }

        [TestCase(3, 100, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3, 100, 22 })]
        [TestCase(0, 100, new int[] { 2, 1 }, new int[] { 100, 1 })]
        [TestCase(100, 500, new int[] { 1 }, new int[] { 1 })]
        [TestCase(1, 0, new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 0, 1, 1, 1, 1, 1 })]
        [TestCase(0, 123, new int[] { 23, 22, 43, 6457, 0 }, new int[] { 123, 22, 43, 6457, 0 })]
        [TestCase(0, 4, new int[] { 1 }, new int[] { 4 })]

        public static void SetContentByIndex(int index, int value, int [] arr, int[] expected)
        {
            LinkedList expectedL = new LinkedList(expected);
            LinkedList actual = new LinkedList(arr);
            actual.SetContentByIndex(index, value);
            Assert.AreEqual(expectedL, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 22, 5, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        public static void ReverseListTest(int [] actualArr, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList actual = new LinkedList(actualArr);
            actual.ReverseList();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 22, 33, 11, 54, 1, 0, 134 }, new int[] { 0, 1, 11, 22, 33, 54, 134 })]
        public static void SortFromMinToMaxTest(int[] actualArr, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList actual = new LinkedList(actualArr);
            actual.SortFromMinToMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 22, 5, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 22, 33, 11, 54, 1, 0, 134 }, new int[] { 134, 54, 33, 22, 11, 1, 0 })]
        public static void SortFromMaxToMinTest(int[] actualArr, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList actual = new LinkedList(actualArr);
            actual.SortFromMaxToMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(134, 6, new int[] { 22, 33, 11, 54, 1, 0, 134 })]
        [TestCase(22, 0, new int[] { 22, 33, 11, 54, 1, 0, 134 })]
        public static void DeleteOneNodeByContentTest(int value,int exVal, int[] actualArr)
        {
            int actual;
            LinkedList actualList = new LinkedList(actualArr);
            actual = actualList.DeleteOneNodeByContent(value);
            Assert.AreEqual(exVal, actual);
        }

        [TestCase(2, 1, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(11, 2, new int[] { 22, 33, 11, 54, 11, 0, 134 })]
        [TestCase(543, 0, new int[] { 22, 33, 11, 54, 1, 0, 134 })]
        public static void DeleteAllNodesWithSameContentTest(int value, int expected, int [] arr)
        {
            int actual;
            LinkedList actualList = new LinkedList(arr);
            actual = actualList.DeleteAllNodesWithSameContent(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3}, new int[] { 1, 2, 3, 5, 22, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(new int[] {}, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3})]
        [TestCase(new int[] { }, new int[] {  }, new int[] {})]
        public static void AddFront(int[] testAr, int [] addToTest, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList added = new LinkedList(addToTest);
            LinkedList actual = new LinkedList(testAr);
            actual.AddFront(added);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3 }, new int[] {1, 2, 3, 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public static void AddBackTest(int[] testAr, int[] addToTest, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList added = new LinkedList(addToTest);
            LinkedList actual = new LinkedList(testAr);
            actual.AddBack(added);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 1, 2, 3, 5, 22 })]
        [TestCase(1, new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(1, new int[] { 44 }, new int[] { 1, 2, 3 }, new int[] { 44, 1, 2, 3 })]
        [TestCase(99, new int[] { }, new int[] { }, new int[] { })]
        public static void AddByIndexTest(int index, int[] testAr, int[] addToTest, int[] expectedArr)
        {
            LinkedList expected = new LinkedList(expectedArr);
            LinkedList added = new LinkedList(addToTest);
            LinkedList actual = new LinkedList(testAr);
            actual.AddByIndex(index, added);
            Assert.AreEqual(expected, actual);
        }
    }
}

