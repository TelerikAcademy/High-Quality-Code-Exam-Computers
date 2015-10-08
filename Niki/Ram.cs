namespace Computers.UI
{
    public class Ram
    {
        int value;
        internal Ram(int a)
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