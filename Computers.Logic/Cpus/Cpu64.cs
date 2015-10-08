namespace Computers.Logic.Cpus
{
    using Computers.Logic.VideoCards;

    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return 1000;
        }
    }
}
