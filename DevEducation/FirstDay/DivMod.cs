using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.FirstDay
{
    class DivMod
    {
        public static void PrintDivMod(int a, int b)
        {


            Console.WriteLine("Пользователь вводит 2 числа (A и B). Выведите " +
                "в консоль решение по уравнению");

            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
