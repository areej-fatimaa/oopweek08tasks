using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
   abstract class Product
    {
        protected string ID;
        protected string Name;
        protected int Price;
        protected int minQuantity;
        protected int Stock;
        public Product(string ID,string name,int price,int minQuantity,int Stock)
        {
            SetID(ID);
            SetName(name);
            SetPrice(price);
            SetminQuantity(minQuantity);
            SetStock(Stock);
        }
        public Product(string id)
        {
            this.ID = id;
        }
        public bool SetID(string ID)
        {
            if (ID !=null)
            {
                this.ID = ID;
                return true;
            }
            return false;
        }
        public bool SetName(string name)
        {
            if (name != null)
            {
                this.Name = name;
                return true;
            }
            return false;
        }
        public bool SetPrice(int price)
        {
            if (price != 0&&price<10000)
            {
                this.Price=price;
                return true;
            }
            return false;
        }

        public bool SetminQuantity(int minQuantity)
        {
            if (minQuantity != 0)
            {
                this.minQuantity=minQuantity;
                return true;
            }
            return false;
        }
        public bool SetStock(int stock)
        {
            if (stock != 0)
            {
                this.Stock=stock;
                return true;
            }
            return false;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetID()
        {
            return ID;
        }
        public int GetPrice()
        {
            return Price;
        }
        public int GetminQuantity()
        {
            return minQuantity;
        }
        public int GetStock()
        {
            return Stock;
        }
        public abstract string ToString();
    }
}
