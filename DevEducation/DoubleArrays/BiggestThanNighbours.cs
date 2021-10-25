using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.DoubleArrays
{
    class BiggestThanNighbours
    {

        public static int FindBig()
        {
            int[,] arr;
            Random r = new();
            arr = new int[3, 3];
            int i, j;
            int i1, j1;
            int cnt = 0;
            int cntInCnt = 0;

            int toCheck;
            int arrInConvert;
            i1 = 0;
            j = 0;
            i = 0;
            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    arr[i, j] = r.Next(0, 100);
                    j++;
                }
                i++;
            }

            i--;
            j--;
            while (i1 <= i)
            {
                j1 = 0;
                while (j1 <= j)
                {
                    toCheck = arr[i1, j1];
                    if (i1 - 1 >= 0)
                    {
                        if (arr[i1 - 1, j] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (i1 + 1 <= i)
                    {
                        if (arr[i1 + 1, j] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (j1 + 1 <= j)
                    {
                        if (arr[i, j1 + 1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (j1 - 1 >= 0)
                    {
                        if (arr[i, j1 - 1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (cntInCnt == 4)
                        cnt++;
                    j1++;
                }
                i1++;
            }
            i = 0;
            j = 0;
            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    Console.Write(arr[i, j] + "\t");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("\n" + cnt);
            return cnt;
        }
    }
}
