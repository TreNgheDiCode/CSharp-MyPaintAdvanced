﻿using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes.Circles;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Shapes.Rectangles
{
    public class PatternRectangle : MyShape<PatternRectangle>, IRectangle
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
            return (PatternRectangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            HatchStyle style = HatchStyle.LargeGrid;
            HatchBrush brush = new(style, PenColor, BrushColor);

            g.FillRectangle(brush, X, Y, W, H);
        }
    }
}
