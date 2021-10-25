using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class ArraysDay
    {
        public static dynamic AllTasks(int task)
        {
            if (task == 1)
                return Arrays.PartOne.FindMinNumb();
            else if (task == 2)
                return Arrays.PartOne.FindMaxNumb();
            else if (task == 3)
                return Arrays.PartOne.FindIndexMinNumb();
            else if (task == 4)
                return Arrays.PartOne.FindIndexMaxNumb();
            else if (task == 5)
                return Arrays.PartTwo.GetSummNumbsOddIndexes();
            else if (task == 6)
                return Arrays.PartTwo.ReverseArray();
            else if (task == 7)
                return Arrays.PartTwo.GetSummOddIndexes();
            else if (task == 8)
                return Arrays.PartTwo.ChangeArrayHalves();
            else if (task == 9)
                return Arrays.SomeSorts.BubbleSort();
            else if (task == 10)
                return(Arrays.SomeSorts.SelectSort());
            else
                Console.WriteLine("Error task");
            return (-1);
        }
    }
}
