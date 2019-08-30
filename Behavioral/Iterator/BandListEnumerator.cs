using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    internal class BandListEnumerator : IEnumerator
    {
        private const int FirstPosition = -1;
        private int _actualPosition;
        private readonly IList<IBand> _listItems;

        public BandListEnumerator(IList<IBand> listItems)
        {
            _listItems = listItems;
            _actualPosition = FirstPosition;
        }

        public bool MoveNext()
        {
            _actualPosition++;
            return _actualPosition < _listItems.Count;
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
                    return _listItems[_actualPosition];
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
