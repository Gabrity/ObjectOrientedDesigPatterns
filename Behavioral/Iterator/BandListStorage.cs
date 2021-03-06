﻿using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class BandListStorage : IEnumerable
    {
        private readonly IList<IBand> _listItems;

        public BandListStorage()
        {
            _listItems = new List<IBand>
            {
                new Band("Johnas Brothers", "Pop", 3),
                new Band("Slipknot", "Death Metal", 8),
                new Band("U2", "Rock", 4),
            };
        }
        
        public IEnumerator GetEnumerator()
        {
            return new BandListEnumerator(_listItems);
        }
    }
}