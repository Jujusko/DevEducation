using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class Debug1
    {
        public static int[] GetNumbersWhereSumOfEvenDigitsGreaterThanOddDigits(int x)
        {
            int kolichestvoChetkihChisel = 0;
            int sumNechet = 0;
            int sumChet = 0;
            for (int i = 0; i <= x; i++)
            {
                int b = i;
                int n;
                 sumNechet = 0;
                 sumChet = 0;

                while (b != 0)
                {
                    n = b % 10;
                    if (n % 2 != 0)
                    {
                        sumNechet = sumNechet + n;

                    }
                    else
                    {
                        sumChet = sumChet + n;
                    }
                    b = b / 10;
                }
                if (sumChet > sumNechet)
                {
                    kolichestvoChetkihChisel++;
                }
            }
            Console.WriteLine(kolichestvoChetkihChisel);
            int[] chetkiyMassiv = new int[kolichestvoChetkihChisel];
            int j = 0;
            
            for (int i = 0; i <= x; i++)//i = 66
            {
                int b = i;//b = 66
                int n; // 0
                 sumNechet = 0;
                 sumChet = 0;

                while (b != 0)// 66
                {
                    n = b % 10;//
                    if (n % 2 != 0)
                    {
                        sumNechet = sumNechet + n;
                    }
                    else
                    {
                        sumChet = sumChet + n;//6//6 + 6
                    }
                    b = b / 10; 
                }
               if (sumChet > sumNechet)
               {
                   chetkiyMassiv[j] = i;//[0] = 66
                   j++;
               }
            }
            return chetkiyMassiv;
        }
    }
}
