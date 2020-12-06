using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose
{
    class ShapeAreaCalculator
    {
        public double TotalArea(IArea[] shapeObjects)
        {
            double area = 0;
            foreach (var obj in shapeObjects)
            {
                 area += obj.Area();
            }

            return area;
        }
    }
}
