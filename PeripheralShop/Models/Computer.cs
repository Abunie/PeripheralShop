using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Computer : Item
    {
        public Computer(int compid, String name, String desc, String image, int price)
        : base(compid, name, desc, "Computer", image, price)
        {
        }
    }
}
