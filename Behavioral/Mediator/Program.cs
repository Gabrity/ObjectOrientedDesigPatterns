using System;
using System.Collections.Generic;

namespace Mediator
{
    /*
     * Mediator : Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring
     * to each other explicitly, and it lets you vary their interaction independently.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var emailServer = new EmailServer();

            IEmailAccount emailJoe = new EmailAccount(emailServer, "Johnny@hotmail.com");
            IEmailAccount emailJane = new EmailAccount(emailServer, "Jane@hotmail.com");

            emailJoe.SendEmail("Jane@hotmail.com", "Hi There. I would like to order a large pepperoni pizza with extra cheese.");
            emailJoe.SendEmail("Jane@hotmail.com", "Hi. I still have not received my pizza... We are getting hungry.");
            ReceiveAndWriteEmails(emailJane);
            emailJane.SendEmail("Johnny@hotmail.com", "Good Afternnon. We are very sorry for the delay, our staff is working hard to complete all deliveries. " +
                                                      "For your patience we offer you a 10% off coupon on your next delivery. Thank you for choosing us!");
            ReceiveAndWriteEmails(emailJoe);

            Console.ReadKey();
        }


        private static void ReceiveAndWriteEmails(IEmailAccount emailAccount)
        {
            var receivedEmails = emailAccount.ReceiveEmails();
            WriteEmails(receivedEmails, emailAccount.EmailAddress);
        }

        private static void WriteEmails(IList<string> receivedEmails, string adress)
        {
            Console.WriteLine("List of new emails for " + adress + ":\n");
            foreach (var email in receivedEmails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("\n" + "End of list of new emails for " + adress + ".\n");
        }
    }
}
