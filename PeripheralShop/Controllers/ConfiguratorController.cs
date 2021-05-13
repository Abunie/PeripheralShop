using Microsoft.AspNetCore.Mvc;
using PeripheralShop.Data;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Controllers
{
    public class ConfiguratorController : Controller
    {
        public IActionResult Index()
        {
            //Computer comp = new Computer();
            List<Part> partlist = new List<Part>();

            List<Part> rams = new List<Part>();
            List<Part> cpus = new List<Part>();
            List<Part> oss = new List<Part>();
            List<Part> displays = new List<Part>();
            List<Part> soundcards = new List<Part>();
            List<Part> harddrives = new List<Part>();
           

            RamDAO ramDAO = new RamDAO();
            CpuDAO cpuDAO = new CpuDAO();
            DisplayDAO displayDAO = new DisplayDAO();
            HarddriveDAO harddriveDAO = new HarddriveDAO();
            SoundcardDAO soundcardDAO = new SoundcardDAO();
            OperatingSystemDAO osDAO = new OperatingSystemDAO();
            rams = ramDAO.Fetchall();
            displays = displayDAO.Fetchall(); ;
            harddrives = harddriveDAO.Fetchall();
            cpus = cpuDAO.Fetchall();
            soundcards = soundcardDAO.Fetchall(); ;
            oss = osDAO.Fetchall();
            





            Configurator conf = new Configurator(rams, cpus, displays, harddrives, soundcards, oss);
            return View(conf);
        }

        [HttpPost]
        public IActionResult Index(string cid)
        {
            ///Computer comp = new Computer();
        
            List<Part> rams = new List<Part>();
            List<Part> cpus = new List<Part>();
            List<Part> oss = new List<Part>();
            List<Part> displays = new List<Part>();
            List<Part> soundcards = new List<Part>();
            List<Part> harddrives = new List<Part>();

          

            RamDAO ramDAO = new RamDAO();
            CpuDAO cpuDAO = new CpuDAO();
            DisplayDAO displayDAO = new DisplayDAO();
            HarddriveDAO harddriveDAO = new HarddriveDAO();
            SoundcardDAO soundcardDAO = new SoundcardDAO();
            OperatingSystemDAO osDAO = new OperatingSystemDAO();
            rams = ramDAO.Fetchall();
            displays = displayDAO.Fetchall(); ;
            harddrives = harddriveDAO.Fetchall();
            cpus = cpuDAO.Fetchall();
            soundcards = soundcardDAO.Fetchall(); ;
            oss = osDAO.Fetchall();


            Configurator conf = new Configurator(rams, cpus, displays, harddrives, soundcards, oss);
            return View(conf);
        }

        [HttpGet]
        public IActionResult ClearSelection()
        {
            Response.Cookies.Delete("picked_display");
            Response.Cookies.Delete("picked_harddrive");
            Response.Cookies.Delete("picked_ram");
            Response.Cookies.Delete("picked_cpu");
            Response.Cookies.Delete("picked_soundcard");
            Response.Cookies.Delete("picked_os");
       

            return RedirectToAction("Index");
        }
    }
}
