using System.Collections.Generic;

namespace Mediator
{
    public interface IEmailServer
    {
        void SendEmail(string toAdress, string message);
        IList<string> CheckForNewMails(string emailAddress);
    }
}