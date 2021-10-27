using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
     public class DivMod
    {
        public static (int, int) PrintDivMod(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error. Divide by Zero");
                return (0, 0);
            }
            return ((a / b), (a % b));
        }
    }
}
