using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DevEducation.Test.BranchesTest
{
    class StringNumbersTest
    {
        [TestCase(1, "Один")]
        [TestCase(2, "Два")]
        [TestCase(0, "Error. Put Number less than 100")]
        [TestCase(-123, "Error. Put Number less than 100")]
        [TestCase(10000, "Error. Put Number less than 100")]
        public static void GetStringTest(int a, string expected)
        {
            string actual;

            actual = Branches.StringNumbers.GetString(a);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(12222)]
        [TestCase(-12222)]
        public static void GetStringNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Branches.StringNumbers.GetString(a));
        }
    }
}
