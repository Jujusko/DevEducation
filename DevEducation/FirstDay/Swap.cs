using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class Swap
    {
        public static (int, int) SwapNumbs(int a, int b)
        {
            int tmp;

            tmp = a;
            a = b;
            b = tmp;
            return (a , b);
        }
    }
}
