using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class Multiples
    {
        public static int[] FindMultiples(int a)
        {
            int cnt;
            int range;
            int []all_nubs;

            
            range = a;
            cnt = 0;
            while (range++ <= 1000)
            {
                if (range % a == 0)
                    cnt++;
            }
            all_nubs = new int[cnt];
            cnt = 0;
            while (range++ <= 1000)
            {
                if (range % a == 0)
                {
                    all_nubs[cnt] = range;
                    cnt++;
                }
            }
            return all_nubs;
        }
    }
}
