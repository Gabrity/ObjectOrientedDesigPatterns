namespace ClassAdapter
{
    // interface we adapt to
    public interface IWindow
    {
        IPoint BottomLeft();
        IPoint TopRight();
        IManipulator CreateManipulator();
        bool IsEmpty();
    }
}
