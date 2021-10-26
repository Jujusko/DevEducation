using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class Branches
    {
        public static int AnaliseAAndB(int a, int b)
        {
            if (a > b)
                return (a + b);
            else if (a < b)
                return (a - b);
            else
                return (a * b);
        }
    }
}
