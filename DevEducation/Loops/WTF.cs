using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Loops
{
    public class WTF
    {
        public static int[] WTFIdkWhatIshouldToDo(int x)
        {
            int p;
            int b; 
            int ChetnihDigits;
            int NechetDigits;
            int arraySize;
            int[] array;
            int lenghtArray;

            arraySize = 0;
            p = -1;
            while (++p <= x)
            {
                b = p;
                ChetnihDigits = 0;
                NechetDigits = 0;
                while (b != 0)
                {
                    if ((b % 10) % 2 == 0)
                        ChetnihDigits += b % 10;
                    else
                        NechetDigits += b % 10;
                    b /= 10;
                }
                if (ChetnihDigits > NechetDigits)
                    arraySize++;
              
            }
            lenghtArray = 0;
            array = new int[arraySize];
            p = 0;
            while (p <= x)
            {
                b = p;
                ChetnihDigits = 0;
                NechetDigits = 0;
                while (b != 0)
                {
                    if ((b % 10) % 2 == 0)
                        ChetnihDigits += b % 10;
                    else
                        NechetDigits += b % 10;
                    b /= 10;
                }
                if (ChetnihDigits > NechetDigits)
                {
                    array[lenghtArray] = p;
                    lenghtArray++;
                }
                p++;
            }
            return array;
        }
    }
}
