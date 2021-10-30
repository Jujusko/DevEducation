using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class LessThanATest
    {
        [TestCase(5, 2)]
        [TestCase(10, 3)]
        [TestCase(17, 4)]
        [TestCase(0, 0)]
        [TestCase(100, 9)]
        public static void FindNumbersTest(int a, int expected)
        {
            int actual;

            actual = Loops.LessThenA.FindNumbers(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
