using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose
{
    class Triangle : IArea
    {
        public double Trianglebase { get; set; }
        public double Triangleheight { get; set; }

        public double Area()
        {
            var area = (Trianglebase * Triangleheight) / 2;
            return area;
        }
    }
}
