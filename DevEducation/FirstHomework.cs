﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class FirstHomework
    {
        public static dynamic AllTasks(int task)
        {
            if (task == 1)
                FirstDay.Formula.GetSolution();
            else if (task == 2)
                return FirstDay.Swap.SwapNumbs();
            else if (task == 3)
                FirstDay.DivMod.PrintDivMod();
            else if (task == 4)
                return FirstDay.LineFormula.Solution();
            else if (task == 5)
                return FirstDay.LineFormula2.DoSolution();
            return 1;
        }
    }
}