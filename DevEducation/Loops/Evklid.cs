using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class Evklid
    {
        public static int BiggestDiv(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Not valid content here");
            while(a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return (a + b);
        }
    }
}
