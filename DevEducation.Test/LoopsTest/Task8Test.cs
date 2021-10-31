using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class BinarySearchTest
    {
        [TestCase(27, 3)]
        [TestCase(1, 1)]
        [TestCase(1000, 10)]
        [TestCase(44, 3.52)]
        [TestCase(33, 3.21)]
        public static void HalfDivMethodtest(int x, double expected)
        {
            double actual;

            actual = Loops.BinarySearch.HalfDivMethod(x);
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
