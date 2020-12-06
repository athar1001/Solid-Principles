using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    class FileLogger : ILogger
    {

        public void Log(string message)
        {
            LogToFile(message);
        }
        private void LogToFile(string message)
        {
            Console.WriteLine("Log To File: {0}", message);
        }
    }
}
