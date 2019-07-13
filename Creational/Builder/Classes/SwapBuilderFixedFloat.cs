using Builder.Interfaces;

namespace Builder.Classes
{
    public class SwapBuilderFixedFloat : ISwapBuilder
    {
        public ISwap Swap { get; }

        public SwapBuilderFixedFloat()
        {
            Swap = new Swap();
        }

        public void BuildLeg1()
        {
            Swap.Leg1 = new FixedLeg();                    
        }

        public void BuildLeg2()
        {
            Swap.Leg2 = new FloatingLeg();
        }

        public void BuildDayCounter()
        {
            Swap.DayCounter = new DayCounter30360();
        }
    }
}
