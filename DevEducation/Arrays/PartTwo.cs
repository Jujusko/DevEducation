using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    public class PartTwo
    {
        public static int GetSummNumbsOddIndexes(int[] array)
        {
            int sum;
            int cnt;

            cnt = -1;
            sum = 0;
            while (++cnt < array.Length)
            {
                if ((cnt + 1) % 2 != 0)
                    sum += array[cnt];
            }
            return sum;
        }
        public static int[] ReverseArray(int[] array)
        {
            int cnt;
            int tmp;

            cnt = 0;
            while(cnt < (array.Length / 2))
            {
                tmp = array[cnt];
                array[cnt] = array[array.Length - cnt - 1];
                array[array.Length - cnt - 1] = tmp;
                cnt++;
            }
            return array;
        }
        public static int GetSummNonOddIndexes(int[] array)
        {
            int sum;
            int cnt;

            cnt = -1;
            sum = 0;
            while (++cnt < array.Length)
            {
                if ((cnt + 1) % 2 == 0)
                    sum+= array[cnt];
            }
            return sum;
        }
        public static int[] ChangeArrayHalves(int[] array)
        {

            int half;
            int cnt;
            int tmp;

            cnt = 0;
            if (array.Length % 2 == 1)
                half = array.Length / 2 + 1;
            else
                half = array.Length / 2;
  
            while (cnt < half)
            {
                tmp = array[cnt];
                if (half + cnt < array.Length)
                {
                    array[cnt] = array[half + cnt];
                    array[half + cnt] = tmp;
                }
                cnt++;
            }
            return array;
        }
    }
}
