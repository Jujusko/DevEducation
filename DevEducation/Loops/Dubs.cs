using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class Dubs
    {
        //task 12
        public static bool FindDubs(int a, int b)
        {

            int tmp;
            int tmp2;
            int tmp3;

            if (b < 10)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if (a < 10 && b < 10)
            {
                if (a == b)
                    return (true);
                else
                    return
                        false;
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
            while(a / 10 != 0)
            {
                tmp2 = a % 10;
                tmp = b;
                while(tmp / 10 != 0)
                {
                    tmp3 = b % 10;
                    if (tmp3 == tmp2)
                        return true;
                    tmp = tmp / 10;
                }
                a = a / 10;
            }
            return false;
        }
    }
}
