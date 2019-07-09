namespace ClassAdapter
{
    // the adapter
    class TextWindow : TextBox, IWindow
    {
        // The class adapter uses inhertance in the adapter class
                public TextWindow(string text, IPoint origin, double height, double width) 
            : base(text, origin, height, width)
        {
        }

        public IPoint BottomLeft()
        {
            return Origin;
        }

        public IPoint TopRight()
        {
            double x = Origin.X + Width;
            double y = Origin.Y + Height;
            IPoint topRight = AdapterFactory.GetNewPoint(x, y);
            return topRight;
        }

        public IManipulator CreateManipulator()
        {
            return AdapterFactory.GetNewManipulator(this);
        }

        bool IWindow.IsEmpty()
        {
            return IsEmpty();
        }
    }
}
