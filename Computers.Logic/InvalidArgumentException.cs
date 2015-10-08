namespace Computers.UI
{
    using System;

    public class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string message) : base(message)
        {
        }
    }
}
