namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using VideoCards;
    using HardDrives;

    public class LenovoComputersFactory : IComputersFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(16);
            var videoCard = new ColorfulVideoCard();
            var battery = new LaptopBattery();
            var laptop = new Laptop(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(1000) },
                videoCard,
                battery);
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new MonochromeVideoCard();
            var pc = new PersonalComputer(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(2000) },
                videoCard);
            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(8);
            var videoCard = new MonochromeVideoCard();
            var server = new Server(
                new Cpu128(2, ram, videoCard),
                ram,
                new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(500), new SingleHardDrive(500) }) },
                videoCard);
            return server;
        }
    }
}
