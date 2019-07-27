using System;
using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// The Flyweight Factory class
    /// </summary>
    class SushiFactory
    {
        // singleton objets stored in the factory
        private Temaki _temaki;
        private SalmonMaki _salmonMaki;
        private CaliforniaRoll _californiaRoll;

        public ISushi GetTemaki()
        {
            if (ReferenceEquals(_temaki, null))
            {
                _temaki = new Temaki();
            }

            return _temaki;
        }

        public ISushi GetSalmonMaki()
        {
            if (ReferenceEquals(_salmonMaki, null))
            {
                _salmonMaki = new SalmonMaki();
            }

            return _salmonMaki;
        }

        public ISushi GetCaliforniaRoll()
        {
            if (ReferenceEquals(_californiaRoll, null))
            {
                _californiaRoll = new CaliforniaRoll();
            }

            return _californiaRoll;
        }

        public ISushi GetSushi(char key)
        {
            switch (key)
            {
                case 'T':
                    return GetTemaki();
                case 'S':
                    return GetSalmonMaki();
                case 'C':
                    return GetCaliforniaRoll();
                default:
                    Console.WriteLine($"Invalid sushi character {key}.");
                    return null;
            }
        }
    }
}