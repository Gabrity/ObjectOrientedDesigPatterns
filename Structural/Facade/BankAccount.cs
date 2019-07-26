using System;

namespace Facade
{
    public class BankAccount : IBankAccount
    {
        private double _balance;
        private readonly IBalanceValidator _balancevalidator;
        private readonly IPinCodeValidator _pinCodeValidator;
        private readonly ICardReaderValidator _cardReaderValidator;
        
        public BankAccount(int pin, string cardChipSignature)
        {
            _balance = 0.0;
            _balancevalidator = new BalanceValidator();
            _pinCodeValidator = new PinCodeValidator(pin);
            _cardReaderValidator = new CardReaderValidator(cardChipSignature);
        }

        public void WithdrawCash(double requestedAmount, int enteredPin, string cardChipSignature)
        {
            bool valid = _pinCodeValidator.IsValid(enteredPin) && _cardReaderValidator.IsValid(cardChipSignature) && _balancevalidator.IsValid(_balance, requestedAmount);
            if (valid)
            {
                _balance = _balance - requestedAmount;
                Console.WriteLine($"Cash of {requestedAmount} withdrawn. New balance is  {_balance}.");
            }
            else
            {
                Console.WriteLine($"Cash withdrawal failed, please try again.");
            }
        }

        public void DepositCash(double amount)
        {
            _balance = _balance + amount;
            Console.WriteLine($"Cash of {amount} deposited. New balance is  {_balance}.");
        }
    }
}