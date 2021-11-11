using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using List;

namespace ListTests
{
    class LatPartTest
    {
        //[TestCase(new int[] { 1,2,3,4,5}, new int[] { 1, 2, 3}, new int[] { 4, 5 })]
        //public static void AddFrontTest(int[] a, int []b, int []c)
        //{
        //    ArrayList expected = new ArrayList(a);
        //    ArrayList actual = new ArrayList(b);
        //    ArrayList addToActual = new ArrayList(c);
        //    actual.AddOwnListAtFront(addToActual);
        //    Assert.AreEqual(expected, actual);
        //}


        [TestCase(0, 1, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(9, -53, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(5, -135, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, 23, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, 10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void GetContentByIndexTest(int index, int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] arr = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            ArrayList test = new(arr);
            int actual = test.GetContentByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(9, -53, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(5, -135, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, 23, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, 10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void FindFirstIndexByThisContentTest(int expected, int content, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] arr = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            ArrayList test = new(arr);
            int actual = test.FindFirstIndexByThisContent(content);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 123, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(0, 999, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(5, 333, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, 235, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, 120, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void ChangeContentByIndexTest(int index, int value, DevEducation.Test.SomeMocks.Flags op)
        {
            ArrayList actual;
            ArrayList expected;
            int[] firstArr = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            actual = new ArrayList(firstArr);
            firstArr[index] = value;
            expected = new ArrayList(firstArr);
            actual.ChangeContentByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 33, 12, 45, -123, 0, 65 }, new int[] { 65, 0, -123, 45, 12, 33 })]
        public static void ReverseListTest(int[] firstAr, int[] secondAr)
        {
            ArrayList actual;
            ArrayList expected;

            actual = new(firstAr);
            expected = new(secondAr);
            actual.ReverseArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(333, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(32, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-23, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(86, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void FindMaxContentTest(int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            ArrayList actualAr;
            actualAr = new(ar);
            actual = actualAr.FindMaxContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-12345, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(-91, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-669, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(23, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void FindMinContentTest(int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            ArrayList actualAr;
            actualAr = new(ar);
            actual = actualAr.FindMinContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(3, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void FindIndexOfMaxContentTest(int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            ArrayList actualAr;
            actualAr = new(ar);
            actual = actualAr.FindIndexOfMaxContent();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(6, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(8, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(0, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void FindIndexOfMinContentTest(int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            ArrayList actualAr;
            actualAr = new(ar);
            actual = actualAr.FindIndexOfMinContent();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 33, 2, 0, -32, 990 }, new int[] { -32, 0, 2, 11, 33, 990 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 33, 2, 44, 5, 123, 66 }, new int[] { 1, 2, 5, 33, 44, 66, 123 })]

        public static void SortByAscendingTest(int[] firstAr, int[] expArr)
        {
            ArrayList actual = new(firstAr);
            ArrayList expected = new ArrayList(expArr);
            actual.SortByAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 11, 33, 2, 0, -32, 990 }, new int[] { -32, 0, 2, 11, 33, 990 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 33, 2, 44, 5, 123, 66 }, new int[] { 1, 2, 5, 33, 44, 66, 123 })]

        public static void SortByDecreaseTest(int[] firstAr, int[] expArr)
        {
            Array.Reverse(expArr);
            ArrayList actual = new(firstAr);
            ArrayList expected = new ArrayList(expArr);
            actual.SortByDecrease();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2,1, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(32, 3, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-102, 0, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(40, 9, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, 0, DevEducation.Test.SomeMocks.Flags.OneElem)]
        public static void DeleteFirstElemByContentTest(int value, int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            ArrayList actList;
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            actList = new(ar);
            actual = actList.DeleteFirstElemByContent(value);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(2, 1, DevEducation.Test.SomeMocks.Flags.Usual1)]
        [TestCase(32, 1, DevEducation.Test.SomeMocks.Flags.Usual2)]
        [TestCase(-102, 1, DevEducation.Test.SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(40, 1, DevEducation.Test.SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(10, 1, DevEducation.Test.SomeMocks.Flags.OneElem)]
        [TestCase(1, 7, DevEducation.Test.SomeMocks.Flags.SameValue)]
        public static void DeleteAllElemsWithGivenContentTest(int value, int expected, DevEducation.Test.SomeMocks.Flags op)
        {
            ArrayList actList;
            int[] ar = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            int actual;
            actList = new(ar);
            actual = actList.DeleteAllElemsWithGivenContent(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 5, 22, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public static void AddFront(int[] testAr, int[] addToTest, int[] expectedArr)
        {
            ArrayList expected = new ArrayList(expectedArr);
            ArrayList added = new ArrayList(addToTest);
            ArrayList actual = new ArrayList(testAr);
            actual.AddFront(added);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public static void AddBackTest(int[] testAr, int[] addToTest, int[] expectedArr)
        {
            ArrayList expected = new ArrayList(expectedArr);
            ArrayList added = new ArrayList(addToTest);
            ArrayList actual = new ArrayList(testAr);
            actual.AddBack(added);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 2, 3, 5, 22 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 1, 2, 3, 5, 22 })]
        [TestCase(1, new int[] { 1, 2, 3, 5, 22 }, new int[] { }, new int[] { 1, 2, 3, 5, 22 })]
        [TestCase(1, new int[] { 44 }, new int[] { 1, 2, 3 }, new int[] { 44, 1, 2, 3 })]
        [TestCase(99, new int[] { }, new int[] { }, new int[] { })]
        public static void AddByIndexTest(int index, int[] testAr, int[] addToTest, int[] expectedArr)
        {
            ArrayList expected = new ArrayList(expectedArr);
            ArrayList added = new ArrayList(addToTest);
            ArrayList actual = new ArrayList(testAr);
            actual.AddByIndex(added, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
/*

добавление списка (вашего самодельного) в конец
добавление списка в начало
добавление списка по индексу
*/