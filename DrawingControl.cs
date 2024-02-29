using MyPaintAdvanced.Shapes;
using MyPaintAdvanced;
using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Factories;

namespace MyPaintAdvanced
{
    public class DrawingControl
    {
        private static readonly DrawingControl _instance = new(); // Singleton instance
        private readonly LinkedList<IShape> _shapes; // List of shapes

        public static DrawingControl Instance
        {
            get
            {
                return _instance;
            }
        }

        private DrawingControl()
        {
            _shapes = new LinkedList<IShape>();
        }

        public void AddShape(IShape shape)
        {
            _shapes.AddLast(shape);
        }

        public void DrawAll(Graphics g)
        {
            foreach (IShape shape in _shapes)
            {
                shape.Draw(g);
            }
        }

        public void DrawPrevShape(Graphics g, int panelWidth, int panelHeight)
        {
            if (_shapes.Count <= 0) return;

            IShape shape = _shapes.Last.Value.Clone();
            shape.W = shape.W > panelWidth ? shape.W - (shape.W - panelWidth) - 30 : shape.W;
            shape.H = shape.H > panelHeight ? shape.H - (shape.H - panelHeight) - 30 :  shape.H;
            shape.X = panelWidth / 2 - shape.W / 2;
            shape.Y = panelHeight / 2 - shape.H / 2;
            shape.Draw(g);
        }

        public void DrawClone(Graphics g, Point e)
        {
            if (_shapes.Count <= 0) return;

            IShape shape = _shapes.Last.Value.Clone();
            shape.X = e.X;
            shape.Y = e.Y;
            shape.Draw(g);
            AddShape(shape);
        }

        public static int GetShapeCount() => DefaultShapeFactory.Instance.GetShapeCount() + FillShapeFactory.Instance.GetShapeCount() + PatternShapeFactory.Instance.GetShapeCount();
    }
}
