using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Models
{
    public abstract class Item
    {
        private String Name;
        private String Description;
        private String Type;
        private String Image;
        private int Price;
        private int ItemId;

        protected Item()
        {
        }

        protected Item(int id, string name, string desc, string type, string image, int price)
        {
            ItemId = id;
            Name = name;
            Description = desc;
            Type = type;
            Price = price;
            Image = image;
        }

        public int getItemId()
        {
            return ItemId;
        }

        public String getName()
        {
            return Name;
        }

        public String getType()
        {
            return Type;
        }

        public String getDescription()
        {
            return Description;
        }

        public String getImage()
        {
            return Image;
        }

        public int getPrice()
        {
            return Price;
        }

        public override String ToString()
        {
            return this.Name;
        }

        public void setName(String name)
        {
            this.Name = name;
        }

        public void setDescription(String desc)
        {
            this.Description = desc;
        }

        public void setPrice(int price)
        {
            this.Price = price;
        }

        public void setType(String type)
        {
            this.Type = type;
        }
        public void setImage(String image)
        {
            this.Image = image;
        }





    }
}
