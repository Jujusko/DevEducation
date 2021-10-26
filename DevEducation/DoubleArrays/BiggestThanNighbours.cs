using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.DoubleArrays
{
    class BiggestThanNighbours
    {

        public static int FindBig(int[,] arr)
        {
            int i, j;
            int i1, j1;
            int cnt = 0;
            int cntInCnt = 0;

            int toCheck;
            int nnumb;
            i1 = 0;
            j = arr.GetLength(1);
            i = arr.GetLength(0);

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
                        nnumb = arr[i1 - 1, j1];
                        if (arr[i1 - 1, j1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (i1 + 1 <= i)
                    {
                        nnumb = arr[i1 + 1, j1];
                        if (arr[i1 + 1, j1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (j1 + 1 <= j)
                    {
                        nnumb = arr[i1, j1 + 1];
                        if (arr[i1, j1 + 1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (j1 - 1 >= 0)
                    {
                        nnumb = arr[i1, j1 - 1];
                        if (arr[i1, j1 - 1] < toCheck)
                            cntInCnt++;
                    }
                    else
                        cntInCnt++;
                    if (cntInCnt == 4)
                        cnt++;
                    cntInCnt = 0;
                    j1++;
                }
                i1++;
            }
            return cnt;
        }
    }
}
