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
    }
}


/*
    вернуть длину
    доступ по индексу 
    первый индекс по значению
    изменение по индексу
    реверс (123 -> 321)
    сортировка по возрастанию
    сортировка по убыванию
    удаление по значению первого (?вернуть индекс)
    удаление по значению всех (?вернуть кол-во)
    добавление списка (вашего самодельного) в конец
    добавление списка в начало
    добавление списка по индексу
*/