using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class Multiples
    {
        public static int FindMultiples()
        {
            int a;
            int cnt;
            int range;

            Console.WriteLine("Put number from 1 to 999 to find multiples until 1000");
            a = Convert.ToInt32(Console.ReadLine());
            range = a;
            cnt = 0;
            while (range++ <= 1000)
            {
                if (range % a == 0)
                    cnt++;
            }
            return cnt;
        }
    }
}
