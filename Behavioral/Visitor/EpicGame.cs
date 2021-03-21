namespace Visitor
{
    public class EpicGame : IEpicGame
    {
        public string Name { get; }
        public double Price { get; }
        public int Rating { get; }

        public EpicGame(string name, double price, int rating)
        {
            Name = name;
            Price = price;
            Rating = rating;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEpicGame(this);
        }
    }
}