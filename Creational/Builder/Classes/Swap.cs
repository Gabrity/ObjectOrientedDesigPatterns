using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Swap : ISwap
    {
        public IDayCounter DayCounter { get; set; }
        public ILeg Leg1 { get; set; }
        public ILeg Leg2 { get; set; }
    }
}
