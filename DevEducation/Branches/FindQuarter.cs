using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    public class FindQuarter
    {
        public static int ReturnQuarter(int a, int b)
        {
            if ((a <= 2147483647 && a >= -2147483648) &&
                (b <= 2147483647 && b >= -2147483648))
            {
                if (a > 0 && b > 0)
                    return 1;
                else if (a > 0 && b < 0)
                    return 2;
                else if (a < 0 && b < 0)
                    return 3;
                else if (a < 0 && b > 0)
                    return 4;
            }
            Console.WriteLine("You took centre");
            return -1;
        }
    }
}
