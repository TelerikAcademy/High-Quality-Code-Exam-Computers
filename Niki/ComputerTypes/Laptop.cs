namespace Computers.UI
{
    using System.Collections.Generic;

    public class Laptop : Computer
    {
        internal Laptop(
            Cpu cpu,
            Rammstein ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard,
            LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        readonly LaptopBattery battery;
        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
