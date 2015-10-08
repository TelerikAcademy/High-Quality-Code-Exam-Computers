namespace Computers.Logic
{
    public interface ILaptopBattery
    {
        int Percentage { get; set; }

        void Charge(int percentage);
    }
}