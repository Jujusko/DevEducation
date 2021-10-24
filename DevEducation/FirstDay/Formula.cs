using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class Formula
    {
        public static void GetSolution()
        {
            int a;
            int b;
            int res;

            Console.WriteLine("Put number a and b.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
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
