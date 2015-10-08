namespace Computers.Logic.ComputerTypes
{
    using Cpus;
    using System.Collections.Generic;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        internal Laptop(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDrive> hardDrives,
            VideoCard videoCard,
            LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
