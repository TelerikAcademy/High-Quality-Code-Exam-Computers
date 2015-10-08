namespace Computers.UI
{
    using System.Collections.Generic;

    public abstract class Computer
    {
        protected IEnumerable<HardDriver> HardDrives { get; set; }

        protected HardDriver VideoCard { get; set; }

        protected Cpu Cpu { get; set; }

        protected Rammstein Ram { get; set; }

        internal Computer(
            Cpu cpu,
            Rammstein ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }
    }
}
