using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class SumOfNumbsBySeven
    {
        public static int GetSumDivsBySeven(int a, int b)
        {
            int tmp;
            int res;

            res = 0;
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            while (a < b)
            {
                if (a % 7 == 0)
                    res += a;
                a++;
            }
            return res;
        }
    }
}
