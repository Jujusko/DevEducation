using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class Fibonacci
    {
        public static int FindFiboByIndex(int n)
        {
            int n1, n2;
            int sum;

            n1 = 1;
            n2 = 1;
            sum = 0;
            if (n == 1 || n == 2 || n == -1)
                return 1;
            if (n > 1)
            {
                while (n-- > 2)
                {
                    sum = n1 + n2;
                    n1 = n2;
                    n2 = sum;
                }
            }
            else
            {
                while(n++ != 1)
                {
                    sum = n1 - n2;
                    n1 = n2;
                    n2 = sum;
                }
            }
            return sum;
        }
    }
}
