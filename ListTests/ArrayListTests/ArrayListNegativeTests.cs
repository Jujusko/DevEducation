using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using List;

namespace ListTests.LinkedTests
{
    class ArrayListNegativeTests
    {
        [TestCase(14444)]
        [TestCase(-1)]
        [TestCase(50)]
        [TestCase(-32)]
        public static void DeleteByIndexNegativeTest(int index)
        {
            ArrayList actual;

            actual = new ArrayList(new int[] { 23, 22, 43, 6457, 0 });
            Assert.Throws<ArgumentException>(() => actual.DeleteByIndex(index));
        }

        [TestCase(14444)]
        [TestCase(-1)]
        [TestCase(50)]
        [TestCase(-32)]
        public static void GetContentByIndexNegativeTest(int index)
        {
            ArrayList actual;

            actual = new ArrayList(new int[] { 23, 22, 43, 6457, 0 });
            Assert.Throws<ArgumentException>(() => actual.GetContentByIndex(index));
        }

        [TestCase(14444)]
        [TestCase(-1)]
        [TestCase(50)]
        [TestCase(-32)]
        public static void ChangeContentByIndexNegativeTest(int index)
        {
            ArrayList actual;

            actual = new ArrayList(new int[] { 23, 22, 43, 6457, 0 });
            Assert.Throws<ArgumentException>(() => actual.ChangeContentByIndex(index));
        }
    }
}
