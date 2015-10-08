namespace Computers.Logic.Cpus
{
    using System;
    using VideoCards;

    public abstract class Cpu : IMotherboardComponent
    {
        private static readonly Random Random = new Random();

        private IMotherboard motherboard;

        // TODO: Should CPU to know about RAM and VideoCard
        internal Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        private byte NumberOfCores { get; set; }

        public void AttachTo(IMotherboard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void Rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.motherboard.SaveRamValue(randomNumber);
        }

        public void SquareNumber()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        protected abstract int GetMaxValue();
    }
}
