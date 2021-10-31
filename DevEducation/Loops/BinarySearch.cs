using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class BinarySearch
    {
        public static double Cube(double x)
        {
            return x * x * x;
        }
        public static double ABS(double x)
        {
            if (x < 0)
                return (x * -1);
            else
                return x;
        }
        public static double HalfDivMethod(int n_first)
        {
            double a, b, n_second;
            double x;
            double tmp1, tmp2, tmp3;
            a = 1;
            b = n_first;
            x = (b + a) / 2;
            n_second = Cube(x);
            while(Convert.ToInt32(n_second) != n_first)
            {
                tmp1 = Cube(x);
                tmp2 = Cube(a);
                tmp3 = Cube(b);
                if ((tmp1 < n_first))
                    a = x;
                else
                    b = x;
                x = (b + a) / 2;
                n_second = Cube(x);
                Console.WriteLine(x);
            }
            return x;
        }
    }
}
