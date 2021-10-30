using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class FibonacciTest
    {
        [TestCase(4, 3)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]
        public static void FindFiboByIndexTest(int n, int expected)
        {
            int actual;

            actual = Loops.Fibonacci.FindFiboByIndex(n);
            Assert.AreEqual(actual, expected);
        }
    }
}
