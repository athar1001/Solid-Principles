using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose
{
    class Circle : IArea
    {
        public double Radius { get; set; }

        public double Area()
        {
            var area = Radius * Radius * Math.PI;
            return area;
        }
    }
}
