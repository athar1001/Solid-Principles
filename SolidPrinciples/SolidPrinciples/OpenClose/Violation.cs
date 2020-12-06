using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose
{
    class Violation
    {
        public double TotalArea(Object[] shapeObjects)
        {
            double area = 0;
            foreach(var obj in shapeObjects)
            {
                if(obj is Rectangle)
                {
                    var ObjRectangle =  (Rectangle)obj;
                    area = ObjRectangle.Height * ObjRectangle.Width;
                }
                else if
                {
                    var ObjCircle = (Circle)obj;
                    area = ObjCircle.Radius * ObjCircle.Radius * Math.PI;
                }
                else
                {
                    var ObjTriangle = (Triangle)obj;
                    area = (ObjTriangle.Trianglebase * ObjTriangle.Triangleheight)/ 2;

                }
            }

            return area;
        }
    }
}
