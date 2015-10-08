namespace Computers.Logic
{
    using System;

    public class VideoCard
    {
        public bool IsMonochrome { get; set; }

        public void Draw(string a)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}
