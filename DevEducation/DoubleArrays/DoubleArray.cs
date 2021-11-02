using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.DoubleArrays
{
    public class DoubleArray
    {
        public static int FindMaxNumber(int[,] arr)
        {
            int i, j;
            int maxNumb;

            i = 0;
            if (arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
                throw new ArgumentException("Array does not exist");
            maxNumb = arr[0, 0];
            while (i < arr.GetLength(0))
            {
                j = 0;
                while (j < arr.GetLength(1))
                {
                    if (maxNumb < arr[i, j])
                        maxNumb = arr[i, j];
                    j++;
                }
                i++;
            }
            return maxNumb;
        }

        public static int FindMinNumber(int[,] arr)
        {
            int i, j;
            int minNumb;

            i = 0;
            if (arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
                throw new ArgumentException("Array does not exist");
            minNumb = arr[0, 0];
            while (i < arr.GetLength(0))
            {
                j = 0;
                while (j < arr.GetLength(1))
                {
                    if (minNumb > arr[i, j])
                        minNumb = arr[i, j];
                    j++;
                }
                i++;
            }
            return minNumb;
        }

        public static (int, int) FindMaxNumberIndex(int[,] arr)
        {
            int i, j;
            int maxNumb;
            (int, int) index;


            i = 0;
            index = (0, 0);
            if (arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
                throw new ArgumentException("Array does not exist");
            maxNumb = arr[0, 0];
            while (i < arr.GetLength(0))
            {
                j = 0;
                while (j < arr.GetLength(1))
                {
                    if (maxNumb < arr[i, j])
                    {
                        index = (i, j);
                        maxNumb = arr[i, j];
                    }
                    j++;
                }
                i++;
            }
            return index;
        }

        public static (int, int) FindMinNumberIndex(int[,] arr)
        {
            int i, j;
            int minNumb;
            (int, int) index;

            i = 0;
            index = (0, 0);
            if (arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
                throw new ArgumentException("Array does not exist");
            minNumb = arr[0, 0];
            while (i < arr.GetLength(0))
            {
                j = 0;
                while (j < arr.GetLength(1))
                {
                    if (minNumb > arr[i, j])
                    {
                        index = (i, j);
                        minNumb = arr[i, j];
                    }
                    j++;
                }
                i++;
            }
            return index;
        }
    }
}
