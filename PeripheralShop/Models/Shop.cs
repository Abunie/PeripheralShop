using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Shop
    {
        private List<Computer> PrebuiltConfigurations { get; set; }
        private List<Part> RAM { get; set; }
        private List<Part> HardDrive { get; set; }
        private List<Part> CPU { get; set; }
        private List<Part> Display { get; set; }
        private List<Part> SoundCard { get; set; }
        private List<Part> OS { get; set; }
       

        public Shop(List<Computer> prebuilts, List<Part> ram, List<Part> harddrive,
                    List<Part> cpu, List<Part> display, List<Part> soundcard, List<Part> os)
        {
            this.PrebuiltConfigurations = prebuilts;
            this.RAM = ram;
            this.HardDrive = harddrive;
            this.CPU = cpu;
            this.Display = display;
            this.SoundCard = soundcard;
            this.OS = os;
        }

        public List<Computer> getPrebuiltConfigurations()
        {
            return PrebuiltConfigurations;
        }

        public List<Part> getRAM()
        {
            return RAM;
        }
        public List<Part> getHardDrive()
        {
            return HardDrive;
        }
        public List<Part> getCPU()
        {
            return CPU;
        }
        public List<Part> getDisplay()
        {
            return Display;
        }
        public List<Part> getSoundCard()
        {
            return SoundCard;
        }
        public List<Part> getOS()
        {
            return OS;
        }

       
    }
}
