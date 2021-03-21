namespace Prototype
{
    internal class Identifier: IIdentifier
    {
        public Identifier(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}