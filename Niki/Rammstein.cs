namespace Computers.UI
{
    class Rammstein
    {
        int value;
        internal Rammstein(int a)
        {
            this.Amount = a;
        }
        int Amount { get; set; }
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