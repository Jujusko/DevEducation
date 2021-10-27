using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class APowB
    {
        public static double DoAPowB(int a, int b)
        {
            double res;

            res = 1;
            if (b == 0)
                return 1;
            else if (b > 0)
            {
                while (b-- > 0)
                    res = res * a;
            }
            else
                while (b++ < 0)
                {
                    res = res / a;
                }
            return res;
        }
    }
}
