namespace MyPaintAdvanced.Shapes
{
    public abstract class MyShape<T> where T : class
    {
        private static int totalInstances = 0;
        private static Lazy<T> Lazy =
        new(() => (Activator.CreateInstance(typeof(T), true) as T)!);

        public static T Instance => Lazy.Value;

        public static int TotalInstances
        {
            get
            {
                return totalInstances;
            }
        }

        protected MyShape()
        {
            totalInstances++;
        }

        public static void ResetInstance()
        {
            Lazy = new Lazy<T>(() => (Activator.CreateInstance(typeof(T), true) as T)!);
        }
    }
}
