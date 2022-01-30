using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    abstract class Shape
    {
        public static double GetTotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (Shape shape in shapes)
            {
                totalArea += shape.GetArea();
                
            }
            return totalArea;
        }
        abstract public double GetArea();
    }
}
