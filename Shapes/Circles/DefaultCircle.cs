using MyPaintAdvanced.Interfaces;

namespace MyPaintAdvanced.Shapes.Circles
{
    public sealed class DefaultCircle : MyShape<DefaultCircle>, ICircle
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
            return (DefaultCircle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new(PenColor, PenWidth);

            g.DrawEllipse(pen, X, Y, W, H);
        }
    }
}
