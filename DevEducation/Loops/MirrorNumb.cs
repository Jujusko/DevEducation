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
        public static int FindMirror()
        {
            int mirror;
            int a;

            mirror = 0;
            a = Convert.ToInt32(Console.ReadLine());
            while(a / 10 > 0)
            {
                mirror = (a % 10) + mirror * 10;
                a /= 10;
            }
            return mirror;
        }
    }
}
