using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.ArraysTest
{
    class SomeSortsTest
    {
        [TestCase(SomeMocks.Flags.Usual1, new int[10] { -12345, -23, 0, 1, 2, 3, 5, 22, 45, 333 })]
        [TestCase( SomeMocks.Flags.Usual2, new int[10] { -91, -70, -61, -53, -10, 2, 4, 26, 28, 32})]
        [TestCase(SomeMocks.Flags.OnlyNegativeNumbers, new int[10] { -669, -377, -311, -275, -164, -162, -135, -131, -102, -23})]
        [TestCase(SomeMocks.Flags.OnlyPositiveNUmbers, new int[10] { 23, 40, 45, 64, 67, 74, 75, 83, 85, 86})]
        public static void BubbleSortTest(SomeMocks.Flags op, int [] expected)
        {
            int[] actual;
            int cnt;

            cnt = 0;
            actual = Arrays.SomeSorts.BubbleSort(SomeMocks.ArrayMock.Arrays(op));
            while (cnt < actual.Length)
            {
                Assert.AreEqual(actual[cnt], expected[cnt]);
                cnt++;
            }
        }

        [TestCase(SomeMocks.Flags.Usual1, new int[10] { -12345, -23, 0, 1, 2, 3, 5, 22, 45, 333 })]
        [TestCase(SomeMocks.Flags.Usual2, new int[10] { -91, -70, -61, -53, -10, 2, 4, 26, 28, 32 })]
        [TestCase(SomeMocks.Flags.OnlyNegativeNumbers, new int[10] { -669, -377, -311, -275, -164, -162, -135, -131, -102, -23 })]
        [TestCase(SomeMocks.Flags.OnlyPositiveNUmbers, new int[10] { 23, 40, 45, 64, 67, 74, 75, 83, 85, 86 })]
        public static void SelectSortTest(SomeMocks.Flags op, int[] expected)
        {
            int[] actual;
            int cnt;

            cnt = 0;
            actual = Arrays.SomeSorts.SelectSort(SomeMocks.ArrayMock.Arrays(op));
            while (cnt < actual.Length)
            {
                Assert.AreEqual(actual[cnt], expected[cnt]);
                cnt++;
            }
        }
    }
}
