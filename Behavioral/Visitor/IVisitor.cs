namespace Visitor
{
    public interface IVisitor
    {
        void VisitSteamGame(ISteamGame steamGame);
        void VisitEpicGame(IEpicGame epicGame);
    }
}
