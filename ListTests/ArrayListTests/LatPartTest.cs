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
            int [] firstArr = DevEducation.Test.SomeMocks.ArrayMock.Arrays(op);
            actual = new ArrayList(firstArr);
            firstArr[index] = value;
            expected = new ArrayList(firstArr);
            actual.ChangeContentByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
/*


изменение по индексу
реверс (123 -> 321)
поиск значения максимального элемента
поиск значения минимального элемента
поиск индекс максимального элемента
поиск индекс минимального элемента
сортировка по возрастанию
сортировка по убыванию
удаление по значению первого (?вернуть индекс)
удаление по значению всех (?вернуть кол-во)
добавление списка (вашего самодельного) в конец
добавление списка в начало
добавление списка по индексу
*/