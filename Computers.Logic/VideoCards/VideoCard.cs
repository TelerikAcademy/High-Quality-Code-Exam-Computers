namespace Computers.Logic.VideoCards
{
    using System;

    public abstract class VideoCard
    {
        public bool IsMonochrome { get; internal set; }

        public void Draw(string a)
        {
            var color = this.GetColor();
            Console.ForegroundColor = color;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        protected abstract ConsoleColor GetColor();
    }
}
