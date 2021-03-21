using System;
using System.Collections.Generic;

namespace Visitor
{
    /*
     * Visitor : Represent an operation to be performed on the elements of an object
     * structure. Visitor lets you define a new operation without changing the classes of
     * the elements on which it operates.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<IGameItem>
            {
                new EpicGame("Metal Gear 2", 9.99, 8),
                new EpicGame("Commandos 2", 4.99, 7),
                new SteamGame("Gta V", 35.0, "Rockstar"),
                new SteamGame("XCOM", 9.99, "4K"),
                new SteamGame("Starcraft", 15.0, "Blizzard")
            };

            var gamePriceVisitor = new GamePriceVisitor();
            var gameCountVisitor = new GameCountVisitor();
            foreach (var gameItem in games)
            {
                gameItem.Accept(gamePriceVisitor);
                gameItem.Accept(gameCountVisitor);
            }

            gameCountVisitor.Print();

            Console.ReadKey();
        }
    }
}
