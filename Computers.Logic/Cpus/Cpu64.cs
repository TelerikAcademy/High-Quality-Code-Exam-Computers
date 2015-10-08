namespace Computers.Logic.Cpus
{
    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
        }

        protected override int GetMaxValue()
        {
            return 1000;
        }
    }
}
