namespace Computers.Logic.Cpus
{
    using Computers.Logic.VideoCards;

    public class Cpu64 : Cpu
    {
        private const int MaxValue = 1000;

        public Cpu64(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return MaxValue;
        }
    }
}
