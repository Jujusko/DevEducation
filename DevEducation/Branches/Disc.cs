using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class Disc
    {
        public static (double, double) GetSquares(double a, double b, double c)
        {
            double disc;
            double x1, x2;

            disc = b * b - (4 * a * c);
            x1 = (-b + Math.Sqrt(disc) / (2 * a));
            x2 = (-b - Math.Sqrt(disc) / (2 * a));
            return (x1, x2);
        }
    }
}
