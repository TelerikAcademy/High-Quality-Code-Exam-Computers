namespace Computers.Logic.Cpus
{
    using Computers.Logic.VideoCards;

    public class Cpu32 : Cpu
    {
        public Cpu32(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return 500;
        }
    }
}
