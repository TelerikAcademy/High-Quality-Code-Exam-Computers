namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;

    public class LenovoComputersFactory : IComputersFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(16);
            var videoCard = new VideoCard();
            var battery = new LaptopBattery();
            var laptop = new Laptop(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new HardDrive(1000, false, 0) },
                videoCard,
                battery);
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new VideoCard() { IsMonochrome = true };
            var pc = new PersonalComputer(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new HardDrive(2000, false, 0) },
                videoCard);
            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard();
            var server = new Server(
                new Cpu128(2, ram, videoCard),
                ram,
                new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(500, false, 0), new HardDrive(500, false, 0) }) },
                videoCard);
            return server;
        }
    }
}
