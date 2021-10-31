using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.ArraysTest
{
    class PartOneTest
    {
        [TestCase(-12345, SomeMocks.Flags.Usual1)]
        [TestCase(-91, SomeMocks.Flags.Usual2)]
        [TestCase(-669, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(23, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void FindMinNumbTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartOne.FindMinNumb(testedArr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(333, SomeMocks.Flags.Usual1)]
        [TestCase(32, SomeMocks.Flags.Usual2)]
        [TestCase(-23, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(86, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void FindMaxNumbTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartOne.FindMaxNumb(testedArr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, SomeMocks.Flags.Usual1)]
        [TestCase(6, SomeMocks.Flags.Usual2)]
        [TestCase(8, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(4, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void FindIndexMinNumbTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartOne.FindIndexMinNumb(testedArr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, SomeMocks.Flags.Usual1)]
        [TestCase(3, SomeMocks.Flags.Usual2)]
        [TestCase(3, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(3, SomeMocks.Flags.OnlyPositiveNUmbers)]
        public static void FindIndexMaxNumbTest(int expected, SomeMocks.Flags op)
        {
            int[] testedArr = SomeMocks.ArrayMock.Arrays(op);
            int actual;

            actual = Arrays.PartOne.FindIndexMaxNumb(testedArr);
            Assert.AreEqual(expected, actual);
        }
    }
}
