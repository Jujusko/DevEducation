using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class LessThenA
    {
        public static int FindNumbers(int a)
        {
            int maxNumber;

            Console.WriteLine("Task 3");
            maxNumber = 1;
            while (maxNumber * maxNumber < a)
                maxNumber++;
            return maxNumber - 1;
        }
    }
}
