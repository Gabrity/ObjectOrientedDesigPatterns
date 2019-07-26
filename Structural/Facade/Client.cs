using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Facade
{
    public class Client
    {
        private readonly IBankAccount _bankAccount;
        public Client()
        {
            _bankAccount = new BankAccount(1123, "734gkja913");
        }

        public void Manipulate()
        {
            _bankAccount.DepositCash(5000.0);
            _bankAccount.WithdrawCash(300.0, 1123, "734gkja913");
            _bankAccount.WithdrawCash(300.0, 112399, "734gkja913");
        }
    }
}