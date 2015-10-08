namespace Computers.UI
{
    interface IMotherboard
    {
        int LoadRamValue();
        void SaveRamValue(int value);
        void DrawOnVideoCard(string data);
    }
}
