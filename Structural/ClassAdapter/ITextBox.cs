namespace ClassAdapter
{
    // the adaptee
    public interface ITextBox
    {
        IPoint Origin { get; }
        double Height { get; }
        double Width { get; }
        bool IsEmpty();
    }
}