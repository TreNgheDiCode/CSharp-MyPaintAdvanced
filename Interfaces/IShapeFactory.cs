namespace MyPaintAdvanced.Interfaces
{
    public interface IShapeFactory
    {
        IRectangle CreateRectangle();
        ICircle CreateCircle();
        ITriangle CreateTriangle();
        int GetShapeCount();
        void ResetRectangle();
        void ResetCircle();
        void ResetTriangle();
    }
}
