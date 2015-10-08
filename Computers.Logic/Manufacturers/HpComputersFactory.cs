namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;
    using ComputerTypes;
    using Cpus;
    using VideoCards;

    public class HpComputersFactory : IComputersFactory
    {
        public Laptop CreateLaptop()
        {
            var card = new ColorfulVideoCard();
            var ram = new Ram(4);
            var laptop = new Laptop(
                new Cpu64(2, ram, card),
                ram,
                new[] { new HardDrive(500, false, 0) },
                card,
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new ColorfulVideoCard();
            var pc = new PersonalComputer(
                new Cpu32(2, ram, videoCard),
                ram,
                new[] { new HardDrive(500, false, 0) },
                videoCard);
            return pc;
        }

        public Server CreateServer()
        {
            var serverRam = new Ram(8 * 4);
            var serverVideo = new MonochromeVideoCard();
            var server = new Server(
                 new Cpu32(4, serverRam, serverVideo),
                 serverRam,
                 new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) },
                 serverVideo);
            return server;
        }
    }
}
