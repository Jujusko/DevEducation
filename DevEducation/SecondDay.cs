using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class SecondDay
    {
        public static dynamic CheckTasksBranches(int task)
        {
            if (task == 1)
                return Branches.Branches.AnaliseAAndB();
            if (task == 2)
                return Branches.FindQuarter.ReturnQuarter();
            if (task == 3)
            {
                Branches.Numbs.SortNumbs();
                return 1;
            }
            if (task == 4)
                return Branches.Disc.GetSquares();
            if (task == 5)
            {
                Branches.StringNumbers.GetString();
                return 1;
            }
            return 1;
        }
    }
}
