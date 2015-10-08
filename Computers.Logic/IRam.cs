namespace Computers.Logic
{
    public interface IRam
    {
        int Amount { get; }

        int LoadValue();

        void SaveValue(int newValue);
    }
}