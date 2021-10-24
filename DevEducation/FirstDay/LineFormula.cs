using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class LineFormula
    {
        public static int Solution()
        {
            int a, b, c, x;

            Console.WriteLine("Put a, b, c\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

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
