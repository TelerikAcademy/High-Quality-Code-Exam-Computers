namespace Computers.Logic
{
    public class Ram
    {
        private int value;

        internal Ram(int a)
        {
            this.Amount = a;
        }

        private int Amount { get; set; }

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