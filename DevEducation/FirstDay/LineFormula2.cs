using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    public class LineFormula2
    {
        public static String DoSolution(double x, double x1, double y, double y1)
        {
            double a, b;

            b = (y1 * x - y) / (x + 1);
            a = (y - b) / x;
            return (Convert.ToString(y) + "=" + Convert.ToString(a) +
                " * " + Convert.ToString(x) + " + " + Convert.ToString(b));
        }
    }
}
