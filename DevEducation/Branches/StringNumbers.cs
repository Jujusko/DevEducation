using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Branches
{
    public class StringNumbers
    {
        //ЭТО КОПЕТС КАКОЙ-ТО
        // но было интересно
        public static string GetString(int a)
        {
            Dictionary<int, string> StringNumb = new Dictionary<int, string>();
            string RemoveLastChar;
            char[] MyChar = { 'ь', 'е'};
            string toReturnNumb;
            
            
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

            if (a > 0 && a < 11)
                toReturnNumb = StringNumb[a];
            else if (a > 10 && a < 20)
            {
                RemoveLastChar = StringNumb[a % 10].TrimEnd(MyChar);
                toReturnNumb = RemoveLastChar + "надцать";
                Console.WriteLine(RemoveLastChar + "надцать");
            }
            else if (a > 19 && a < 100)
            {
                toReturnNumb = StringNumb[a / 10 * 10];
                if (a % 10 != 0)
                    toReturnNumb += StringNumb[a % 10];
            }
            else
                throw new ArgumentException("Bad number!");
            return toReturnNumb;
        }
    }
}
