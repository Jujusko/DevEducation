using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class DubsTest
    {
        [TestCase(1, 1234, true)]
        [TestCase(333, 444, false)]
        [TestCase(78954, 78954, true)]
        [TestCase(417, 963548, true)]
        [TestCase(0, 0, true)]
        public static void FindDubsTest(int a, int b, bool expected)
        {
            bool actual = Loops.DubsDigitsInTwoNumbs.FindDubs(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
