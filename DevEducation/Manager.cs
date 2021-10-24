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
            return (1);
        }
    }
}
