using System;

namespace Visitor
{
    // A new behavior can be added independently of the original item structure
    public class GamePriceVisitor : IVisitor
    {
        public void VisitSteamGame(ISteamGame steamGame)
        {
            Console.WriteLine("Your steam game " + steamGame.Name + " is " + steamGame.Price + "$");
        }

        public void VisitEpicGame(IEpicGame epicGame)
        {
            Console.WriteLine("Your epic game " + epicGame.Name + " is " + epicGame.Price + "$");
        }
    }
}