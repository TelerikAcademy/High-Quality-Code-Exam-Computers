namespace Computers.Logic.VideoCards
{
    using System;

    public abstract class VideoCard
    {
        public bool IsMonochrome { get; internal set; }

        public void Draw(string textMessage)
        {
            var color = this.GetColor();
            Console.ForegroundColor = color;
            Console.WriteLine(textMessage);
            Console.ResetColor();
        }

        protected abstract ConsoleColor GetColor();
    }
}
