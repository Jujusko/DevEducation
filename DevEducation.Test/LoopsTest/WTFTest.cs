using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevEducation.Test.LoopsTest
{
    class WTFTest
    {
        [TestCase (5, new int[] {2, 4})]
        [TestCase(0, new int[] {})]
        [TestCase(55, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 
            24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44, 46, 48})]
        [TestCase(10, new int[] { 2, 4, 6, 8})]
        [TestCase(4, new int[] { 2, 4})]
        public static void WTFIdkWhatIshouldToDoTEst(int x, int[] expected)
        {
            int cnt;

            int[] actual = Loops.WTF.WTFIdkWhatIshouldToDo(x);
            cnt = 0;
            if (actual.Length != expected.Length)
                Assert.Fail();
            while(cnt < actual.Length)
            {
                Assert.AreEqual(expected[cnt], actual[cnt++]);
            }
        }
    }
}
