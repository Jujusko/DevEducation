using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    class PartOne
    {
        public static int FindMinNumb()
        {
            int min;
            int cnt;
            Random rand = new Random();
            int[] array = new int[10];
            min = 0;
            while (min < array.Length)
                array[min++] = rand.Next(0, 100);
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
        public static int FindMaxNumb()
        {
            int min;
            int cnt;
            Random rand = new Random();
            int[] array = new int[10];
            min = 0;
            while (min < array.Length)
                array[min++] = rand.Next(0, 100);
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

        public static int FindIndexMinNumb()
        {
            int min;
            int cnt;
            int index;
            Random rand = new Random();
            int[] array = new int[10];
            min = 0;
            while (min < array.Length)
                array[min++] = rand.Next(0, 100);
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
        public static int FindIndexMaxNumb()
        {
            int max;
            int cnt;
            int index;
            Random rand = new Random();
            int[] array = new int[10];
            max= 0;
            while (max < array.Length)
                array[max++] = rand.Next(0, 100);
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
