﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation
{
    class Lead : ICreate, IAssign, IProgress
    {
        void CreateTask()
        {
            Console.WriteLine("Task Created");
        }
        void AssignTask()
        {
            Console.WriteLine("Task has been assigned");
        }
        void TaskProgress()
        {
            Console.WriteLine("Task Progres is ....");

        }
    }
}
