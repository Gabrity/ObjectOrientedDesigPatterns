using System.Collections;

namespace Iterator
{
    public class BandArrayStorage : IEnumerable
    {
        private readonly IBand[] _arrayItems;

        public BandArrayStorage()
        {
            _arrayItems = new IBand[]
            {
                new Band("Abba", "Pop", 4),
                new Band("The Beatles", "Rock", 4),
                new Band("Santana", "Rock", 1), 
                new Band("Jimi Hendrix", "Psychedelic Rock", 3)
            };
        }


        public IEnumerator GetEnumerator()
        {
            return new BandArrayEnumerator(_arrayItems);
        }
    }
}