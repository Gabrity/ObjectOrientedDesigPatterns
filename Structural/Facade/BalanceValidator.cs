namespace Facade
{
    public class BalanceValidator : IBalanceValidator
    {
        public bool IsValid(double balance, double requestedAmount)
        {
            if (balance >= requestedAmount)
            {
                return true;
            }

            return false;
        }
    }
}