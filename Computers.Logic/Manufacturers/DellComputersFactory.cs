namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using VideoCards;
    using HardDrives;

    public class DellComputersFactory : IComputersFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(8);
            var videoCard = new ColorfulVideoCard();
            var laptop = new Laptop(
                new Cpu32(4, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(1000) },
                videoCard,
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(8);
            var videoCard = new ColorfulVideoCard();
            var pc = new PersonalComputer(
                new Cpu64(4, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(1000) },
                videoCard);
            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(64);
            var card = new MonochromeVideoCard();
            var server = new Server(
                 new Cpu64(8, ram, card),
                 ram,
                 new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(2000), new SingleHardDrive(2000) }) },
                 card);
            return server;
        }
    }
}
