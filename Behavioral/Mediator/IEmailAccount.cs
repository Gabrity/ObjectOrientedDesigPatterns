using System.Collections.Generic;

namespace Mediator
{
    public interface IEmailAccount
    {
        string EmailAddress { get; }

        void SendEmail(string toAdress, string message);

        IList<string> ReceiveEmails();
    }
}