using MyPaintAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Shapes.Triangle
{
    public class PatternTriangle : MyShape<PatternTriangle>, ITriangle
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
            return (PatternTriangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            HatchStyle style = HatchStyle.LargeGrid;
            HatchBrush brush = new(style, PenColor, BrushColor);

            int triangleHeight = (int)(Math.Sqrt(3) * W / 2);

            int centerX = X + W / 2;

            Point SPoint = new(centerX - W / 2, Y + triangleHeight);
            Point EPoint = new(centerX + W / 2, Y + triangleHeight);
            Point MPoint = new(centerX, Y);

            g.FillPolygon(brush, new Point[] { MPoint, SPoint, EPoint });

            Pen borderPen = new Pen(PenColor, PenWidth + 4);
            g.DrawPolygon(borderPen, new Point[] { MPoint, SPoint, EPoint });
        }
    }
}
