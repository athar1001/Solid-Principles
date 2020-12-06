using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    class DatabseLogger : ILogger
    {
        public void Log(string message)
        {
            LogToFile(message);
        }
        private void LogToFile(string message)
        {
            Console.WriteLine("Log To the Database: {0}", message);
        }
    }
}
