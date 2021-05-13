using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public class Checkout
    {
        private List<Item> Cart;

        public Checkout(List<Item> cart)
        {
            this.Cart = cart;
        }

        public List<Item> getCart()
        {
            return Cart;
        }
    }
}
