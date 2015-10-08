namespace Computers.UI
{
    using System.Collections.Generic;

    public class Server : Computer
    {
        internal Server(
            Cpu cpu,
            Rammstein ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);

            // TODO: Fix it
            this.Cpu.SquareNumber();
        }
    }
}
