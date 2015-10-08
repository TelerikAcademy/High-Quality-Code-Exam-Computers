namespace Computers.UI
{
    public interface IComputersFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}
