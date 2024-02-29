using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes.Circles;
using MyPaintAdvanced.Shapes.Rectangles;
using MyPaintAdvanced.Shapes.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAdvanced.Factories
{
    public class PatternShapeFactory : IShapeFactory
    {
        private static PatternShapeFactory _instance;

        private static int totalInstances = 0;

        public static PatternShapeFactory Instance
        {
            get
            {
                _instance ??= new PatternShapeFactory();

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

        private PatternShapeFactory()
        {
            totalInstances++;
        }
        public ICircle CreateCircle() => PatternCircle.Instance;

        public IRectangle CreateRectangle() => PatternRectangle.Instance;

        public ITriangle CreateTriangle() => PatternTriangle.Instance;

        public int GetShapeCount() => PatternRectangle.TotalInstances + PatternCircle.TotalInstances + PatternTriangle.TotalInstances;

        public void ResetCircle() => PatternCircle.ResetInstance();

        public void ResetRectangle() => PatternRectangle.ResetInstance();

        public void ResetTriangle() => PatternTriangle.ResetInstance();
    }
}
