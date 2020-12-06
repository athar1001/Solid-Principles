using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation
{
    interface ICreate
    {
        void CreateTask();

    }
    interface IAssign
    {
        void AssignTask();
    }
    interface ITaskProgress
    {
        void TaskProgress();

    }
}
