using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes.Circles;
using MyPaintAdvanced.Shapes.Rectangles;
using MyPaintAdvanced.Shapes.Triangle;

namespace MyPaintAdvanced.Factories
{
    public class DefaultShapeFactory : IShapeFactory
    {
        private static DefaultShapeFactory _instance;

        private static int totalInstances = 0;

        public static DefaultShapeFactory Instance 
        { 
            get 
            { 
                if (_instance == null)
                {
                    _instance = new DefaultShapeFactory();
                }

                return _instance; 
            } 
            set
            {
                if (value == null)
                {
                    _instance = null;
                    totalInstances--;
                }
            }
        }

        public static int TotalInstances { get { return totalInstances; } }

        private DefaultShapeFactory()
        {
            totalInstances++;
        }

        public IRectangle CreateRectangle() => DefaultRectangle.Instance;

        public ICircle CreateCircle() => DefaultCircle.Instance;
        public ITriangle CreateTriangle() => DefaultTriangle.Instance;
        public void ResetRectangle() => DefaultRectangle.ResetInstance();

        public void ResetCircle() => DefaultCircle.ResetInstance();
        public void ResetTriangle() => DefaultTriangle.ResetInstance();
        public int GetShapeCount() => DefaultRectangle.TotalInstances + DefaultCircle.TotalInstances + DefaultTriangle.TotalInstances;
    }
}
