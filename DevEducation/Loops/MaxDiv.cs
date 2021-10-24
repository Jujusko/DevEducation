using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class MaxDiv
    {
        public static int FindMaxDivNumb()
        {
            int a;
            int res;

            Console.WriteLine("4 task");
            a = Convert.ToInt32(Console.ReadLine());
            res = a;
            while(res-- > 0)
            {
                if (a % res == 0)
                    return res;
            }
            return -1;
        }
    }
}
