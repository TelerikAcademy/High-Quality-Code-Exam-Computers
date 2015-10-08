namespace Computers.Logic
{
    using Computers.Logic.VideoCards;
    using Cpus;

    public class Motherboard : IMotherboard
    {
        public Motherboard(Cpu cpu, IRam ram, VideoCard videoCard)
        {
            cpu.AttachTo(this);
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        private IRam Ram { get; set; }

        private VideoCard VideoCard { get; set; }

        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }

        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }
    }
}
