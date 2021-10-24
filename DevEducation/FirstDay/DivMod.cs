using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class DivMod
    {
        public static void PrintDivMod()
        {
            int a;
            int b;

            Console.WriteLine("Put numb a and b\nFirst output = a / b\nSecond output = a % b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
