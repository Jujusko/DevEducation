using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.BranchesTest
{
    class DistTest
    {
       
        [TestCase(1, 1, 0, 0, -1)]
        [TestCase(-5, -9, 85, -5.12, 3.32)]
        public void GetSquaresTest(int a, int b, int c, double firstSqr, double secndSqr)
        {
            (double, double) actual;
            actual = Branches.Disc.GetSquares(a, b, c);
            Assert.AreEqual(actual.Item1, firstSqr, 0.1);
            Assert.AreEqual(actual.Item2, secndSqr, 0.1);
        }

        [TestCase(1, 1, 1)]
        [TestCase(20, 23, 11)]
        public void GetSquaresNegativeTest(int a, int b, int c)
        {
            Assert.Throws<ArithmeticException>(() => Branches.Disc.GetSquares(a, b, c));
        }
    }
}
