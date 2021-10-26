using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    class StringNumbers
    {
        //ЭТО КОПЕТС КАКОЙ-ТО
        // но было интересно
        public static void GetString(int a)
        {
            Dictionary<int, string> StringNumb = new Dictionary<int, string>();
            string RemoveLastChar;
            char[] MyChar = { 'ь', 'е'};
            
            if (a > 99 || a < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            StringNumb.Add(1, "Один");
            StringNumb.Add(2, "Два");
            StringNumb.Add(3, "Три");
            StringNumb.Add(4, "Четыре");
            StringNumb.Add(5, "Пять");
            StringNumb.Add(6, "Шесть");
            StringNumb.Add(7, "Семь");
            StringNumb.Add(8, "Восемь");
            StringNumb.Add(9, "Девять");
            StringNumb.Add (10, "Десять");
            StringNumb.Add (20, "Двадцать");
            StringNumb.Add (30, "Тридцать");
            StringNumb.Add (40, "Сорок");
            StringNumb.Add (50, "Пятьдесят");
            StringNumb.Add (60, "Шестьдесят");
            StringNumb.Add (70, "Семьдесят");
            StringNumb.Add (80, "Восемьдесят");
            StringNumb.Add (90, "Девяносто");

            if (a > 10 && a < 20)
            {
                RemoveLastChar = StringNumb[a % 10].TrimEnd(MyChar);
                Console.WriteLine(RemoveLastChar + "надцать");
            }
            if (a > 19)
            {
                Console.Write(StringNumb[a / 10 * 10]);
                if (a % 10 != 0)
                    Console.WriteLine(StringNumb[a % 10]);
            }
        }
    }
}
