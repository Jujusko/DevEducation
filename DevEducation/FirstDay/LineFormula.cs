using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class LineFormula
    {
        public static int Solution(int a, int b, int c)
        {
            int x;

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Error!");
                return (-1);
            }
            x = (c - b) / a;
            return x;
        }
    }
}
