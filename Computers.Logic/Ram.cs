namespace Computers.Logic
{
    public class Ram : IRam
    {
        private int value;

        public Ram(int amount)
        {
            this.Amount = amount;
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