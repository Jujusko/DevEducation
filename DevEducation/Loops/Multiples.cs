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
            int step;

            range = 0;
            step = a;
            cnt = 0;
            while (range < 1000)
            {
                range += step;
                    cnt++;
            }
            if (range > 1000)
                cnt--;
            all_nubs = new int[cnt];
            cnt = 0;
            range = 0;
            while (range + step <= 1000)
            {
                if (range <= 1000)
                    all_nubs[cnt] = range + step;
                cnt++;
                range += step;
            }
            return all_nubs;
        }
    }
}
