using System;
using System.Globalization;

namespace Flyweight
{
    /// <summary>
    /// A Concrete Flyweight class
    /// </summary>
    internal class CaliforniaRoll : ISushi
    {
        public CaliforniaRoll()
        {
            Name = "California Roll";
            Ingredients = "rice, nori, sesame seed, salmon, avocado";
            Price = 1.4m;
        }

        public string Name { get; }
        public string Ingredients { get; }
        public decimal Price { get; }

        public void Display(int orderTotal)
        {
            Console.WriteLine("Sushi #" + orderTotal + ": " + Name + " - ingredients: " + Ingredients + "! $" + Price.ToString(CultureInfo.InvariantCulture));
        }
    }
}