using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    class ProductAndService
    {
        private readonly ILogger _logger;

        public void Log(string message)
        {
            _logger.Log(message);

        }

    }
}
