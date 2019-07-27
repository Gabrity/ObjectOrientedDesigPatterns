using System;
using System.Globalization;

namespace Flyweight
{
    /// <summary>
    /// A  Concrete Flyweight class
    /// </summary>
    internal class Temaki : ISushi
    {
        public Temaki()
        {
            Name = "Temaki";
            Ingredients = "rice, nori, sesame seed, tuna, avocado";
            Price = 2.00m;
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