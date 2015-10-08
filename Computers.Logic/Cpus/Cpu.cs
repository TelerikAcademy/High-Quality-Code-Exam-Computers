namespace Computers.Logic.Cpus
{
    using System;
    using VideoCards;

    public abstract class Cpu : IMotherboardComponent
    {
        public const string NumberTooHighMessage = "Number too high.";
        public const string NumberTooLowMessage = "Number too low.";
        private const string SquareInfoStringFormat = "Square of {0} is {1}.";

        private static readonly Random Random = new Random();

        private IMotherboard motherboard;

        internal Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        private byte NumberOfCores { get; set; }

        public void AttachTo(IMotherboard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void Rand(int minValue, int maxValue)
        {
            int randomNumber = Random.Next(minValue, maxValue + 1);
            this.motherboard.SaveRamValue(randomNumber);
        }

        public void SquareNumber()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard(NumberTooLowMessage);
            }
            else if (data > this.GetMaxValue())
            {
                this.motherboard.DrawOnVideoCard(NumberTooHighMessage);
            }
            else
            {
                int value = data * data;
                this.motherboard.DrawOnVideoCard(string.Format(SquareInfoStringFormat, data, value));
            }
        }

        protected abstract int GetMaxValue();
    }
}
