using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class APowB
    {
        public static double DoAPowB()
        {
            int a;
            int b;
            double res;

            Console.WriteLine("Input A and B. Res is A pow B");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
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
