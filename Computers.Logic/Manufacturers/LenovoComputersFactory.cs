namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class LenovoComputersFactory : IComputersFactory
    {
        public const string Name = "Lenovo";
        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu64(2),
                new Ram(16),
                new[] { new SingleHardDrive(1000) },
                new ColorfulVideoCard(),
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(2),
                new Ram(4),
                new[] { new SingleHardDrive(2000) },
                new MonochromeVideoCard());
            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu128(2),
                new Ram(8),
                new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(500), new SingleHardDrive(500) }) },
                new MonochromeVideoCard());
            return server;
        }
    }
}
