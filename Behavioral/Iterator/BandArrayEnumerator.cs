using System;
using System.Collections;

namespace Iterator
{
    internal class BandArrayEnumerator : IEnumerator
    {
        private const int FirstPosition = -1;
        private int _actualPosition;
        private readonly IBand[] _arrayItems;

        public BandArrayEnumerator(IBand[] arrayItems)
        {
            _arrayItems = arrayItems;
            _actualPosition = FirstPosition;
        }

        public bool MoveNext()
        {
            _actualPosition++;
            return _actualPosition < _arrayItems.Length;
        }

        public void Reset()
        {
            _actualPosition = FirstPosition;
        }

        public IBand Current
        {
            get
            {
                try
                {
                    return _arrayItems[_actualPosition];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        
        object IEnumerator.Current => Current;
    }
}
