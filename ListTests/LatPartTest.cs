using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using List;

namespace ListTests
{
    class LatPartTest
    {
        [TestCase(new int[] { 1,2,3,4,5}, new int[] { 1, 2, 3}, new int[] { 4, 5 })]
        public static void AddFrontTest(int[] a, int []b, int []c)
        {
            ArrayList expected = new ArrayList(a);
            ArrayList actual = new ArrayList(b);
            ArrayList addToActual = new ArrayList(c);
            actual.AddOwnListAtFront(addToActual);
            Assert.AreEqual(expected, actual);
        }

    }
}
