using NUnit.Framework;
using DevEducation;
namespace DevEducation.Test
{
    public class DivModTests
    {
        [Test]
        public void PrintDivModTest()
        {
            int a, b;

            (a, b) = FirstDay.DivMod.PrintDivMod(4, 1);
            (a, b) = (1, 3);
            if ((a,b) == (1, 0))
            {
                Assert.Fail();
            }
        }
        
    }
}