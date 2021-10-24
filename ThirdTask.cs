using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class ThirdTask
    {
        public static void DivAndMod()
        {
            int a, b;
            int mod, div;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            mod = a % b;
            div = a / b;
            Console.WriteLine("res by mod = " + mod);
            Console.WriteLine("res by div = " + div);
        }
    }
}
