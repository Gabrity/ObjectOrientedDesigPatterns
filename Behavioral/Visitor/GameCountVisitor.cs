using System;

namespace Visitor
{
    public class GameCountVisitor : IVisitor
    {
        private int _steamGameCount = 0;
        private int _epicGameCount = 0;

        public void VisitSteamGame(ISteamGame steamGame)
        {
            _steamGameCount++;
        }

        public void VisitEpicGame(IEpicGame epicGame)
        {
            _epicGameCount++;
        }

        public void Print()
        {
            Console.WriteLine("You have " + _steamGameCount + " steam games.");
            Console.WriteLine("You have " + _epicGameCount + " epic games.");
        }
    }
}