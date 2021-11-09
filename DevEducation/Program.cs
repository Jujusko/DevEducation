using System;
using System.Linq;


/*
 * Реализация большого проекта — очень сложная задача, и при разработке программист Алексей руководствуется следующим принципом: сначала написать работающий прототип, а потом улучшать код. Чтобы не забыть, что именно отложено на потом, на каждый такой долг Алексей заводит на себя задачу в специальной системе Yagile.
Система устроена следующим образом: для каждой задачи задается дедлайн — день ti
. Если задача не решена до этого момента времени, то в задачу приходит робот и пишет комментарий о том, что задачу надобно закрыть. Если через X 
дней задача не решена, то робот приходит снова. Так продолжается до тех пор, пока задача не будет решена.
Алексей каждый день заходит в Yagile и видит сообщения от робота. Если Алексей не хочет приступать к решению накопленных задач, то он прочитывает все сообщения с помощью одной кнопки и занимается другими делами.
Однако Алексей понимает, что так долго делать нельзя, поэтому он разрешает себе нажимать на эту кнопку ровно K − 1 раз, а на K-й 
раз садится и решает все задачи разом (даже те, у которых не настал дедлайн).


*/
namespace DevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(data[0]);
            int x = Convert.ToInt32(data[1]);
            int k = Convert.ToInt32(data[2]);
            int[] dLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index;
            int currentDay = 0;
            int[] sortedCopy = dLine.OrderBy(i => i).ToArray();
            while (k > 0)
            {
                index = Array.BinarySearch(sortedCopy, currentDay);
                if (index < 0)
                    currentDay++;
                else
                {
                    sortedCopy[index] += x;
                    sortedCopy = sortedCopy.OrderBy(i => i).ToArray();
                    currentDay++;
                    k--;
                }
            }
            currentDay--;
            Console.WriteLine(currentDay);
        }

    }
}
