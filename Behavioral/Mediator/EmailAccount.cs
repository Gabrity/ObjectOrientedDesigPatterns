using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mediator
{
    public class EmailAccount : IEmailAccount
    {
        public string EmailAddress { get; }

        private readonly IEmailServer _emailServer;

        public EmailAccount(IEmailServer emailServer, string emailAddress)
        {
            EmailAddress = emailAddress;
            _emailServer = emailServer;
        }

        public void SendEmail(string toAdress, string message)
        {
            _emailServer.SendEmail(toAdress, message);
        }

        public IList<string> ReceiveEmails()
        {
            return _emailServer.CheckForNewMails(EmailAddress);
        }
    }
}