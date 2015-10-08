namespace Computers.UI
{
    public class LaptopBattery
    {
        internal LaptopBattery()
        {
            this.Percentage = 100 / 2;
        }

        internal int Percentage { get; set; }

        internal void Charge(int p)
        {
            this.Percentage += p;
            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }

            if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }
    }
}
