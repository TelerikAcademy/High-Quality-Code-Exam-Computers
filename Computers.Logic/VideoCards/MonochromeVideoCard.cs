namespace Computers.Logic.VideoCards
{
    using System;

    public class MonochromeVideoCard : VideoCard
    {
        protected override ConsoleColor GetColor()
        {
            return ConsoleColor.Gray;
        }
    }
}
