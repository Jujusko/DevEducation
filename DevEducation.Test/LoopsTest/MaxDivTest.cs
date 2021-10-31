using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class MaxDivTest
    {
        [TestCase(8, 4)]
        [TestCase(16, 8)]
        [TestCase(3, 1)]
        [TestCase(121, 11)]
        [TestCase(241, 1)]


        public static void FindMaxDivNumbTest(int a, int expected)
        {
            int actual;

            actual = Loops.MaxDiv.FindMaxDivNumb(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
