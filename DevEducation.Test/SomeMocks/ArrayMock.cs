using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Test.SomeMocks
{
    [Flags]
    public enum Flags
    {
        Usual1,
        OnlyNegativeNumbers,
        OnlyPositiveNUmbers,
        EmptyArray,
        Usual2
    }
    public class ArrayMock
    {
        public static int[] Arrays(Flags flag, int[] array)
        {
            if (flag == Flags.Usual1)
                array = new int[10] { 1, 2, 3, 5, 22, -23, 45, 333, -12345, 0 };
            else if (flag == Flags.Usual2)
                array = new int[10] { 4, -70, 2, 32, -10, -61, -91, 28, 26, -53 };
            else if (flag == Flags.OnlyNegativeNumbers)
                array = new int[10] { -102, -311, -275, -23, -162, -135, -377, -131, -669, -164 };
            else if (flag == Flags.OnlyPositiveNUmbers)
                array = new int[10] { 83, 75, 74, 86, 23, 67, 85, 64, 45, 40 };
            else if (flag == Flags.EmptyArray)
                array = new int[] {};
            return array;
            
        }
    }
}
