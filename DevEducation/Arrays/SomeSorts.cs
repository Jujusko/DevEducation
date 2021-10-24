using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    class SomeSorts
    {
        public static int[] BubbleSort()
        {
            int tmp;
            int cnt;
            Random rand = new Random();
            int[] array = new int[11];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = -1;
            tmp = 0;
            while (cnt < array.Length - 2)
            {
                cnt++;
                if (array[cnt] > array[cnt + 1])
                {
                    tmp = array[cnt];
                    array[cnt] = array[cnt + 1];
                    array[cnt + 1] = tmp;
                    cnt = -1;
                }
                
            }
            return array;
        }
        public static int[] NewArray(int []ar, int index)
        {
            int [] newA = new int[ar.Length - 1];
            int cnt;
            int cntNew;
            int flag;

            flag = 1;
            cnt = 0;
            cntNew = 0;
            while (cnt < ar.Length && cntNew < newA.Length)
            {
                if (cnt == index)
                {
                    // flag = 0;
                    cnt++;
                    if (cnt == ar.Length)
                        return newA;
                }
                newA[cntNew] = ar[cnt];
                cntNew++;
                cnt++;
            }
            /*
            cnt = 0;
            Console.WriteLine("\n\n\n!!!!");
            while (cnt < ar.Length)
            {
                Console.Write(ar[cnt] + " ");
                cnt++;
            }
            Console.WriteLine("\n\n\n!!!!" + "dsafasd   " + ar.Length);
            */
            return newA;
        }
        public static int[] SelectSort()
        {
            int tmp;
            int cnt;
            int minNumb;
            int index;
            int newCnt;
            int arLenght;
            Random rand = new Random();
            int[] array = new int[11];
            int[] newAr = new int[11];
            cnt = 0;
            while (cnt < array.Length)
                array[cnt++] = rand.Next(0, 100);
            cnt = 0;
            while (cnt < array.Length)
            {
                Console.Write(array[cnt] + " ");
                cnt++;
            }
            cnt = 0;
            minNumb = array[cnt];
            index = 0;
            newCnt = 0;
            arLenght = array.Length;
            while(arLenght != 1)
            {
                
                while (cnt < arLenght)
                {
                    if (minNumb > array[cnt])
                    {
                        minNumb = array[cnt];
                        index = cnt;
                    }
                    cnt++;
                }
                
                newAr[newCnt] = minNumb;
                array = NewArray(array, index);
                arLenght = array.Length;
                newCnt++;
                minNumb = array[0];
                cnt = 0;
            }
            Console.Write("\n\n\n");
            cnt = 0;
            while (cnt < newAr.Length)
            {
                Console.Write(newAr[cnt] + " ");
                cnt++;
            }
            return newAr;
        }
    }
}
