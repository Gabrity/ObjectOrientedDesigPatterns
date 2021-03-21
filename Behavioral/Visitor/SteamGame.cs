namespace Visitor
{
    public class SteamGame : ISteamGame, IVisitable
    {
        public string Name { get; }
        public double Price { get; }
        public string Developer { get; }

        public SteamGame(string name, double price, string developer)
        {
            Name = name;
            Price = price;
            Developer = developer;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSteamGame(this);
        }
    }
}