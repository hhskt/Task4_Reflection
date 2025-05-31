using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksenovaGeometryLib.Models
{
    public class Point(double x, double y) : Shape(x, y)
    {
        public override (double X, double Y, double Width, double Height) GetBoundingBox()
        {
            return (CenterX, CenterY, 0, 0);
        }
        public override double GetArea()
        {
            return 0;
        }
    }
}
