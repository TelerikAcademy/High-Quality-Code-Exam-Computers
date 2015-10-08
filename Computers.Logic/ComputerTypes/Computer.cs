namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public abstract class Computer
    {
        private Motherboard motherboard;

        internal Computer(
            Cpu cpu,
            IRam ram,
            IEnumerable<HardDrive> hardDrives,
            VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.motherboard = new Motherboard(this.Cpu, this.Ram, this.VideoCard);
        }

        protected IEnumerable<HardDrive> HardDrives { get; set; }

        protected VideoCard VideoCard { get; set; }

        protected Cpu Cpu { get; set; }

        protected IRam Ram { get; set; }
    }
}
