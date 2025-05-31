using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksenovaGeometryLib.Models
{
    public class Ellipse(double centerX, double centerY, double radiusX, double radiusY) : Shape(centerX, centerY)
    {
        public double RadiusX { get; set; } = radiusX;
        public double RadiusY { get; set; } = radiusY;

        public override (double X, double Y, double Width, double Height) GetBoundingBox()
        {
            return (CenterX - RadiusX, CenterY - RadiusY, 2 * RadiusX, 2 * RadiusY);
        }
        public override double GetArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }
    }
}
