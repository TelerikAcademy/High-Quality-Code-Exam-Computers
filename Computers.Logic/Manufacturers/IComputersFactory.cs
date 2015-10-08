namespace Computers.Logic.Manufacturers
{
    using Computers.Logic.ComputerTypes;

    public interface IComputersFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}
