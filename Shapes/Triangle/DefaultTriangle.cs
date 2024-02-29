using MyPaintAdvanced.Interfaces;

namespace MyPaintAdvanced.Shapes.Triangle
{
    public class DefaultTriangle : MyShape<DefaultTriangle>, ITriangle
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
            return (DefaultTriangle)MemberwiseClone();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new(PenColor, PenWidth);

            int triangleHeight = (int)(Math.Sqrt(3) * W / 2);

            int centerX = X + W / 2;

            Point SPoint = new(centerX - W / 2, Y + triangleHeight);
            Point EPoint = new(centerX + W / 2, Y + triangleHeight);
            Point MPoint = new(centerX, Y);

            g.DrawPolygon(pen, new Point[] { SPoint, EPoint, MPoint });
        }
    }
}
