﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class SumOfNumbsBySeven
    {
        public static int GetSumDivsBySeven()
        {
            int a, b;
            int tmp;
            int res;

            res = 0;
            Console.WriteLine("Task 5");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            while (a++ < b)
            {
                if (a % 7 == 0)
                    res += a;
            }
            return res;
        }
    }
}