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
        Usual2,
        NonSquare,//for double array
        OneInAll,
        SameValue,
        OneElem
    }
    public class ArrayMock
    {
        public static int[] Arrays(Flags flag)
        {
            int[] array = new int[] { };

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
            else if (flag == Flags.OneElem)
                array = new int[] { 10 };
            else if (flag == Flags.SameValue)
                array = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            return array;
            
        }
        public static int[,] DoubleArrays(Flags flag)
        {
            int[,] array = new int[,] { };

            if (flag == Flags.Usual1)
                array = new int[6, 6] {
                    { 28, 13, 24, 0, 33, 48 },
                    {19 , 8 ,34 ,24 , 2 ,49},
                    {19 , 8 ,34 ,24 , 2 ,49},
                    {19 , 8 ,34 ,24 , 2 ,49},
                    {19 , 8 ,34 ,24 , 2 ,49},
                    { 19 , 8 ,34 ,24 , 2 ,49} };
            //max numb 49; index = [1,5]
            else if (flag == Flags.Usual2)
                array = new int[6, 6] {
                    { 79, 73, 30, 46, 75, 61, },
                    { 25, 7, 19, 51, 84, 52, },
                    { 2, 21, 96, 7, 42, 19, },
                    { 7, 23, 99, 34, 69, 39, },
                    { 33, 24, 93, 70, 43, 88, },
                    { 32, 63, 2, 43, 45, 18, },
                    };
            //max numb 99 index 3,2
            else if (flag == Flags.OnlyNegativeNumbers)
                array = new int[6, 6] {
                    { -87, -93, -64, -97, -86, -38, },
                    { -55, -100, -31, -6, -59, -30, },
                    { -78, -22, -56, -45, -84, -57, },
                    { -37, -58, -41, -11, -16, -57, },
                    { -57, -90, -50, -86, -97, -88, },
                    { -8, -69, -92, -22, -80, -52, },
                    };
            else if (flag == Flags.OnlyPositiveNUmbers)
                array = new int[6, 6] {
                    { 79, 73, 30, 46, 75, 61, },
                    { 25, 7, 19, 51, 84, 52, },
                    { 2, 21, 96, 7, 42, 19, },
                    { 7, 23, 99, 34, 69, 39, },
                    { 33, 24, 93, 70, 43, 88, },
                    { 32, 63, 2, 43, 45, 18, },
                    };

            else if (flag == Flags.NonSquare)
                array = new int[6, 3]{
                    { 43, -51, 13, },
                    { 22, -23, -100, },
                    { 72, 62, -74, },
                    { 83, 5, -70, },
                    { -66, 50, -93, },
                    { 10, 66, 50, },
                    };
            else if (flag == Flags.OneInAll)
                array = new int[6, 3]{
                    { 2, 2, 2, },
                    { 2, 2, 2, },
                    { 2, 2, 2, },
                    { 2, 2, 2, },
                    { 2, 2, 2, },
                    { 2, 2, 2, },
                    };
            else if (flag == Flags.EmptyArray)
                array = new int[,] { };

            return array;
        }
    }
}
