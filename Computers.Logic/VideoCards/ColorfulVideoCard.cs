namespace Computers.Logic.VideoCards
{
    using System;

    public class ColorfulVideoCard : VideoCard
    {
        protected override ConsoleColor GetColor()
        {
            return ConsoleColor.Green;
        }
    }
}
