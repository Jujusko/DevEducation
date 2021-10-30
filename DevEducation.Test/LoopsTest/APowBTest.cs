using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class APowBTest
    {
        [TestCase(4, 5, 1024)]
        [TestCase(1024, 0, 1)]
        [TestCase(4, -2, 0.0625)]
        [TestCase(1, 10, 1)]
        [TestCase(10, 5, 100000)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 20, 0)]
        public static void APowBPositiveTests(int a, int b, double actual)
        {
            double expected = Loops.APowB.DoAPowB(a, b);
            Assert.AreEqual(actual, expected);
        }


    }
}
