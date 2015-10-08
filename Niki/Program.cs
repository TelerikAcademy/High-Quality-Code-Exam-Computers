namespace Computers.UI
{
    using System;

    using Logic.ComputerTypes;
    using Logic;
    using Logic.Manufacturers;

    public static class Program
    {
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();
            ProcessCommands();
        }

        private static void CreateComputers()
        {
            var manufacturer = Console.ReadLine();
            IComputersFactory computerFactory;
            if (manufacturer == "HP")
            {
                computerFactory = new HpComputersFactory();
            }
            else if (manufacturer == "Dell")
            {
                computerFactory = new DellComputersFactory();
            }
            else if (manufacturer == "Lenovo")
            {
                computerFactory = new LenovoComputersFactory();
            }
            else
            {
                // TODO: Exception?
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            pc = computerFactory.CreatePersonalComputer();
            laptop = computerFactory.CreateLaptop();
            server = computerFactory.CreateServer();
        }

        private static void ProcessCommands()
        {
            while (true)
            {
                var c = Console.ReadLine();
                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var commandName = cp[0];
                var commandArgument = int.Parse(cp[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
