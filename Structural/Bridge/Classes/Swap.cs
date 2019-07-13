using System;
using Bridge.Interfaces;

namespace Bridge.Classes
{
    public class Swap : ISwap
    {
        public IDayCounter DayCounter { get; set; }
        public ILeg Leg1 { get; set; }
        public ILeg Leg2 { get; set; }

        public void CalculatePresentValue()
        {
            Console.WriteLine($"Calculating present value of a swap with these attributes:");
            Console.WriteLine($"Day counter: {DayCounter.Name}");
            Console.WriteLine($"Leg1: {Leg1.Name}");
            Console.WriteLine($"Leg2: {Leg2.Name}");
        }
    }
}
