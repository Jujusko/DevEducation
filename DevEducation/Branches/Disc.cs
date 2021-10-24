using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class Disc
    {
        public static (double, double) GetSquares()
        {
            double a, b, c;
            double disc;
            double x1, x2;

            Console.WriteLine("Put 3 numbers to get squares");
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
            c = Convert.ToInt64(Console.ReadLine());

            disc = b * b - (4 * a * c);
            x1 = (-b + Math.Sqrt(disc) / (2 * a));
            x2 = (-b - Math.Sqrt(disc) / (2 * a));
            return (x1, x2);
        }
    }
}
