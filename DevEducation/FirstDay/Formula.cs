using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    public class Formula
    {
        public static void GetSolution(int a, int b)
        {
            int res;

            if (a == b)
            {
                Console.WriteLine("Divide by zero!");
                return ;
            }
            res = (5 * a + b * b) / (b - a);
            Console.WriteLine(res);
        }
    }
}
