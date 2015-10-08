namespace Computers.Logic.Cpus
{
    using VideoCards;
    using System;

    public abstract class Cpu
    {
        private static readonly Random Random = new Random();

        private readonly Ram ram;

        private readonly VideoCard videoCard;

        // TODO: Should CPU to know about RAM and VideoCard
        internal Cpu(byte numberOfCores, Ram ram, VideoCard videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        private byte NumberOfCores { get; set; }

        internal void Rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.ram.SaveValue(randomNumber);
        }

        public void SquareNumber()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        protected abstract int GetMaxValue();
    }
}
