using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.DoubleArrays
{
     public class DoubleArrayTest
    {
        #region Max Content In Double array testss

        [TestCase(49, SomeMocks.Flags.Usual1)]
        [TestCase(99, SomeMocks.Flags.Usual2)]
        [TestCase(-6, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(99, SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(83, SomeMocks.Flags.NonSquare)]
        [TestCase(2, SomeMocks.Flags.OneInAll)]
        public static void FindMaxNumberTest(int expected, SomeMocks.Flags op)
        {
            int[,] testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            int actual;
            
            actual = DevEducation.DoubleArrays.DoubleArray.FindMaxNumber(testArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(SomeMocks.Flags.EmptyArray)]
        public static void FindMaxNumberNegativeTest(SomeMocks.Flags op)
        {
            int[,] testArray;

            testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            Assert.Throws<ArgumentException>(() => DevEducation.DoubleArrays.DoubleArray.FindMaxNumber(testArray));
        }
        #endregion

        #region Min Content In Double array testss

        [TestCase(0, SomeMocks.Flags.Usual1)]
        [TestCase(2, SomeMocks.Flags.Usual2)]
        [TestCase(-100, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(2, SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(-100, SomeMocks.Flags.NonSquare)]
        [TestCase(2, SomeMocks.Flags.OneInAll)]
        public static void FindMinNumberTest(int expected, SomeMocks.Flags op)
        {
            int[,] testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            int actual;

            actual = DevEducation.DoubleArrays.DoubleArray.FindMinNumber(testArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(SomeMocks.Flags.EmptyArray)]
        public static void FindMinNumberNegativeTest(SomeMocks.Flags op)
        {
            int[,] testArray;

            testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            Assert.Throws<ArgumentException>(() => DevEducation.DoubleArrays.DoubleArray.FindMinNumber(testArray));
        }
        #endregion

        #region Index of max content in double array
        [TestCase(1, 5, SomeMocks.Flags.Usual1)]
        [TestCase(3, 2, SomeMocks.Flags.Usual2)]
        [TestCase(1, 3, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(3, 2, SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(3, 0, SomeMocks.Flags.NonSquare)]
        [TestCase(0, 0, SomeMocks.Flags.OneInAll)]
        public static void FindMaxNumberIndexTest(int y, int x, SomeMocks.Flags op)
        {
            int[,] testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            (int, int) actual;

            actual = DevEducation.DoubleArrays.DoubleArray.FindMaxNumberIndex(testArray);
            Assert.AreEqual(y, actual.Item1);
            Assert.AreEqual(x, actual.Item2);
        }
        [TestCase(SomeMocks.Flags.EmptyArray)]
        public static void FindMaxNumberIndexNegativeTest(SomeMocks.Flags op)
        {
            int[,] testArray;

            testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            Assert.Throws<ArgumentException>(() => DevEducation.DoubleArrays.DoubleArray.FindMaxNumberIndex(testArray));
        }
        #endregion

        #region Index of min content in double array

        [TestCase(0, 3, SomeMocks.Flags.Usual1)]
        [TestCase(2, 0, SomeMocks.Flags.Usual2)]
        [TestCase(1, 1, SomeMocks.Flags.OnlyNegativeNumbers)]
        [TestCase(2, 0, SomeMocks.Flags.OnlyPositiveNUmbers)]
        [TestCase(1, 2, SomeMocks.Flags.NonSquare)]
        [TestCase(0, 0, SomeMocks.Flags.OneInAll)]
        public static void FindMinNumberIndexTest(int y, int x, SomeMocks.Flags op)
        {
            int[,] testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            (int, int) actual;

            actual = DevEducation.DoubleArrays.DoubleArray.FindMinNumberIndex(testArray);
            Assert.AreEqual(y, actual.Item1);
            Assert.AreEqual(x, actual.Item2);
        }
        [TestCase(SomeMocks.Flags.EmptyArray)]
        public static void FindMinNumberIndexNegativeTest(SomeMocks.Flags op)
        {
            int[,] testArray;

            testArray = SomeMocks.ArrayMock.DoubleArrays(op);
            Assert.Throws<ArgumentException>(() => DevEducation.DoubleArrays.DoubleArray.FindMinNumber(testArray));
        }

        #endregion

    }
}
