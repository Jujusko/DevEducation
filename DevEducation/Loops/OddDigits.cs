﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class OddDigits
    {
        //Task 9
        public static int FindAmntOddDigits(int a)
        {
            int cnt;

            cnt = 0;
            while(a / 10 > 0)
            {
                if ((a % 10) % 2 == 1)
                    cnt++;
                a /= 10;
            }
            return cnt;
        }
    }
}
