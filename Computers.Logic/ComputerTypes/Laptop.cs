namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class Laptop : Computer
    {
        private const string BatteryStatusStringFormat
            = "Battery status: {0}%";

        private readonly ILaptopBattery battery;

        internal Laptop(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDrive> hardDrives,
            VideoCard videoCard,
            ILaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format(BatteryStatusStringFormat, this.battery.Percentage));
        }
    }
}
