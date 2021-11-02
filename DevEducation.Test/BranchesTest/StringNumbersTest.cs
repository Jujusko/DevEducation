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
        [TestCase(31, "ТридцатьОдин")]
        [TestCase(21, "ДвадцатьОдин")]
        [TestCase(40, "Сорок")]

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
