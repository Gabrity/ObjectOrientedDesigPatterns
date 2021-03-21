namespace Visitor
{
    public interface IGameItem : IVisitable
    {
        public string Name { get; }
        public double Price { get; }
    }
}