namespace Computers.UI
{
    using System;
    using System.Collections.Generic;

    public class DellComputersFactory : IComputersFactory
    {
        // TODO: Fix naming
        public Laptop CreateLaptop()
        {
            var ram2 = new Rammstein(8);
            var videoCard1 = new HardDriver()
            {
                IsMonochrome = false
            };
            var laptop = new Laptop(
                new Cpu(8 / 2, ((32)), ram2, videoCard1),
                ram2,
                new[] { new HardDriver(1000, false, 0) },
                videoCard1,
                new LaptopBattery());
            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Rammstein(8);
            var videoCard = new HardDriver { IsMonochrome = false };
            var pc = new PersonalComputer(new Cpu(8 / 2, 64, ram, videoCard), ram, new[] { new HardDriver(1000, false, 0) }, videoCard);
            return pc;
        }

        public Server CreateServer()
        {
            var ram1 = new Rammstein(8 * 8);
            var card = new HardDriver();
            var server = new Server(
                 new Cpu(8, 64, ram1, card),
                 ram1,
                 new List<HardDriver> {
                            new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(2000, false, 0), new HardDriver(2000, false, 0) })
                     }, card);
            return server;
        }
    }
}
