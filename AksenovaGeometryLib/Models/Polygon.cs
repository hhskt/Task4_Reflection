using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksenovaGeometryLib.Models
{
    public class Polygon(IList<(double X, double Y)> vertices) : Shape(vertices.Average(v => v.X), vertices.Average(v => v.Y))
    {
        public IList<(double X, double Y)> Vertices { get; set; } = vertices;

        public override (double X, double Y, double Width, double Height) GetBoundingBox()
        {
            var minX = double.MaxValue;
            var minY = double.MaxValue;
            var maxX = double.MinValue;
            var maxY = double.MinValue;

            foreach (var (x, y) in Vertices)
            {
                if (x < minX) minX = x;
                if (y < minY) minY = y;
                if (x > maxX) maxX = x;
                if (y > maxY) maxY = y;
            }

            return (minX, minY, maxX - minX, maxY - minY);
        }

        public override double GetArea()
        {
            if (Vertices.Count < 3)
                return 0;

            double area = 0;
            int j = Vertices.Count - 1;

            for (int i = 0; i < Vertices.Count; i++)
            {
                area += (Vertices[j].X + Vertices[i].X) * (Vertices[j].Y - Vertices[i].Y);
                j = i;
            }

            return Math.Abs(area) / 2.0;
        }
    }
}
