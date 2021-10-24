using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class LineFormula2
    {
        public static String DoSolution()
        {
            double x, x1, y, y1;
            double a, b;

            Console.WriteLine("Put x, y, x1, y1");
            x = Convert.ToInt64(Console.ReadLine());
           
            y = Convert.ToInt64(Console.ReadLine());
           
            x1 = Convert.ToInt64(Console.ReadLine());
            
            y1 = Convert.ToInt64(Console.ReadLine());

            b = (y1 * x - y) / (x + 1);
            a = (y - b) / x;
            return (Convert.ToString(y) + "=" + Convert.ToString(a) +
                " * " + Convert.ToString(x) + " + " + Convert.ToString(b));
        }
    }
}
