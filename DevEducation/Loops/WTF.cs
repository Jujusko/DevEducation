using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class WTF
    {
        public static int WTFIdkWhatIshouldToDo(int i)
        {
            int odd, notOdd;
            int cnt;

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
