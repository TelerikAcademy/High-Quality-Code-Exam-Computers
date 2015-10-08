namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class PersonalComputer : Computer
    {
        private const string WrongNumberStringFormat = "You didn't guess the number {0}.";
        private const string WinMessage = "You win!";
        internal PersonalComputer(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDrive> hardDrives,
            VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number != guessNumber)
            {
                this.VideoCard.Draw(string.Format(WrongNumberStringFormat, number));
            }
            else
            {
                this.VideoCard.Draw(WinMessage);
            }
        }
    }
}
