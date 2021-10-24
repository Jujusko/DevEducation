using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class ThirdDay
    {
        public static dynamic AllTasks(int task)
        {
            if (task == 1)
                return (Loops.APowB.DoAPowB());
            else if (task == 2)
                return (Loops.Multiples.FindMultiples());
            else if (task == 3)
                return Loops.LessThenA.FindNumbers();
            else if (task == 4)
                return Loops.MaxDiv.FindMaxDivNumb();
            else if (task == 5)
                return Loops.SumOfNumbsBySeven.GetSumDivsBySeven();
            else if (task == 6)
                return (Loops.Fibonacci.FindFibo());
            else if (task == 7)
                return (Loops.Evklid.BiggestDiv());
            else if (task == 8)
                return (Loops.Task8.HalfDivMethod());
            else if (task == 9)
                return (Loops.OddDigits.FindAmntOddDigits());
            else if (task == 10)
                Loops.MirrorNumb.FindMirror();
            else if (task == 11)
                return (Loops.WTF.WTFIdkWhatIshouldToDo());
            else if (task == 12)
                return (Loops.Dubs.FindDubs());
            else
                Console.WriteLine("Error task");
            return (-1);
        }
    }
}
