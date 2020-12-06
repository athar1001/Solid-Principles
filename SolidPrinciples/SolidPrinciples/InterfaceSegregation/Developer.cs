using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation
{
    class Developer : ITaskProgress
    {
     
        void TaskProgress()
        {
            Console.WriteLine("Task Progres is ....");

        }

    }
}
