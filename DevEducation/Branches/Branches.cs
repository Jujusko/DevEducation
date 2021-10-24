using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class Branches
    {
        public static int AnaliseAAndB()
        {
            int a, b;
            Console.WriteLine("Put a and b (numbs)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                return (a + b);
            else if (a < b)
                return (a - b);
            else
                return (a * b);
        }
    }
}
