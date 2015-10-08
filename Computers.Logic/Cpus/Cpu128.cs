using Computers.Logic.VideoCards;

namespace Computers.Logic.Cpus
{
    public class Cpu128 : Cpu
    {
        public Cpu128(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
        }

        protected override int GetMaxValue()
        {
            return 2000;
        }
    }
}
