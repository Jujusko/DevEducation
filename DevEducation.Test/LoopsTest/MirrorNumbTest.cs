using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class MirrorNumbTest
    {
        [TestCase(1234, 4321)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(4562, 2654)]
        [TestCase(907, 709)]
        public static void FindMirrorTest(int a, int expected)
        {
            int actual;

            actual = Loops.MirrorNumb.FindMirror(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
