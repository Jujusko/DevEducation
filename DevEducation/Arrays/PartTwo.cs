using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    class PartTwo
    {
        public static int GetSummNumbsOddIndexes()
        {
            int sum;
            int cnt;
            Random rand = new Random();
            int[] array = new int[10];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = 0;
            sum = 0;
            while (cnt < array.Length)
            {
                if ((cnt + 1) % 2 != 0)
                    sum += array[cnt];
            }
            return sum;
        }
        public static int[] ReverseArray()
        {
            int sum;
            int cnt;
            int tmp;
            Random rand = new Random();
            int[] array = new int[10];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = 0;
            while(cnt < (array.Length / 2))
            {
                tmp = array[cnt];
                array[cnt] = array[array.Length - cnt];
                array[array.Length - cnt] = tmp;
                cnt++;
            }
            return array;
        }
        public static int GetSummOddIndexes()
        {
            int sum;
            int cnt;
            Random rand = new Random();
            int[] array = new int[10];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = 0;
            sum = 0;
            while (cnt < array.Length)
            {
                if ((cnt + 1) % 2 != 0)
                    sum++;
            }
            return sum;
        }
        public static int[] ChangeArrayHalves()
        {

            int half;
            int cnt;
            int tmp;

            half = 0;
            Random rand = new Random();
            int []array = new int[10];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = 0;
            Console.WriteLine();
            if (array.Length % 2 == 1)
                half = array.Length / 2 + 1;
            else
                half = array.Length / 2;
            Console.WriteLine(half);
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
