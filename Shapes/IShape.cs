namespace MyPaintAdvanced.Shapes
{
    public interface IShape
    {
        int X { get; set; }
        int Y { get; set; }
        int W { get; set; }
        int H { get; set; }
        int PenWidth { get; set; }
        Color PenColor { get; set; }
        Color BrushColor { get; set; }

        IShape Clone();

        void Draw(Graphics g);
    }
}
