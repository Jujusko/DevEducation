using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class MirrorNumb
    {
        //Task 10
        public static int FindMirror(int a)
        {
            int mirror;

            mirror = 0;
            while(a / 10 > 0)
            {
                mirror = (a % 10) + mirror * 10;
                a /= 10;
            }
            return mirror;
        }
    }
}
