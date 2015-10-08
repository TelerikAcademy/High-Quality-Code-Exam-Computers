namespace Computers.Logic.HardDrives
{
    public abstract class HardDrive
    {
        public abstract int Capacity { get; }

        public abstract void SaveData(int addr, string newData);

        public abstract string LoadData(int address);
    }
}
