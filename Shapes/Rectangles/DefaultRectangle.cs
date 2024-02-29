using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes.Circles;

namespace MyPaintAdvanced.Shapes.Rectangles
{
    public sealed class DefaultRectangle : MyShape<DefaultRectangle>, IRectangle
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
            return (DefaultRectangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new(PenColor, PenWidth);

            g.DrawRectangle(pen, X, Y, W, H);
        }
    }
}
