using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DevEducation;

namespace DevEducation.Test
{
    
    class BranchesTests
    {
        [TestCase (5, 5, 25)]
        [TestCase(1, 4, -3)]
        [TestCase(4, 1, 5)]
        [TestCase(46340, 46340, 2147395600)]
        [TestCase(2147483647, 2147483647, -1)]
        public void AnanliseAAndBTest(int a, int b, int expected)
        {
            int actual;
            actual = Branches.Branches.AnaliseAAndB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(463402, 463402)]
        public void AnanliseAAndBNegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Branches.Branches.AnaliseAAndB(a, b));
        }
    }
}
