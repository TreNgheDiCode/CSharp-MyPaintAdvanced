using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes.Circles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Shapes.Rectangles
{
    public class FillRectangle : MyShape<FillRectangle>, IRectangle
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
            return (FillRectangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new(BrushColor);

            g.FillRectangle(brush, X, Y, W, H);
        }
    }
}
