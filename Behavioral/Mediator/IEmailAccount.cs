using System.Collections.Generic;

namespace Mediator
{
    public interface IEmailAccount
    {
        void SendEmail(string toAdress, string message);

        IList<string> ReceiveEmails();
    }
}