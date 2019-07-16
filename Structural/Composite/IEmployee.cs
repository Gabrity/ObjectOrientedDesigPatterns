namespace Composite
{
    public interface IEmployee
    {
        double SalesMade();
        string Name();
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
    }
}