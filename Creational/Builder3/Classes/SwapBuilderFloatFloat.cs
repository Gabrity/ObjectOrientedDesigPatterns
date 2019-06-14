using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SwapBuilderFloatFloat : ISwapBuilder
    {
        public ISwap Swap { get; }

        public SwapBuilderFloatFloat()
        {
            Swap = new Swap();
        }

        public void BuildLeg1()
        {
            Swap.Leg1 = new FloatingLeg();
        }

        public void BuildLeg2()
        {
            Swap.Leg2 = new FloatingLeg();
        }

        public void BuildDayCounter()
        {
            Swap.DayCounter = new DayCounterActual360();
        }
    }
}
