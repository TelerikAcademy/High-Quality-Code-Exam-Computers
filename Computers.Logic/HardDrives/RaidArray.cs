namespace Computers.Logic.HardDrives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidArray : HardDrive
    {
        const string HardDisksNotAvailableMessage =
            "No hard drive in the RAID array!";
        private List<HardDrive> hardDrives;

        internal RaidArray(List<HardDrive> hardDrives)
        {
            this.hardDrives = hardDrives;
        }

        public override int Capacity
        {
            get
            {
                if (!this.hardDrives.Any())
                {
                    return 0;
                }

                return this.hardDrives.First().Capacity;
            }
        }

        public override string LoadData(int address)
        {
            if (!this.hardDrives.Any())
            {
                // TODO: WTF?
                throw new OutOfMemoryException(HardDisksNotAvailableMessage);
            }

            return this.hardDrives.First().LoadData(address);
        }

        public override void SaveData(int address, string newData)
        {
            foreach (var hardDrive in this.hardDrives)
            {
                hardDrive.SaveData(address, newData);
            }
        }
    }
}
