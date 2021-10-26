using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    class PartOne
    {
        public static int FindMinNumb(int []array) 
        {
            int min;
            int cnt;

            min = array[0];
            cnt = 0;
            while (cnt < array.Length)
            {
                if (min > array[cnt])
                    min = array[cnt];
                cnt++;
            }
            return min;
        }
        public static int FindMaxNumb(int[] array)
        {
            int min;
            int cnt;

            min = array[0];
            cnt = 0;
            while (cnt < array.Length)
            {
                if (min < array[cnt])
                    min = array[cnt];
                cnt++;
            }
            return min;
        }

        public static int FindIndexMinNumb(int[] array)
        {
            int min;
            int cnt;
            int index;

            min = array[0];
            cnt = 0;
            index = 0;
            while (cnt < array.Length)
            {
                if (min > array[cnt])
                {
                    min = array[cnt];
                    index = cnt;
                }
                cnt++;
            }
            return index;
        }
        public static int FindIndexMaxNumb(int[] array)
        {
            int max;
            int cnt;
            int index;

            max = array[0];
            cnt = 0;
            index = 0;
            while (cnt < array.Length)
            {
                if (max < array[cnt])
                {
                    max = array[cnt];
                    index = cnt;
                }
                cnt++;
            }
            return index;
        }
    }
}
