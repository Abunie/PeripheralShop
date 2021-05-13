using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeripheralShop.Data;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace PeripheralShop.Controllers
{
    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {
           
            List<Computer> prebuilt = new List<Computer>();
            List<Part> RAM = new List<Part>();
            List<Part> HardDrive = new List<Part>();
            List<Part> CPU = new List<Part>();
            List<Part> Display = new List<Part>();
            List<Part> SoundCard = new List<Part>();
            List<Part> OS = new List<Part>();

            
   
            int price1 = 0;
            int price2 = 0;
            int price3 = 0;

           

            PartsDAO partsDAO = new PartsDAO();
            RamDAO ramDAO = new RamDAO();
            CpuDAO cpuDAO = new CpuDAO();
            DisplayDAO displayDAO = new DisplayDAO();
            HarddriveDAO harddriveDAO = new HarddriveDAO();
            SoundcardDAO soundcardDAO = new SoundcardDAO();
            OperatingSystemDAO osDAO = new OperatingSystemDAO();
            ComputerDAO computerDAO = new ComputerDAO();
            

           
            prebuilt = computerDAO.Fetchall();
            RAM = ramDAO.Fetchall();
            Display = displayDAO.Fetchall(); ;
            HardDrive = harddriveDAO.Fetchall();
            CPU = cpuDAO.Fetchall();
            SoundCard = soundcardDAO.Fetchall(); ;
            OS = osDAO.Fetchall();
            Console.WriteLine();


            Shop shop = new Shop(prebuilt, RAM, HardDrive, CPU, Display,SoundCard, OS);

            return View(shop);
        }

        public IActionResult Cart()
        {
                
            List<Item> itemstobuy = new List<Item>();
            String cart = Request.Cookies["cart"];
            if (!string.IsNullOrEmpty(cart))
            {
                String[] parts = cart.Split('/');
                List<int> ids = new List<int>();
                Console.WriteLine("TEST");
                foreach (var part in parts)
                {
                    if (!string.IsNullOrEmpty(part))
                    {
                        // If selected none, ignore
                        if (part != "-1")
                        {
                                ids.Add(int.Parse(part));
                           
                        }
                    }
                }

                PartsDAO partsDAO = new PartsDAO();
                itemstobuy = partsDAO.FetchSome(ids);
            
            }

            Checkout checkout = new Checkout(itemstobuy);
            return View(checkout);
        }

        public IActionResult Contact()
        {


            return View();
        }

        public IActionResult Orders()
        {
            Orders orders;
            OrdersDAO ordersDAO = new OrdersDAO();
            orders = ordersDAO.UserOrders(User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString());

            return View(orders);
        }


        public IActionResult ClearCart()
        {
            Response.Cookies.Delete("cart");
            return RedirectToAction("Cart","Home");
        }

        public IActionResult Purchase()
        {
            if (User.Identity.IsAuthenticated)
            {
                String purchase_desc = "You bought ";
                String purchase_items = "";
                int purchase_price = 0;
                List<Item> itemstobuy = new List<Item>();
                String cart = Request.Cookies["cart"];
                if (!string.IsNullOrEmpty(cart))
                {
                    String[] parts = cart.Split('/');
                    List<int> ids = new List<int>();
                    Console.WriteLine("TEST");
                    foreach (var part in parts)
                    {
                        if (!string.IsNullOrEmpty(part))
                        {
                            // If selected none, ignore
                            if (part != "-1")
                            {
                                ids.Add(int.Parse(part));

                            }
                        }
                    }

                    PartsDAO partsDAO = new PartsDAO();
                    itemstobuy = partsDAO.FetchSome(ids);

                }

                foreach (Item item in itemstobuy)
                {
                    purchase_items = purchase_items + " " + item.getName() + ", ";
                    purchase_price = purchase_price + item.getPrice();

                }
                purchase_desc = purchase_desc + purchase_items + " all for  $" + purchase_price.ToString() + " on " + DateTime.Now.ToString();


                PurchaseDAO purchaseDAO = new PurchaseDAO();
                purchaseDAO.Insert(User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString(), purchase_desc);

            }
                

           
                


            




            Response.Cookies.Delete("cart");
            return View("Success", "Home");
        }



    }
}
