namespace Facade
{
    public class Client
    {
        private readonly IBankAccount _bankAccount;
        public Client()
        {
            var _bankAccount = new BankAccount();
        }

        public void Manipulate()
        {
            _bankAccount.DepositCash(5000.0);
            _bankAccount.WithdrawCash(300.0);
        }
    }

    public class BankAccount : IBankAccount
    {
        private double _balance;
        private readonly IBalanceValidator _balancevalidator;
        private readonly IPinCodeValidator _pinCodeValidator;
        private readonly ICardReaderValidator _cardReaderValidator;
        
        public BankAccount()
        {
            _balance = 0.0;
            _balancevalidator = new BalanceValidator();
            _pinCodeValidator = new PinCodeValidator();
            _cardReaderValidator = new CardReaderValidator();
        }

        public void WithdrawCash(double requestedAmount)
        {
            _pinCodeValidator.Validate();
            _cardReaderValidator.Validate();
            _balancevalidator.Validate(_balance, requestedAmount);
        }

        public void DepositCash(double amount)
        {
            _balance = _balance + amount;
        }
    }

    public class BalanceValidator : IBalanceValidator
    {
        public void Validate(double balance, double requestedAmount)
        {
            throw new System.NotImplementedException();
        }
    }

    internal interface IBalanceValidator
    {
        void Validate(double balance, double requestedAmount);
    }

    public class CardReaderValidator : ICardReaderValidator
    {
        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }

    public class PinCodeValidator : IPinCodeValidator
    {
        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }

    internal interface ICardReaderValidator
    {
        void Validate();
    }

    internal interface IPinCodeValidator
    {
        void Validate();
    }

    public interface IBankAccount
    {
        void WithdrawCash(double amount);
        void DepositCash(double amount);
    }
}