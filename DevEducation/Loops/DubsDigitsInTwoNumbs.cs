using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class DubsDigitsInTwoNumbs
    {
        //task 12
        public static bool FindDubs(int a, int b)
        {

            int tmp;
            int tmp2;
            int tmp3;

            if (b < a)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if (a < 10 || b < 10)
            {
                while(b != 0)
                {
                    tmp = b % 10;
                    if (tmp == a)
                        return (true);
                    b /= 10;
                }
                if (a == b)
                    return true;
                return false;
            }
            if (a < 10)
            {
                while(b / 10 != 0)
                {
                    tmp3 = b % 10;
                    if (tmp3 == a)
                        return true;
                    b = b / 10;
                }
                if (a == b)
                    return (true);
                else
                    return false;
            }
            while(b / 10 != 0)
            {
                tmp2 = b % 10;
                tmp = a;
                while(tmp != 0)
                {
                    tmp3 = tmp % 10;
                    if (tmp3 == tmp2)
                        return true;
                    tmp = tmp / 10;
                }
                b = b / 10;
            }
            return false;
        }
    }
}
