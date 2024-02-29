using MyPaintAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Shapes.Triangle
{
    public class FillTriangle : MyShape<FillTriangle>, ITriangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int PenWidth { get; set; }
        public Color PenColor { get; set; }
        public Color BrushColor { get; set; }

        public IShape Clone()
        {
            return (FillTriangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new(BrushColor);

            int triangleHeight = (int)(Math.Sqrt(3) * W / 2);

            int centerX = X + W / 2;

            Point SPoint = new(centerX - W / 2, Y + triangleHeight);
            Point EPoint = new(centerX + W / 2, Y + triangleHeight);
            Point MPoint = new(centerX, Y);

            g.FillPolygon(brush, new Point[] { MPoint, SPoint, EPoint });
        }

        public void Rotate()
        {
        }
    }
}
