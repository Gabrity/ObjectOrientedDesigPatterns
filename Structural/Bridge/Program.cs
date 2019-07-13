using System;
using Bridge.Classes;
using Bridge.Interfaces;

namespace Bridge
{
    class Program
    {
        /*
         * Bridge: Decouple an abstraction from its implementation so that the two can vary independently.
         *
         * The bridge design pattern is basically about using composition to define the behavior of a certain class.
         * For this a good example was created already for swaps in the builder design pattern project. This is a duplicate of this.
         */
        static void Main(string[] args)
        {
            char enteredKey = GetInputFromUser();

            var swapBuilder = GetSwapBuilder(enteredKey);

            var swapEngineer = new SwapEngineer(swapBuilder);

            swapEngineer.MakeSwap();
            var swap = swapEngineer.GetSwap();
            swap.CalculatePresentValue();
            Console.ReadKey();
        }

        private static ISwapBuilder GetSwapBuilder(char enteredKey)
        {
            ISwapBuilder swapBuilder;
            switch (enteredKey)
            {
                case 'a':
                    swapBuilder = new SwapBuilderFixedFloat();
                    break;
                case 'b':
                    swapBuilder = new SwapBuilderFloatFloat();
                    break;
                default:
                    throw new ArgumentException("Invalid input, enter a or b.");
            }

            return swapBuilder;
        }

        private static char GetInputFromUser()
        {
            Console.WriteLine($"What kind of swap would you like to build, (a) fixed for float or (b) float for float? Enter a/b");
            var enteredKey = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return enteredKey;
        }
    }
}
