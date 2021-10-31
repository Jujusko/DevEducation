using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.ArraysTest
{
    class PartTwoTest
    {
        [TestCase(-12274, SomeMocks.Flags.Usual1)]
        [TestCase(-69, SomeMocks.Flags.Usual2)]
        [TestCase(-1585, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(310, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void GetSummNumbsOddIndexesTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartTwo.GetSummNumbsOddIndexes(testedArr);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(SomeMocks.Flags.Usual1)]
        [TestCase(SomeMocks.Flags.Usual2)]
        [TestCase(SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void ReverseArrayTest(SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int[] expected = SomeMocks.ArrayMock.Arrays(op);
            int[] actual;
            int cnt = 0;

            
            actual = Arrays.PartTwo.ReverseArray(testedArr);
            while(cnt < testedArr.Length)
            {
                Assert.AreEqual(actual[cnt], expected[expected.Length - cnt - 1]);
                cnt++;
            }
        }

        [TestCase(317, SomeMocks.Flags.Usual1)]
        [TestCase(-124, SomeMocks.Flags.Usual2)]
        [TestCase(-764, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(332, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void GetSummNumbsNonOddIndexesTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartTwo.GetSummNonOddIndexes(testedArr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(SomeMocks.Flags.Usual1, new int[10] { -23, 45, 333, -12345, 0, 1, 2, 3, 5, 22 })]
        [TestCase(SomeMocks.Flags.Usual2, new int[10] { -61, -91, 28, 26, -53, 4, -70, 2, 32, -10})]
        [TestCase(SomeMocks.Flags.OnlyNegativeNumbers, new int[10] { -135, -377, -131, -669, -164, - 102, -311, -275, -23, -162 })]
        [TestCase(SomeMocks.Flags.OnlyPositiveNUmbers, new int[10] { 67, 85, 64, 45, 40, 83, 75, 74, 86, 23 })]
        public static void ChangeArrayHalvesTest(SomeMocks.Flags op, int[]expected)
        {
            int cnt = 0;
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int []actual = Arrays.PartTwo.ChangeArrayHalves(testedArr);

            while (cnt < testedArr.Length)
            {
                Assert.AreEqual(actual[cnt], expected[cnt]);
                cnt++;
            }
            
        }
    }
}
