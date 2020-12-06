using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose
{
    class Rectangle : IArea
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            var area = Height * Width;
            return area;
        }
    }
}
