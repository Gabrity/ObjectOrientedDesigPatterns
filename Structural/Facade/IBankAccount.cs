namespace Facade
{
    public interface IBankAccount
    {
        void WithdrawCash(double requestedAmount, int enteredPin, string cardChipSignature);
        void DepositCash(double amount);
    }
}