using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.DoubleArrays
{
    class ReverseDoubleArr
    {
        public static int[,] GetReversedArray(int [,] arr)
        {
            int i, j;
            int x;
            int y;
            int tmp;

            int n1, n2;

            x = 1;
            i = arr.GetLength(0);
            j = arr.GetLength(1);
            if (i != j)
            {
                Console.WriteLine("Error array!");
                return arr;
            }
            y = 0;
            while (y < i)
            {
                x = y + 1;
                while (x < j)
                {
                    tmp = arr[y, x];
                    n1 = arr[x, y];
                    arr[y, x] = arr[x, y];
                    arr[x, y] = tmp;
                    x++;
                }
                y++;
            }
            return arr;
        }
    }
}
