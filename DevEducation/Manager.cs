using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    class Manager
    {
        public static dynamic ManageTasks(int day, int task)
        {
            
            if(day == 1)
                return(FirstHomework.AllTasks(task));
            if (day == 2)
                return SecondDay.CheckTasksBranches(task);
            if (day == 3)
                return (ThirdDay.AllTasks(task));
            return (1);
        }
    }
}
