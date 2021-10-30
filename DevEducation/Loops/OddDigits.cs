using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class OddDigits
    {
        //Task 9
        public static int FindAmntOddDigits(int a)
        {
            int cnt;

            cnt = 0;
            if (a < 0)
                a *= -1;
            while(a > 0)
            {
                if ((a % 10) % 2 == 1)
                    cnt++;
                a /= 10;
            }
            return cnt;
        }
    }
}
