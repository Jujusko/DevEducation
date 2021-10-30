using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class SumOfNumbsBySevenTest
    {
        [TestCase(0, 7, 7)]
        [TestCase(14, 7, 14)]
        [TestCase(-123, 0, -1071)]
        [TestCase(0, 6, 0)]
        [TestCase(123, 7, 1064)]
        public static void GetSumDivsBySevenTest(int a, int b, int expected)
        {
            int actual;

            actual = Loops.SumOfNumbsBySeven.GetSumDivsBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
