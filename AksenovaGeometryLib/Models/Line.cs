using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksenovaGeometryLib.Models
{
    public class Line(double startX, double startY, double endX, double endY) : Shape((startX + endX) / 2, (startY + endY) / 2)
    {
        public double StartX { get; private set; } = startX;
        public double StartY { get; private set; } = startY;
        public double EndX { get; private set; } = endX;
        public double EndY { get; private set; } = endY;


        public override (double X, double Y, double Width, double Height) GetBoundingBox()
        {
            var minX = Math.Min(StartX, EndX);
            var minY = Math.Min(StartY, EndY);
            var maxX = Math.Max(StartX, EndX);
            var maxY = Math.Max(StartY, EndY);

            return (minX, minY, maxX - minX, maxY - minY);
        }
        public override double GetArea()
        {
            return 0;
        }
    }
}
