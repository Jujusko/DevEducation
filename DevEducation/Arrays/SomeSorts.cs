using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Arrays
{
    class SomeSorts
    {
            //half = 0;
        public static int[] BubbleSort(int[] array)
        {
            int tmp;
            int cnt;
    
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
        //Util method to help with Select Sort
        static int[] NewArray(int []ar, int index)
        {
            int [] newA = new int[ar.Length - 1];
            int cnt;
            int cntNew;

            cnt = 0;
            cntNew = 0;
            while (cnt < ar.Length && cntNew < newA.Length)
            {
                if (cnt == index)
                {
                    cnt++;
                    if (cnt == ar.Length)
                        return newA;
                }
                newA[cntNew] = ar[cnt];
                cntNew++;
                cnt++;
            }
            return newA;
        }

        static (int, int) FindMinNumbAndIndex(int[] array)
        {
            int cnt;
            int minNumb;
            int index;

            cnt = 0;
            minNumb = array[0];
            index = 0;
            while (cnt < array.Length)
            {
                if (minNumb > array[cnt])
                {
                    minNumb = array[cnt];
                    index = cnt;
                }
                cnt++;
            }
            return (minNumb, index);
        }
        //      End utils
        public static int[] SelectSort(int[] array)
        {
            int minNumb;
            int index;
            int newCnt;
            int arLenght;

            int[] newAr = new int[10];
            newCnt = 0;
            arLenght = array.Length;
            while(arLenght != 1)
            {
                (minNumb, index) = FindMinNumbAndIndex(array);
                newAr[newCnt] = minNumb;
                array = NewArray(array, index);
                arLenght = array.Length;
                newCnt++;
            }
            newAr[newCnt] = array[0];
            return newAr;
        }
    }
}
