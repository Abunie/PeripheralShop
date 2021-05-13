using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Orders
    {
        private List<String> Order;
        public Orders(List<String> order)
        {
            this.Order = order;
        }
        public List<String> getOrders()
        {
            return Order;
        }
    }
}
