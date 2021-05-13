using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Configurator
    {
        //private Computer Computer;
        private List<Part> RAMs;
        private List<Part> CPUs;
        private List<Part> Displays;
        private List<Part> Harddrives;
        private List<Part> Soundcards;
        private List<Part> OS;

        public Configurator( List<Part> rams, List<Part> cpus,
                            List<Part> displays, List<Part> harddrives, List<Part> soundcards,
                            List<Part> os
                           )
        {
            //this.Computer = comp;
            this.RAMs = rams;
            this.CPUs = cpus;
            this.Displays = displays;
            this.Harddrives = harddrives;
            this.Soundcards = soundcards;
            this.OS = os;
        }


        public List<Part> getRAMs()
        {
            return RAMs;
        }

        public List<Part> getCPUs()
        {
            return CPUs;
        }

        public List<Part> getDisplays()
        {
            return Displays;
        }

        public List<Part> getHarddrives()
        {
            return Harddrives;
        }

        public List<Part> getSoundcards()
        {
            return Soundcards;
        }

        public List<Part> getOS()
        {
            return OS;
        }
    }
}

