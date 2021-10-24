using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class Swap
    {
        public static (int, int) SwapNumbs()
        {
            int a;
            int b;
            int tmp;
            Console.WriteLine("Put numb a and b to swap this");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            tmp = a;
            a = b;
            b = tmp;
            return (a , b);
        }
    }
}
