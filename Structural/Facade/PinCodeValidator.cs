namespace Facade
{
    public class PinCodeValidator : IPinCodeValidator
    {
        private readonly int _pin;

        public PinCodeValidator(int pin)
        {
            _pin = pin;
        }

        public bool IsValid(int enteredPin)
        {
            if (enteredPin == _pin)
            {
                return true;
            }

            return false;
        }
    }
}