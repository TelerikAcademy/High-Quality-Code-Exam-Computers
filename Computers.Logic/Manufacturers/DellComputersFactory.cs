namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class DellComputersFactory : IComputersFactory
    {
        public const string Name = "Dell";

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu32(4),
                new Ram(8),
                new[] { new SingleHardDrive(1000) },
                new ColorfulVideoCard(),
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(4),
                new Ram(8),
                new[] { new SingleHardDrive(1000) },
                new ColorfulVideoCard());
            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                 new Cpu64(8),
                 new Ram(64),
                 new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(2000), new SingleHardDrive(2000) }) },
                 new MonochromeVideoCard());
            return server;
        }
    }
}
