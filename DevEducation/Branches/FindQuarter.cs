using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class FindQuarter
    {
        public static int ReturnQuarter()
        {
            int a, b;
            Console.WriteLine("Put x and y (coords)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
                return 1;
            else if (a > 0 && b < 0)
                return 2;
            else if (a < 0 && b < 0)
                return 3;
            else if (a < 0 && b > 0)
                return 4;
            else
                Console.WriteLine("You took centre");
            return -1;
        }
    }
}
