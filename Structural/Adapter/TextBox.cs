using System;

namespace ObjectAdapter
{
    class TextBox : ITextBox
    {
        public IPoint Origin { get; }
        public double Height { get; }
        public double Width { get; }
        private string _text;

        public TextBox(string text, IPoint origin, double height, double width)
        {
            _text = text;
            Origin = origin;
            Height = height;
            Width = width;
        }

        public bool IsEmpty()
        {
            return _text == String.Empty;
        }
    }
}
