namespace Iterator
{
    internal class Band : IBand
    {
        public string Name { get; }
        public string Genre { get; }
        public int NumberOfMembers { get; }

        public Band(string name, string genre, int numberOfMembers)
        {
            Name = name;
            Genre = genre;
            NumberOfMembers = numberOfMembers;
        }
    }
}
