namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class HpComputersFactory : IComputersFactory
    {
        public const string Name = "HP";

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu64(2),
                new Ram(4),
                new[] { new SingleHardDrive(500) },
                new ColorfulVideoCard(),
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu32(2),
                new Ram(2),
                new[] { new SingleHardDrive(500) },
                new ColorfulVideoCard());
            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                 new Cpu32(4),
                 new Ram(32),
                 new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(1000), new SingleHardDrive(1000) }) },
                 new MonochromeVideoCard());
            return server;
        }
    }
}
