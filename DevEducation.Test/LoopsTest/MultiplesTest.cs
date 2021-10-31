using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class MultiplesTest
    {
        [TestCase(50, new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 
            600, 650, 700, 750, 800, 850, 900, 950, 1000})]
        [TestCase(51, new int[] { 51, 102, 153, 204, 255, 306, 357, 408, 459, 
            510, 561, 612, 663, 714, 765, 816, 867, 918, 969})]
        [TestCase(1000, new int[] {1000})]
        [TestCase(999, new int[] { 999 })]
        public static void FindMultiplesTEst(int a, int[] expected)
        {
            int cnt;
            int[] actual;

            actual = Loops.Multiples.FindMultiples(a);
            cnt = 0;
            if (actual.Length != expected.Length)
                Assert.Fail();
            while(cnt < actual.Length)
                Assert.AreEqual(expected[cnt], actual[cnt++]);
        }
    }
}
