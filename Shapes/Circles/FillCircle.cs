using MyPaintAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Shapes.Circles
{
    public class FillCircle : MyShape<FillCircle>, ICircle
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
            return (FillCircle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new(BrushColor);

            g.FillEllipse(brush, X, Y, W, H);
        }
    }
}
