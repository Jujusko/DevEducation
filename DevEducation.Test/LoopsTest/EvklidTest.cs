using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class EvklidTest
    {
        [TestCase(700, 100, 100)]
        [TestCase(845, 8, 1)]
        [TestCase(88, 8, 8)]
        [TestCase(1, 1, 1)]
        [TestCase(778, 887, 1)]
        public static void BiggestDivTest(int a, int b, int expected)
        {
            int actual;

            actual = Loops.Evklid.BiggestDiv(a, b);
            Assert.AreEqual(actual, expected);
        }
    }
}
