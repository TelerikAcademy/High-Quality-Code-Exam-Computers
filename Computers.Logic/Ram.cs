namespace Computers.Logic
{
    public class Ram : IRam
    {
        private int value;

        public Ram(int a)
        {
            this.Amount = a;
        }

        public int Amount { get; private set; }

        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}