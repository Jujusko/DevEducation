using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.BranchesTest
{
    class FindQuarterTest
    {
        [TestCase(0, 0, -1)]
        [TestCase(1, 1, 1)]
        [TestCase(214736471, 214836471, 1)]
        [TestCase(-21483647, 0, -1)]
        [TestCase(27483647, 2147483647, 1)]
        public static void ReturnQUarterTest(int a, int b, int expected)
        {
            int actual;

            actual = Branches.FindQuarter.ReturnQuarter(a, b);
            Assert.AreEqual(actual, expected);
        }
    }
}
