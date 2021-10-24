using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    class WTF
    {
        public static int WTFIdkWhatIshouldToDo()
        {
            int i;
            int odd, notOdd;
            int cnt;

            i = Convert.ToInt32(Console.ReadLine());
            odd = 0;
            notOdd = 0;
            cnt = 0;
            while (cnt++ < i)
            {
                if (cnt % 2 == 1)
                    odd += cnt;
                else
                    notOdd += cnt;
            }
            return (notOdd - odd);
        }
    }
}
