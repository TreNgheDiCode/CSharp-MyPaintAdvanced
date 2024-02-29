using MyPaintAdvanced.Shapes;

namespace MyPaintAdvanced
{
    public sealed class DrawingPen
    {
        private static readonly DrawingPen instance = new();
        private static decimal _penWidth;
        private static Color _penColor;
        private static Color _fillColor;
        private static Point _sPoint;
        private static Point _ePoint;

        public static DrawingPen Instance
        {
            get
            {
                return instance;
            }
        }


        public static decimal PenWidth 
        { 
            get => _penWidth;
            set 
            { 
                if ((int)value < 1) 
                    _penWidth = 1; 
                
                _penWidth = value; 
            } 
        }
        public static Color PenColor { get => _penColor; set => _penColor = value; }
        public static Color FillColor { get => _fillColor; set => _fillColor = value; }
        public static Point S {  get => _sPoint; set => _sPoint = value; }
        public static Point E {  get => _ePoint; set => _ePoint = value; }

        private DrawingPen()
        {

        }

        public static void GetPenShape(IShape shape)
        {
            shape.X = Math.Min(_sPoint.X, _ePoint.X);
            shape.Y = Math.Min(_sPoint.Y, _ePoint.Y);
            shape.W = Math.Abs(_sPoint.X - _ePoint.X);
            shape.H = Math.Abs(_sPoint.Y - _ePoint.Y);
            shape.PenWidth = (int)PenWidth;
            shape.PenColor = PenColor;
            shape.BrushColor = FillColor;
        }
    }
}
