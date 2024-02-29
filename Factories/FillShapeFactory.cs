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
    public class FillShapeFactory : IShapeFactory
    {
        private static FillShapeFactory _instance;

        private static int totalInstances = 0;

        public static FillShapeFactory Instance
        {
            get
            {
                _instance ??= new FillShapeFactory();

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

        private FillShapeFactory()
        {
            totalInstances++;
        }
        public ICircle CreateCircle() => FillCircle.Instance;

        public IRectangle CreateRectangle() => FillRectangle.Instance;

        public ITriangle CreateTriangle() => FillTriangle.Instance;

        public int GetShapeCount() => FillRectangle.TotalInstances + FillCircle.TotalInstances + FillTriangle.TotalInstances;

        public void ResetCircle() => FillCircle.ResetInstance();

        public void ResetRectangle() => FillRectangle.ResetInstance();

        public void ResetTriangle() => FillTriangle.ResetInstance();
    }
}
