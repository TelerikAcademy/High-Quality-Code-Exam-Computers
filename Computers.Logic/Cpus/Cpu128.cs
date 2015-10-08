namespace Computers.Logic.Cpus
{
    using Computers.Logic.VideoCards;

    public class Cpu128 : Cpu
    {
        private const int MaxValue = 2000;

        public Cpu128(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return MaxValue;
        }
    }
}
