using System;

namespace ClassAdapter
{
    public static class AdapterFactory
    {
        // factory methods, no concrete implementation
        public static IPoint GetNewPoint(double x, double y)
        {
            throw new NotImplementedException();
        }

        public static IManipulator GetNewManipulator(IWindow textWindow)
        {
            throw new NotImplementedException();
        }
    }
}
