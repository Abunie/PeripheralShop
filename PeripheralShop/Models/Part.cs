using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Part :Item
    {
        public Part(int id, String name, String desc, String type, String image, int price)
            : base(id, name, desc, type,image, price)
        {
        }
    }
}
