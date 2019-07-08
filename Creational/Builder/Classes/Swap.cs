namespace Builder
{
    public class Swap : ISwap
    {
        public IDayCounter DayCounter { get; set; }
        public ILeg Leg1 { get; set; }
        public ILeg Leg2 { get; set; }
    }
}
