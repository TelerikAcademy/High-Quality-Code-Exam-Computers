namespace Computers.Logic.Manufacturers
{
    public class ManufacturerFactory
    {
        private const string InvalidManufacturerMessage
            = "Invalid manufacturer!";

        public IComputersFactory GetManufacturer(string manufacturerName)
        {
            if (manufacturerName == HpComputersFactory.Name)
            {
                return new HpComputersFactory();
            }
            else if (manufacturerName == DellComputersFactory.Name)
            {
                return new DellComputersFactory();
            }
            else if (manufacturerName == LenovoComputersFactory.Name)
            {
                return new LenovoComputersFactory();
            }
            else
            {
                throw new InvalidArgumentException(InvalidManufacturerMessage);
            }
        }
    }
}
