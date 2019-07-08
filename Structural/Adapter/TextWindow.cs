namespace ObjectAdapter
{
    // the adapter
    class TextWindow : IWindow
    {
        // we adapt by composition
        private ITextBox _textBox;

        public TextWindow(ITextBox textBox)
        {
            _textBox = textBox;
        }

        public IPoint BottomLeft()
        {
            return _textBox.Origin;
        }

        public IPoint TopRight()
        {
            double x = _textBox.Origin.X + _textBox.Width;
            double y = _textBox.Origin.Y + _textBox.Height;
            IPoint topRight = AdapterFactory.GetNewPoint(x, y);
            return topRight;
        }

        public IManipulator CreateManipulator()
        {
            return AdapterFactory.GetNewManipulator(this);
        }

        public bool IsEmpty()
        {
            return _textBox.IsEmpty();
        }
    }
}
