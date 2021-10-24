using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class Numbs
    {
        public static void SortNumbs()
        {
            int a, b, c;

            Console.WriteLine("Put 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            
            if (a < b && a < c)
            {
                Console.Write(a + " ");
                if (b < c)
                {
                    Console.Write(b + " ");
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(b + " ");
                }
            }
            if (b < a && b < c)
            {
                Console.Write(b + " ");
                if (a < c)
                {
                    Console.Write(a + " ");
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(a + " ");
                }
            }
            if (c < a && b > c)
            {
                Console.Write(c + " ");
                if (b < a)
                {
                    Console.Write(b + " ");
                    Console.Write(a + " ");
                }
                else
                {
                    Console.Write(a + " ");
                    Console.Write(b + " ");
                }
            }
        }
    }
}
