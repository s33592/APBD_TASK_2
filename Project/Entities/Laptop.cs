using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public enum OS { 
        Windows,
        Linux,
        MacOS
    }
    public enum Architecture { 
        X86,
        X64,
        ARM
    }

    public enum StorageMedium
    {
        HDD,
        SATA_SSD,
        NVMe_SSD
    }
    public class Laptop : Equipment
    {
        public int RamGB { get; }
        public int StorageGB { get;}

        public StorageMedium StorageType { get; }
        public double CpuGHz { get; set; }

        public Architecture CpuArchitecture { get; set; }

        public OS OperatingSystem { get; set; }

        public Laptop(int id, string name,int ramGB,int storageGB,StorageMedium storageType,double cpuGHZ,Architecture cpuArchitecture,OS operatingSystem) : base(id, name) {
            RamGB = ramGB;
            StorageGB = storageGB;
            StorageType = storageType;
            CpuGHz = cpuGHZ;
            CpuArchitecture = cpuArchitecture;
            OperatingSystem = operatingSystem;
        }
        public override string ToString()
        {
            return $"{Id} | {Name} | RAM: {RamGB} GB | {StorageType}: {StorageGB} GB | CPU: {CpuGHz} GHZ | {CpuArchitecture} | {OperatingSystem}";
        }
     
    }
}
