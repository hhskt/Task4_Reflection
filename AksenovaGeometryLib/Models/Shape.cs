using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksenovaGeometryLib.Models
{
    public abstract class Shape(double centerX, double centerY)
    {
        public double CenterX { get; protected set; } = centerX;
        public double CenterY { get; protected set; } = centerY;

        public abstract (double X, double Y, double Width, double Height) GetBoundingBox();
        public abstract double GetArea();
    }
}
