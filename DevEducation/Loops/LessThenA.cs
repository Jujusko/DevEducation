using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class LessThenA
    {
        public static int FindNumbers(int a)
        {
            int maxNumber;

            maxNumber = 1;
            while (maxNumber * maxNumber < a)
                maxNumber++;
            return maxNumber - 1;
        }
    }
}
