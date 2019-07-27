using System;
using System.Globalization;

namespace Flyweight
{
    /// <summary>
    /// A Concrete Flyweight class
    /// </summary>
    public class SalmonMaki : ISushi
    {
        public SalmonMaki()
        {
            Name = "Salmon maki";
            Ingredients = "rice, nori, salmon";
            Price = 0.7m;
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