namespace Computers.Logic
{
    /// <summary>
    /// Represents motherboard functionality
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Loads value from the RAM
        /// </summary>
        /// <returns>The loaded value</returns>
        int LoadRamValue();

        /// <summary>
        /// Saves the given value in the RAM
        /// </summary>
        /// <param name="value">The value to save</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Draws text in the video card
        /// </summary>
        /// <param name="data">The text to draw</param>
        void DrawOnVideoCard(string data);
    }
}
