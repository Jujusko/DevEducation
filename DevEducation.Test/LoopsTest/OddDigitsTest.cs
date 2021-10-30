using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class OddDigitsTest
    {
        [TestCase(1234, 2)]
        [TestCase(0, 0)]
        [TestCase(1111, 4)]
        [TestCase(1995, 4)]
        [TestCase(431, 2)]
        public static void FindAmntOddDigitsTest(int a, int expected)
        {
            int actual;

            actual = Loops.OddDigits.FindAmntOddDigits(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
